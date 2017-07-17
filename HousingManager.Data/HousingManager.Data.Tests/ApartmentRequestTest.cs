using HousingManager.Data.Service.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Data.Tests
{
    [TestFixture]
    public class ApartmentRequestTest
    {
        [Test]
        public void SubmittedPositive()
        {
            var c = new ApartmentRequest();
            c.Submitted = new DateTime(2017, 10, 01);

            Assert.IsNotNull(c.Submitted);
        }

        [Test]
        public void SubmittedNegative()
        {
            var c = new ApartmentRequest();

            Assert.IsNotNull(c.Submitted);
        }

        [Test]
        public void BedsPositive()
        {
            var c = new ApartmentRequest();
            c.Beds = 2;

            Assert.IsNotNull(c.Beds);
        }

        [Test]
        public void BedsNegative()
        {
            var c = new ApartmentRequest();

            Assert.IsNotNull(c.Beds);
        }

        [Test]
        public void ManagerPositive()
        {
            var c = new ApartmentRequest();
            c.Manager.FirstName = "John";
            c.Manager.LastName = "Smith";

            Assert.IsNotNull(c.Manager);
        }

        [Test]
        public void ManagerNegative()
        {
            var c = new ApartmentRequest();

            Assert.IsNull(c.Manager);
        }

        [Test]
        public void ProviderPositive()
        {
            var c = new ApartmentRequest();
            c.Provider.Name = "BridgeStreet";

            Assert.IsNotNull(c.Provider);
        }

        [Test]
        public void ProviderNegative()
        {
            var c = new ApartmentRequest();

            Assert.IsNull(c.Provider);
        }
    }
}
