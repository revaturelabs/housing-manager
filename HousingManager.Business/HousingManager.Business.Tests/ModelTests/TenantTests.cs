using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using HousingManager.Business.Library.Models;

namespace HousingManager.Business.Tests.ModelTests
{
    [TestFixture]
    public class TenantTests
    {
        [Test]
        public void TenantCreateTest()
        {
            Tenant test = new Tenant();

            Assert.IsNotNull(test);
        }

        [Test]
        public void TenantFullCreateTest()
        {
            Tenant test = new Tenant();
            test.BatchName = "TestName";

            Assert.IsNotNull(test.Address);
            Assert.IsNotNull(test.MoveIn);
            Assert.IsNotNull(test.BatchName);
        }
    }
}
