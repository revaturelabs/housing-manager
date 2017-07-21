using HousingManager.Data.Service.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Data.Tests
{
  [TestFixture]
  class ProviderSupplyRequestTest
  {
    [Test]
    public void ProviderSupplyRequestIsEqualPositive()
    {
      var c = new ProviderSupplyRequest();
      c.Submitted = DateTime.Now;
      c.Manager.FirstName = "John";
      c.Manager.LastName = "Smith";
      c.Provider.Name = "Ryan";
      c.Provider.ProviderContactInfo.Email = "aballard513@yahoo.com";
      c.Provider.ProviderContactInfo.PhoneNumber = "xxx-xxx-xxxx";
      var c1 = new ProviderSupplyRequest();
      c1.Submitted = DateTime.Now;
      c1.Manager.FirstName = "John";
      c1.Manager.LastName = "Smith";
      c1.Provider.Name = "Ryan";
      c1.Provider.ProviderContactInfo.Email = "aballard513@yahoo.com";
      c1.Provider.ProviderContactInfo.PhoneNumber = "xxx-xxx-xxxx";
      var chash = c.GetHashCode();
      var c1hash = c1.GetHashCode();

      Assert.IsTrue(c.Equals(c1) && chash == c1hash);
    }

    [Test]
    public void ProviderSupplyRequestIsEqualNegative()
    {
      var c = new ProviderSupplyRequest();
      c.Submitted = new DateTime(2017, 10, 01);
      c.Manager.FirstName = "John";
      c.Manager.LastName = "Smith";
      c.Provider.Name = "Ryan";
      c.Provider.ProviderContactInfo.Email = "aballard513@yahoo.com";
      c.Provider.ProviderContactInfo.PhoneNumber = "xxx-xxx-xxxx";
      c.Supply.Type = "Toilet Paper";
      var c1 = new ProviderSupplyRequest();
      c1.Submitted = new DateTime(2017, 10, 01);
      c1.Manager.FirstName = "John";
      c1.Manager.LastName = "Smith";
      c1.Provider.Name = "Ryan";
      c1.Provider.ProviderContactInfo.Email = "ballard513@yahoo.com";
      c1.Provider.ProviderContactInfo.PhoneNumber = "xxx-xxx-xxxx";
      c1.Supply.Type = "Toilet Paper";
      var chash = c.GetHashCode();
      var c1hash = c1.GetHashCode();

      Assert.IsFalse(c.Equals(c1) && chash == c1hash);
    }

    [Test]
    public void DateSubmittedPositive()
    {
      var c = new ProviderSupplyRequest();
      c.Submitted = new DateTime(2017, 10, 01);
      var Submitted = c.GetDateSubmitted();

      Assert.IsNotNull(Submitted);
    }

    [Test]
    public void DateSubmittedNegative()
    {
      var c = new ProviderSupplyRequest();
      var Submitted = c.GetDateSubmitted();

      Assert.IsNotNull(Submitted);
    }

    [Test]
    public void ManagerPositive()
    {
      var c = new ProviderSupplyRequest();
      c.Manager.FirstName = "John";
      c.Manager.LastName = "Smith";
      var Manager = c.GetManager();

      Assert.IsNotNull(Manager);
    }

    [Test]
    public void ManagerNegative()
    {
      var c = new ProviderSupplyRequest();
      var Manager = c.GetManager();

      Assert.IsNotNull(Manager);
    }

    [Test]
    public void ProviderPositive()
    {
      var c = new ProviderSupplyRequest();
      c.Provider.Name = "BridgeStreet";
      var Provider = c.GetProvider();

      Assert.IsNotNull(Provider);
    }

    [Test]
    public void ProvderNegative()
    {
      var c = new ProviderSupplyRequest();
      var Provider = c.GetProvider();

      Assert.IsNotNull(Provider);
    }

    [Test]
    public void SupplyPositive()
    {
      var c = new ProviderSupplyRequest();
      c.Supply.Type = "Toilet Paper";
      var Supply = c.GetSupply();

      Assert.IsNotNull(Supply);
    }

    [Test]
    public void SupplyNegative()
    {
      var c = new ProviderSupplyRequest();
      var Supply = c.GetSupply();

      Assert.IsNotNull(Supply);
    }
  }
}
