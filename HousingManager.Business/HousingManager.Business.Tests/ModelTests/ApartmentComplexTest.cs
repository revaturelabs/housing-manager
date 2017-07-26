using HousingManager.Business.Library;
using HousingManager.Business.Library.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Tests
{
  [TestFixture]
  public class ApartmentComplexTest
  {
    [Test]
    public void TestApartmentComplexModel()
    {
      var ac = new ApartmentComplex();

      Assert.IsNotNull(ac.ApartmentName);
      Assert.IsNotNull(ac.ApartmentAddress);
      Assert.IsNotNull(ac.AptUnitDTO);
    }

    [Test]
    public void TestApartmentComplexEqualsMethod()
    {
      Guid ID = Guid.NewGuid();

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

      var ac = new ApartmentComplex();
      ac.ApartmentName = "Worldgate Apartments";
      ac.Guid = ID;
      ac.ApartmentAddress = c;

      var acx = new ApartmentComplex();
      acx.ApartmentName = "Worldgate Apartments";
      acx.Guid = ID;
      acx.ApartmentAddress = c1;

      var chash = ac.GetHashCode();
      var c1hash = acx.GetHashCode();

      Assert.IsTrue(ac.Equals(acx));
      Assert.IsTrue(chash == c1hash);
    }
  }
}
