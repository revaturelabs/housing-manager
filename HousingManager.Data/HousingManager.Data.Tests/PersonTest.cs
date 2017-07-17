using HousingManager.Data.Service.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Data.Tests
{
    [TestFixture]
    public class PersonTest
    {
        [Test]
        public void PersonPositive()
        {
            var c = new Person();
            c.FirstName = "John";
            c.LastName = "Smith";
            c.PersonContactInfo.Email = "JSmith123@gmail.com";
            c.PersonContactInfo.PhoneNumber = "123456789";
            var c1 = new Person();
            c1.FirstName = "John";
            c1.LastName = "Smith";
            c1.PersonContactInfo.Email = "JSmith123@gmail.com";
            c1.PersonContactInfo.PhoneNumber = "123456789";

            Assert.IsTrue(c.Equals(c1));
        }

        [Test]
        public void PersonNegative()
        {
            var c = new Person();
            c.FirstName = "John";
            c.LastName = "Smith";
            c.PersonContactInfo.Email = "Smith123@gmail.com";
            c.PersonContactInfo.PhoneNumber = "123456789";
            var c1 = new Person();
            c1.FirstName = "John";
            c1.LastName = "Smith";
            c1.PersonContactInfo.Email = "JSmith123@gmail.com";
            c1.PersonContactInfo.PhoneNumber = "123456789";

            Assert.IsFalse(c.Equals(c1));
        }

        [Test]
        public void FirstNamePositive()
        {
            var c = new Person();
            c.FirstName = "John";

            Assert.IsNotNull(c.FirstName);
        }

        [Test]
        public void FirstNameNegative()
        {
            var c = new Person();

            Assert.IsNull(c.FirstName);
        }

        [Test]
        public void LastNamePositive()
        {
            var c = new Person();
            c.LastName = "Smith";

            Assert.IsNotNull(c.LastName);
        }

        [Test]
        public void LastNameNegative()
        {
            var c = new Person();

            Assert.IsNull(c.LastName);
        }

        [Test]
        public void ActivePositive()
        {
            var c = new Person();
            c.Active = true;

            Assert.IsTrue(c.Active);
        }

        [Test]
        public void ActiveNegative()
        {
            var c = new Person();
            c.Active = false;

            Assert.IsFalse(c.Active);
        }

        [Test]
        public void PersonContactInfoPositive()
        {
            var c = new Person();
            c.PersonContactInfo.Email = "JSmith@gmail.com";
            c.PersonContactInfo.PhoneNumber = "12345678";

            Assert.IsNotNull(c.PersonContactInfo);
        }

        [Test]
        public void PersonContactInfoNegative()
        {
            var c = new Person();

            Assert.IsNull(c.PersonContactInfo);
        }
    }
}
