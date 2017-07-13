using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using HousingManager.Business.Library;

namespace HousingManager.Business.Tests
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