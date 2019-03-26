using Infrastructure.Services;
using OrderManagmentSystem.Domain;
using OrderManagmentSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace OrderManagmentSystem.Services
{
    public class CsvReader : IFileReader
    {
        private readonly IOrderRepository _orderRepository;

        public CsvReader(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        // Structure of csv file should be constant
        public void ReadFile(string path)
        {
            Encoding enc = Encoding.GetEncoding("Windows-1250");

            using (var reader = new StreamReader(path, enc))
            {
                var firstLine = reader.ReadLine();
                if(firstLine != "Client_Id,Request_id,Name,Quantity,Price")
                {
                    throw new Exception("Incorrect format of first line in .csv file");
                }
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    string clientId = values[0];
                    long requestId = long.Parse(values[1]);
                    string name = values[2];
                    int quantity = int.Parse(values[3]);
                    double price = double.Parse(values[4], CultureInfo.InvariantCulture);

                    Order order = new Order(clientId, requestId, name, quantity, price);
                    _orderRepository.Add(order);
                }
            }
        }
    }
}
