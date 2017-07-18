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
  }
}
