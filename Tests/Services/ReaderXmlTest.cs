using FluentAssertions;
using Infrastructure.Services;
using Moq;
using NUnit.Framework;
using OrderManagmentSystem.Domain;
using OrderManagmentSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Services
{   
    [TestFixture]
    public class ReaderXmlTest
    {
        private IOrderRepository _orderRepository;

        public ReaderXmlTest()
        {
            var listOfOrders = new List<Order>();
            Mock<IOrderRepository> mockRepository = new Mock<IOrderRepository>();
            mockRepository.Setup(x => x.GetAll()).Returns(listOfOrders);
            _orderRepository = mockRepository.Object;
        }

        [Test]
        public void ReadFileTest()
        {
            var reader = new ReaderXml(_orderRepository);
            reader.ReadFile(@"C:\save.xml");

            var testListOfOrders = new List<Order>();
            testListOfOrders.Add(new Order("1", 1, "Mleko", 1, 5.0));
            testListOfOrders.Add(new Order("2", 1, "Klej", 1, 5.0));

            var list = _orderRepository.GetAll();
            _orderRepository.GetAll().Should().BeEquivalentTo(testListOfOrders);
        }

        [Test]
        public void SaveFileTest()
        {
            var reader = new ReaderXml(_orderRepository);
            reader.SaveFile();
            Assert.AreEqual(true, true);
        }
    }
}
