using HousingManager.Data.Service.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Data.Tests
{
  [TestFixture]
  public class ProviderTest
  {
    [Test]
    public void ProviderContactInfoIsEqualPositive()
    {
      var c = new Provider();
      c.Name = "Ryan";
      c.ProviderContactInfo.Email = "aballard513@yahoo.com";
      c.ProviderContactInfo.PhoneNumber = "xxx-xxx-xxxx";
      var c1 = new Provider();
      c1.Name = "Ryan";
      c1.ProviderContactInfo.Email = "aballard513@yahoo.com";
      c1.ProviderContactInfo.PhoneNumber = "xxx-xxx-xxxx";
      var chash = c.GetHashCode();
      var c1hash = c1.GetHashCode();

      Assert.IsTrue(c.Equals(c1) && chash == c1hash);
    }

    [Test]
    public void ProviderContactInfoIsEqualNegative()
    {
      var c = new Provider();
      c.Name = "Ryan";
      c.ProviderContactInfo.Email = "aballard513@yahoo.com";
      c.ProviderContactInfo.PhoneNumber = "xxx-xxx-xxxx";
      var c1 = new Provider();
      c1.Name = "Ryan";
      c1.ProviderContactInfo.Email = "ballard513@yahoo.com";
      c1.ProviderContactInfo.PhoneNumber = "xxx-xxx-xxxx";
      var chash = c.GetHashCode();
      var c1hash = c1.GetHashCode();

      Assert.IsFalse(c.Equals(c1) && chash == c1hash);
    }

    [Test]
    public void ProviderContactInfoNamePositive()
    {
      var n = new Provider();
      n.Name = "Ryan";
      var name = n.GetName();

      Assert.IsNotNull(name);
    }

    [Test]
    public void ProviderContactInfoNameNegative()
    {
      var n = new Provider();
      var name = n.GetName();

      Assert.IsNull(name);
    }

    [Test]
    public void ProviderContactInfoGetEmailPositive()
    {
      var c = new Provider();
      c.ProviderContactInfo.Email = "aballard513@yahoo.com";
      c.ProviderContactInfo.PhoneNumber = "xxx-xxx-xxxx";
      var PContactInfo = c.GetProviderContactInfoEmail();

      Assert.IsNotNull(PContactInfo);
    }

    [Test]
    public void ProviderContactInfoGetEmailNegative()
    {
      var c = new Provider();
      c.ProviderContactInfo.PhoneNumber = "xxx-xxx-xxxx";
      var PContactInfo = c.GetProviderContactInfoPhone();

      Assert.IsNotNull(PContactInfo);
    }

    [Test]
    public void ProviderContactInfoGetPhoneNumberPositive()
    {
      var c = new Provider();
      c.ProviderContactInfo.Email = "aballard513@yahoo.com";
      c.ProviderContactInfo.PhoneNumber = "xxx-xxx-xxxx";
      var PContactInfo = c.GetProviderContactInfoPhone();

      Assert.IsNotNull(PContactInfo);
    }

    [Test]
    public void ProviderContactInfoGetPhoneNumberNegative()
    {
      var c = new Provider();
      c.ProviderContactInfo.Email = "aballard513@yahoo.com";
      var PContactInfo = c.GetProviderContactInfoEmail();

      Assert.IsNotNull(PContactInfo);
    }
  }
}
