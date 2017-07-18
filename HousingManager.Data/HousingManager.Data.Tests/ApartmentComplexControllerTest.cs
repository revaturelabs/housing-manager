using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using HousingManager.Data.Service.Controllers;

namespace HousingManager.Data.Tests
{
  [TestFixture]
  public class ApartmentComplexControllerTest
  {
    [Test]
    public void GetApartmentControllerTest()
    {
      var aptcpxctrl = new ApartmentComplexController();

      var expect = aptcpxctrl.Get();

      var count = expect[0].ApartmentUnit.Count;

      Assert.IsNotNull(expect[0].ApartmentName);
      Assert.IsTrue(count > 0);
    }

  }
}
