using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using HousingManager.Business.Library.Models;

namespace HousingManager.Business.Tests
{
    [TestFixture]
    public class ContactInfoTest
    {
        [Test]
        public void ContactInfoIsEqualPositive()
        {
            var c = new ContactInfo();
            c.EmailAddress = "aballard513@yahoo.com";
            c.PhoneNumber = "xxx-xxx-xxxx";
            var c1 = new ContactInfo();
            c1.EmailAddress = "aballard513@yahoo.com";
            c1.PhoneNumber = "xxx-xxx-xxxx";
            var chash = c.GetHashCode();
            var c1hash = c1.GetHashCode(); 
      
            Assert.IsTrue(c.Equals(c1)&&chash==c1hash);
        }

        [Test]
        public void ContactInfoIsEqualNegative()
        {
            var c = new ContactInfo();
            c.EmailAddress = "aballard513@yahoo.com";
            c.PhoneNumber = "xxx-xxx-xxx";
            var c1 = new ContactInfo();
            c1.EmailAddress = "aballard513@yahoo.com";
            c1.PhoneNumber = "xxx-xxx-xxxx";
            var chash = c.GetHashCode();
            var c1hash = c1.GetHashCode();

            Assert.IsFalse(c.Equals(c1) && chash == c1hash);
        }

        [Test]
        public void ContactInfoGetEmailPositive()
        {
          var c = new ContactInfo();
          c.EmailAddress = "aballard513@yahoo.com";
          c.PhoneNumber = "xxx-xxx-xxxx";
          var email = c.GetEmail();

          Assert.IsNotNull(email);
        }

        [Test]
        public void ContactInfoGetEmailNegative()
        {
          var c = new ContactInfo();
          c.PhoneNumber = "xxx-xxx-xxxx";
          var email = c.GetEmail();
          Assert.IsNull(email);
        }

        [Test]
        public void ContactInfoGetPhoneNumberPositive()
        {
           var c = new ContactInfo();
           c.EmailAddress = "aballard513@yahoo.com";
           c.PhoneNumber = "xxx-xxx-xxxx";
           var phone = c.GetPhoneNumber();
           Assert.IsNotNull(phone);
        }

        [Test]
        public void ContactInfoGetPhoneNumberNegative()
        {
            var c = new ContactInfo();
            c.EmailAddress = "aballard513@yahoo.com";
            var phone = c.GetPhoneNumber();
            Assert.IsNull(phone);
        }
    }
}
