using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using HousingManager.Business.Library;
using HousingManager.Business.Library.Models;

namespace HousingManager.Business.Tests
{
    [TestFixture]
    public class AddressTest
    {
        //[Test]
        //public void TestAddressModelSuccess()
        //{
        //    //var a = new Broker();
        //    var address = a.AddAddress();
        //    Assert.IsNotNull(address);   
        //}

        //[Test]
        //public void TestAddressModelFail()
        //{
        //   // var a = new Broker();
        //    var address = a.AddAddress2();
        //    Assert.IsNull(address);
        //}

    [Test]
    public void ContactInfoIsEqualPositive()
    {
      var c = new Address();
      c.AptNum = "112";
      c.StreetName = "222 somewhere else";
      c.City = "Houston";
      c.State = "Texas";
      c.ZipCode = "11111";

      var c1 = new Address();
      c1.AptNum = "112";
      c1.StreetName = "222 somewhere else";
      c1.City = "Houston";
      c1.State = "Texas";
      c1.ZipCode = "11111";

      var chash = c.GetHashCode();
      var c1hash = c1.GetHashCode();

      Assert.IsTrue(c.Equals(c1) && chash == c1hash);
    }

    [Test]
    public void ContactInfoIsEqualNegative()
    {
      var c = new Address();
      c.AptNum = "112";
      c.StreetName = "222 somewhere else";
      c.City = "Houston";
      c.State = "Texas";
      c.ZipCode = "11111";

      var c1 = new Address();
      c1.AptNum = "112";
      c1.StreetName = "222 somewhere else";
      c1.City = "Kingsville";
      c1.State = "Texas";
      c1.ZipCode = "11111";

      var chash = c.GetHashCode();
      var c1hash = c1.GetHashCode();

      Assert.IsFalse(c.Equals(c1) && chash == c1hash);
    } 
  }
}