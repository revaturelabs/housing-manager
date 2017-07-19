using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using HousingManager.Business.Library.Models;
using HousingManager.Business.Service.Brokers;

namespace HousingManager.Business.Tests
{
    [TestFixture]
    public class BrokerFactoryTests
    {
        [Test]
        public void CreateBrokerTest()
        {
            var TestBroker = BrokerFactory<Person>.GetInstance();

            Assert.NotNull(TestBroker);
        }

    }
}
