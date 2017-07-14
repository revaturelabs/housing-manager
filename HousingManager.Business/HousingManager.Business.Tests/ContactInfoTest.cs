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
        
    }
}
