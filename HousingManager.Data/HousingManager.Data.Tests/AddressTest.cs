using HousingManager.Data.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Data.Tests
{
    [TestFixture]
    public class AddressTest
    {
        [Test]
        public void TestAddressModelSuccess()
        {
            var a = new Broker();
            var address = a.AddAddress();
            Assert.IsNotNull(address);
        }

        [Test]
        public void TestAddressModelFail()
        {
            var a = new Broker();
            var address = a.AddAddress2();
            Assert.IsNull(address);
        }
    }
}
