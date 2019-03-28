using OrderManagmentSystem.Domain;
using OrderManagmentSystem.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Linq;
using System.Xml;
using Infrastructure.Serialization;

namespace Infrastructure.Services
{
    public class ReaderXml : IFileReader
    {
        private readonly IOrderRepository _orderRepository;

        public ReaderXml(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void ReadFile(string path)
        {
            var serialization = new XmlSerializer(typeof(OrdersCollection));
            using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                var input = (OrdersCollection)serialization.Deserialize(fileStream);
                foreach(var val in input.Orders)
                {
                    _orderRepository.Add(val);
                }
            }
            
        }

            public void SaveFile()
        {
            var serialization = new XmlSerializer(typeof(OrdersCollection));
            var listOfOrders = new List<Order>()
            {
                new Order("1", 1, "Mleko", 1, 5.0),
                new Order("2", 1, "Klej", 1, 5.0)
            };

            var orders = new OrdersCollection();
            orders.Orders = new List<Order>();
            orders.Orders.Add(new Order("1", 1, "Mleko", 1, 5.0));
            orders.Orders.Add(new Order("2", 1, "Klej", 1, 5.0));
            using (var fileStream = new FileStream(@"C:\save.xml", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                serialization.Serialize(fileStream, orders);
            }
        }
    }
}
