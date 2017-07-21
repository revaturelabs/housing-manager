using HousingManager.Data.Service.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Data.Tests
{
  [TestFixture]
  public class ApartmentUnitTest
  {
    [Test]
    public void ApartmentUnitIsEqualPositive()
    {
      var c = new ApartmentUnit();
      c.Provider.Name = "Ryan";
      c.Provider.ProviderContactInfo.Email = "aballard513@yahoo.com";
      c.Provider.ProviderContactInfo.PhoneNumber = "xxx-xxx-xxxx";
      c.Address.AptNum = 123;
      c.Address.City = "Herndon";
      c.Address.State = "Virginia";
      c.Address.Street = "WordsWorth ct";
      c.Address.ZipCode = 12345;
      var c1 = new ApartmentUnit();
      c1.Provider.Name = "Ryan";
      c1.Provider.ProviderContactInfo.Email = "aballard513@yahoo.com";
      c1.Provider.ProviderContactInfo.PhoneNumber = "xxx-xxx-xxxx";
      c1.Address.AptNum = 123;
      c1.Address.City = "Herndon";
      c1.Address.State = "Virginia";
      c1.Address.Street = "WordsWorth ct";
      c1.Address.ZipCode = 12345;
      var chash = c.GetHashCode();
      var c1hash = c1.GetHashCode();

      Assert.IsTrue(c.Equals(c1) && chash == c1hash);
    }

    [Test]
    public void ApartmentUnitIsEqualNegative()
    {
      var c = new ApartmentUnit();
      c.Provider.Name = "Ryan";
      c.Provider.ProviderContactInfo.Email = "aballard513@yahoo.com";
      c.Provider.ProviderContactInfo.PhoneNumber = "xxx-xxx-xxxx";
      c.Address.AptNum = 123;
      c.Address.City = "Herndon";
      c.Address.State = "Virginia";
      c.Address.Street = "WordsWorth ct";
      c.Address.ZipCode = 12345;
      var c1 = new ApartmentUnit();
      c1.Provider.Name = "Ryan";
      c1.Provider.ProviderContactInfo.Email = "ballard513@yahoo.com";
      c1.Provider.ProviderContactInfo.PhoneNumber = "xxx-xxx-xxxx";
      c1.Address.AptNum = 123;
      c1.Address.City = "Herndon";
      c1.Address.State = "Virginia";
      c1.Address.Street = "WordsWorth ct";
      c1.Address.ZipCode = 12345;
      var chash = c.GetHashCode();
      var c1hash = c1.GetHashCode();

      Assert.IsFalse(c.Equals(c1) && chash == c1hash);
    }

    [Test]
    public void ProviderContactInfoNamePositive()
    {
      var n = new ApartmentUnit();
      n.Provider.Name = "Ryan";
      var name = n.GetProviderName();

      Assert.IsNotNull(name);
    }

    [Test]
    public void ProviderContactInfoNameNegative()
    {
      var n = new ApartmentUnit();
      var name = n.GetProviderName();

      Assert.IsNull(name);
    }

    [Test]
    public void ProviderContactInfoGetEmailPositive()
    {
      var c = new ApartmentUnit();
      c.Provider.ProviderContactInfo.Email = "aballard513@yahoo.com";
      c.Provider.ProviderContactInfo.PhoneNumber = "xxx-xxx-xxxx";
      var PContactInfo = c.GetProviderContactInfoEmail();

      Assert.IsNotNull(PContactInfo);
    }

    [Test]
    public void ProviderContactInfoGetEmailNegative()
    {
      var c = new ApartmentUnit();
      c.Provider.ProviderContactInfo.PhoneNumber = "xxx-xxx-xxxx";
      var PContactInfo = c.GetProviderContactInfoPhone();

      Assert.IsNotNull(PContactInfo);
    }

    [Test]
    public void ProviderContactInfoGetPhoneNumberPositive()
    {
      var c = new ApartmentUnit();
      c.Provider.ProviderContactInfo.Email = "aballard513@yahoo.com";
      c.Provider.ProviderContactInfo.PhoneNumber = "xxx-xxx-xxxx";
      var PContactInfo = c.GetProviderContactInfoPhone();

      Assert.IsNotNull(PContactInfo);
    }

    [Test]
    public void ProviderContactInfoGetPhoneNumberNegative()
    {
      var c = new ApartmentUnit();
      c.Provider.ProviderContactInfo.Email = "aballard513@yahoo.com";
      var PContactInfo = c.GetProviderContactInfoEmail();

      Assert.IsNotNull(PContactInfo);
    }

    [Test]
    public void ApartmentUnitAddressAptNumPositive()
    {
      var c = new ApartmentUnit();
      c.Address.AptNum = 123;
      c.Address.City = "Herndon";
      c.Address.State = "Virginia";
      c.Address.Street = "WordsWorth ct";
      c.Address.ZipCode = 12345;
      var PAddress = c.GetAddressAptNum();

      Assert.IsNotNull(PAddress);
    }

    [Test]
    public void ApartmentUnitAddressAptNumNegative()
    {
      var c = new ApartmentUnit();
      c.Address.City = "Herndon";
      c.Address.State = "Virginia";
      c.Address.Street = "WordsWorth ct";
      c.Address.ZipCode = 12345;
      var PAddress = c.GetAddressAptNum();

      Assert.NotNull(PAddress);
    }

    [Test]
    public void ApartmentUnitAddressCityPositive()
    {
      var c = new ApartmentUnit();
      c.Address.AptNum = 123;
      c.Address.City = "Herndon";
      c.Address.State = "Virginia";
      c.Address.Street = "WordsWorth ct";
      c.Address.ZipCode = 12345;
      var PAddress = c.GetAddressCity();

      Assert.IsNotNull(PAddress);
    }

    [Test]
    public void ApartmentUnitAddressCityNegative()
    {
      var c = new ApartmentUnit();
      c.Address.State = "Virginia";
      c.Address.Street = "WordsWorth ct";
      c.Address.ZipCode = 12345;
      var PAddress = c.GetAddressCity();

      Assert.IsNull(PAddress);
    }

    [Test]
    public void ApartmentUnitAddressStatePositive()
    {
      var c = new ApartmentUnit();
      c.Address.AptNum = 123;
      c.Address.City = "Herndon";
      c.Address.State = "Virginia";
      c.Address.Street = "WordsWorth ct";
      c.Address.ZipCode = 12345;
      var PAddress = c.GetAddressState();

      Assert.IsNotNull(PAddress);
    }

    [Test]
    public void ApartmentUnitAddressStateNegative()
    {
      var c = new ApartmentUnit();
      c.Address.City = "Herndon";
      c.Address.Street = "WordsWorth ct";
      c.Address.ZipCode = 12345;
      var PAddress = c.GetAddressState();

      Assert.IsNull(PAddress);
    }

    [Test]
    public void ApartmentUnitAddressStreetPositive()
    {
      var c = new ApartmentUnit();
      c.Address.AptNum = 123;
      c.Address.City = "Herndon";
      c.Address.State = "Virginia";
      c.Address.Street = "WordsWorth ct";
      c.Address.ZipCode = 12345;
      var PAddress = c.GetAddressStreet();

      Assert.IsNotNull(PAddress);
    }

    [Test]
    public void ApartmentUnitAddressStreetNegative()
    {
      var c = new ApartmentUnit();
      c.Address.City = "Herndon";
      c.Address.State = "Virginia";
      c.Address.ZipCode = 12345;
      var PAddress = c.GetAddressStreet();

      Assert.IsNull(PAddress);
    }

    [Test]
    public void ApartmentUnitAddressZipCodePositive()
    {
      var c = new ApartmentUnit();
      c.Address.AptNum = 123;
      c.Address.City = "Herndon";
      c.Address.State = "Virginia";
      c.Address.Street = "WordsWorth ct";
      c.Address.ZipCode = 12345;
      var PAddress = c.GetAddressZipCode();

      Assert.IsNotNull(PAddress);
    }

    [Test]
    public void ApartmentUnitAddressZipCodeNegative()
    {
      var c = new ApartmentUnit();
      c.Address.City = "Herndon";
      c.Address.State = "Virginia";
      c.Address.Street = "WordsWorth ct";
      var PAddress = c.GetAddressZipCode();

      Assert.IsNotNull(PAddress);
    }

    [Test]
    public void ApartmentUnitCapacityPositive()
    {
      var c = new ApartmentUnit();
      c.Capacity = 100;
      var PCapacity = c.GetCapacity();

      Assert.IsNotNull(PCapacity);
    }

    [Test]
    public void ApartmentUnitCapacityNegative()
    {
      var c = new ApartmentUnit();
      var PCapacity = c.GetCapacity();

      Assert.IsNotNull(PCapacity);
    }
  }
}
