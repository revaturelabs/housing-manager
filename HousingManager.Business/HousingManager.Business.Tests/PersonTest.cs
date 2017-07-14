using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using HousingManager.Business.Library.Models;

namespace HousingManager.Business.Tests
{
    [TestFixture]
    public class PersonTest
    {
        [Test]
        public void PersonModelPositive()
        {
          var p = new Person();
          p.FirstName = "Andre";
          p.LastName = "Ballard";
          p.PersonAddress.AptNumber = "12";
          p.PersonAddress.StreetName = "1212 Random Street Dr";
          p.PersonAddress.City = "Houston";
          p.PersonAddress.State = "Texas";
          p.PersonAddress.ZipCode = "77777";
          p.ContactInformation.EmailAddress = "email@email.com";
          p.ContactInformation.PhoneNumber = "5555555555";
          p.Gender = 'm';

          Assert.IsNotNull(p);
        }

        [Test]
        public void PersonModelNegative()
        {
          var p = new Person();
          p = null;
          Assert.IsNull(p);
        }
  }
}
