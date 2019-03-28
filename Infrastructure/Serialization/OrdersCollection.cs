using OrderManagmentSystem.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Infrastructure.Serialization
{
    [Serializable]
    [XmlRoot("requests")]
    public class OrdersCollection
    {
        //[XmlArray("request"), XmlArrayItem(typeof(Order), ElementName ="Bar")]
        [XmlElement("request")]
        public List<Order> Orders { get; set; }

        public OrdersCollection(List<Order> orders)
        {
            Orders = orders;
        }
        public OrdersCollection()
        {

        }
    }
}
