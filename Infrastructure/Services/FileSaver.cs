using OrderManagmentSystem.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Infrastructure.Services
{
    public class FileSaver
    {
        private readonly OrderRaports _orderRaports;

        public FileSaver(OrderRaports orderRaports)
        {
            _orderRaports = orderRaports;
        }

        public void SaveFile(string path, char selectedMenu, string clientId, double min, double max)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                StringBuilder stringBuilder = new StringBuilder();
                switch (selectedMenu)
                {
                    case 'A':
                        {
                            var result = _orderRaports.GetOrderAmount();
                            stringBuilder.AppendLine($"Order amount:, {result}");
                            break;
                        }
                    case 'B':
                        {
                            var result = _orderRaports.GetOrderAmountPerClient(clientId);
                            stringBuilder.AppendLine($"Order amount for client with id '{clientId}':, {result}");
                            break;
                        }
                    case 'C':
                        {
                            var result = _orderRaports.GetTotalPriceOfOrders();
                            stringBuilder.AppendLine($"Total Price of orders':, {result}");
                            break;
                        }
                    case 'D':
                        {
                            var result = _orderRaports.GetTotalPriceOfOrdersPerClient(clientId);
                            stringBuilder.AppendLine($"Total price of orders for client with id '{clientId}':, {result}");
                            break;
                        }
                    case 'E':
                        {
                            stringBuilder.AppendLine("ClientId,RequestId,Name,Quantity,Price");
                            foreach(var val in _orderRaports.GetTotalListOfOrders())
                            {
                                stringBuilder.AppendLine(string.Format("{0},{1},{2},{3},{4}",
                                    val.ClientId, val.RequestId, val.Name, val.Quantity, val.Price));
                            }
                            break;
                        }
                    case 'F':
                        {
                            stringBuilder.AppendLine("ClientId,RequestId,Name,Quantity,Price");
                            foreach (var val in _orderRaports.GetTotalListOfOrdersPerClient(clientId))
                            {
                                stringBuilder.AppendLine(string.Format("{0},{1},{2},{3},{4}",
                                    val.ClientId, val.RequestId, val.Name, val.Quantity, val.Price));
                            }
                            break;
                        }



                    case 'I':
                        {
                            stringBuilder.AppendLine("Name,AmountOfOrders");
                            foreach (var val in _orderRaports.GetAmountOfOrdersGroupedByName())
                            {
                                stringBuilder.AppendLine(string.Format("{0},{1}", val.Key, val.Value));
                            }
                            break;
                        }
                    case 'J':
                        {
                            stringBuilder.AppendLine("Name,AmountOfOrders");
                            foreach (var val in _orderRaports.GetAmountOfOrdersGroupedByNamePerClient(clientId))
                            {
                                stringBuilder.AppendLine(string.Format("{0},{1}", val.Key, val.Value));
                            }
                            break;
                        }
                    case 'K':
                        {
                            stringBuilder.AppendLine("ClientId,RequestId,Name,Quantity,Price");
                            foreach (var val in _orderRaports.GetOrdersInPriceRange(min, max))
                            {
                                stringBuilder.AppendLine(string.Format("{0},{1},{2},{3},{4}",
                                    val.ClientId, val.RequestId, val.Name, val.Quantity, val.Price));
                            }
                            break;
                        }

                }
                streamWriter.Write(stringBuilder.ToString());
            }
               
        }
    }
}
