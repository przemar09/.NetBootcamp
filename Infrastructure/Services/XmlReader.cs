using OrderManagmentSystem.Domain;
using OrderManagmentSystem.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Linq;
using System.Xml;

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
            var serializer = new XmlSerializer(typeof(List<Order>), new XmlRootAttribute("requests"));
            string input = File.ReadAllText(path);
            StringReader reader = new StringReader(input);
            List<Order> list = (List<Order>)serializer.Deserialize(reader);

        }

        //public void ReadFile(string path)
        //{
        //    XmlSerializer serializer = new XmlSerializer(typeof(Order), new XmlRootAttribute("requests"));
        //    var settings = new XmlReaderSettings { ConformanceLevel = ConformanceLevel.Fragment };
        //    using (StreamReader streamReader = new StreamReader(path))
        //    using (var xmlTextReader = XmlReader.Create(streamReader, settings))
        //    {
        //        while (xmlTextReader.Read())
        //        {   // Skip whitespace
        //            if (xmlTextReader.NodeType == XmlNodeType.Element)
        //            {
        //                using (var subReader = xmlTextReader.ReadSubtree())
        //                {
                            
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
