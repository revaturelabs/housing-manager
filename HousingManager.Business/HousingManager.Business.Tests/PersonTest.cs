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
          p.PersonAddress.AptNum = "12";
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

        [Test]
        public void PersonModelContactInfoComparePositive()
        {
          var p = new Person();
          p.FirstName = "Andre";
          p.LastName = "Ballard";
          p.PersonAddress.AptNum = "12";
          p.PersonAddress.StreetName = "1212 Random Street Dr";
          p.PersonAddress.City = "Houston";
          p.PersonAddress.State = "Texas";
          p.PersonAddress.ZipCode = "77777";
          p.ContactInformation.EmailAddress = "email@email.com";
          p.ContactInformation.PhoneNumber = "5555555555";
          p.Gender = 'm';

      var p1 = new Person();
      p1.FirstName = "Andre";
      p1.LastName = "Ballard";
      p1.PersonAddress.AptNum = "12";
      p1.PersonAddress.StreetName = "1212 Random Street Dr";
      p1.PersonAddress.City = "Houston";
      p1.PersonAddress.State = "Texas";
      p1.PersonAddress.ZipCode = "77777";
      p1.ContactInformation.EmailAddress = "email@email.com";
      p1.ContactInformation.PhoneNumber = "5555555555";
      p1.Gender = 'm';

      Assert.IsTrue(p.Compare(p1.ContactInformation));
        }

    [Test]
    public void PersonModelContactInfoCompareNegatve()
    {
      var p = new Person();
      p.FirstName = "Andre";
      p.LastName = "Ballard";
      p.PersonAddress.AptNum = "12";
      p.PersonAddress.StreetName = "1212 Random Street Dr";
      p.PersonAddress.City = "Houston";
      p.PersonAddress.State = "Texas";
      p.PersonAddress.ZipCode = "77777";
      p.ContactInformation.EmailAddress = "email@email.com";
      p.ContactInformation.PhoneNumber = "5555555555";
      p.Gender = 'm';

      var p1 = new Person();
      p1.FirstName = "Andre";
      p1.LastName = "Ballard";
      p1.PersonAddress.AptNum = "12";
      p1.PersonAddress.StreetName = "1212 Random Street Dr";
      p1.PersonAddress.City = "Houston";
      p1.PersonAddress.State = "Texas";
      p1.PersonAddress.ZipCode = "77777";
      p1.ContactInformation.EmailAddress = "email@email.co2";
      p1.ContactInformation.PhoneNumber = "555555555";
      p1.Gender = 'm';

      Assert.IsFalse(p.Compare(p1.ContactInformation));
    }

    [Test]
    public void PersonModelGetPhoneNumberPositive()
    {
      var p = new Person();
      p.FirstName = "Andre";
      p.LastName = "Ballard";
      p.PersonAddress.AptNum = "12";
      p.PersonAddress.StreetName = "1212 Random Street Dr";
      p.PersonAddress.City = "Houston";
      p.PersonAddress.State = "Texas";
      p.PersonAddress.ZipCode = "77777";
      p.ContactInformation.EmailAddress = "email@email.com";
      p.ContactInformation.PhoneNumber = "5555555555";
      p.Gender = 'm';

      Assert.IsNotNull(p.GetPhoneNumber());
    }

    [Test]
    public void PersonModelGetPhoneNumberNegative()
    {
      var p = new Person();
      p.FirstName = "Andre";
      p.LastName = "Ballard";
      p.PersonAddress.AptNum = "12";
      p.PersonAddress.StreetName = "1212 Random Street Dr";
      p.PersonAddress.City = "Houston";
      p.PersonAddress.State = "Texas";
      p.PersonAddress.ZipCode = "77777";
      p.ContactInformation.EmailAddress = "email@email.com";
      p.Gender = 'm';

      Assert.IsNull(p.GetPhoneNumber());
    }

    [Test]
    public void PersonModelGetEmailPositive()
    {
      var p = new Person();
      p.FirstName = "Andre";
      p.LastName = "Ballard";
      p.PersonAddress.AptNum = "12";
      p.PersonAddress.StreetName = "1212 Random Street Dr";
      p.PersonAddress.City = "Houston";
      p.PersonAddress.State = "Texas";
      p.PersonAddress.ZipCode = "77777";
      p.ContactInformation.EmailAddress = "email@email.com";
      p.ContactInformation.PhoneNumber = "5555555555";
      p.Gender = 'm';

      Assert.IsNotNull(p.GetEmail());
    }

    [Test]
    public void PersonModelGetEmailNegative()
    {
      var p = new Person();
      p.FirstName = "Andre";
      p.LastName = "Ballard";
      p.PersonAddress.AptNum = "12";
      p.PersonAddress.StreetName = "1212 Random Street Dr";
      p.PersonAddress.City = "Houston";
      p.PersonAddress.State = "Texas";
      p.PersonAddress.ZipCode = "77777";
      p.ContactInformation.PhoneNumber = "5555555555";

      p.Gender = 'm';

      Assert.IsNull(p.GetEmail());
    }

    [Test]
    public void PersonModelAddressComparePositive()
    {
      var p = new Person();
      p.FirstName = "Andre";
      p.LastName = "Ballard";
      p.PersonAddress.AptNum = "12";
      p.PersonAddress.StreetName = "1212 Random Street Dr";
      p.PersonAddress.City = "Houston";
      p.PersonAddress.State = "Texas";
      p.PersonAddress.ZipCode = "77777";
      p.ContactInformation.EmailAddress = "email@email.com";
      p.ContactInformation.PhoneNumber = "5555555555";
      p.Gender = 'm';

      var p1 = new Person();
      p1.FirstName = "Andre";
      p1.LastName = "Ballard";
      p1.PersonAddress.AptNum = "12";
      p1.PersonAddress.StreetName = "1212 Random Street Dr";
      p1.PersonAddress.City = "Houston";
      p1.PersonAddress.State = "Texas";
      p1.PersonAddress.ZipCode = "77777";
      p1.ContactInformation.EmailAddress = "email@email.com";
      p1.ContactInformation.PhoneNumber = "5555555555";
      p1.Gender = 'm';

      Assert.IsTrue(p.Compare(p1.ContactInformation));
    }

    [Test]
    public void PersonModelAddressCompareNegatve()
    {
      var p = new Person();
      p.FirstName = "Andre";
      p.LastName = "Ballard";
      p.PersonAddress.AptNum = "12";
      p.PersonAddress.StreetName = "1212 Random Street Dr";
      p.PersonAddress.City = "Houston";
      p.PersonAddress.State = "Texas";
      p.PersonAddress.ZipCode = "77777";
      p.ContactInformation.EmailAddress = "email@email.com";
      p.ContactInformation.PhoneNumber = "5555555555";
      p.Gender = 'm';

      var p1 = new Person();
      p1.FirstName = "Andre";
      p1.LastName = "Ballard";
      p1.PersonAddress.AptNum = "1";
      p1.PersonAddress.StreetName = "1212 Random Street Dr";
      p1.PersonAddress.City = "Houston";
      p1.PersonAddress.State = "Texas";
      p1.PersonAddress.ZipCode = "77777";
      p1.ContactInformation.EmailAddress = "email@email.co2";
      p1.ContactInformation.PhoneNumber = "555555555";
      p1.Gender = 'm';

      Assert.IsFalse(p.Compare(p1.ContactInformation));
    }
  }
}
