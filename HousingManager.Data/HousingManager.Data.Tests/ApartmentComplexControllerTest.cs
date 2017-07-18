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

      Assert.IsNotNull(expect[0].ApartmentName);
    }

  }
}
