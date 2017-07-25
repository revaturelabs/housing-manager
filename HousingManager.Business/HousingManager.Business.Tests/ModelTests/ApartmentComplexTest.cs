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
      Assert.IsNotNull(ac.ApartmentUnit);
    }

    //[Test]
    //public void TestApartmentComplexGetAll()
    //{
    //  //var a = new ApartmentComplexBroker();

    //  List<ApartmentComplex> ac = new List<ApartmentComplex>();

    //  ApartmentComplex apt = new ApartmentComplex();

    //  apt.ApartmentName = "Test Dummy";

    //  ac.Add(apt);

    //  //var aptcomp = a.GetAll(ac);

    //  Assert.IsTrue(aptcomp[0].ApartmentName == "Test Dummy");
    //}
  }
}
