using HousingManager.Business.Library.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HousingManager.Business.Tests.ModelTests
{
  [TestFixture]
  public class ApartmentUnitTests
  {
    [Test]
    public void ApartmentUnitModelTest()
    {
      var au = new ApartmentUnit();

      Assert.IsNotNull(au.GetType().GetProperty("UnitNumber"));
      Assert.IsNotNull(au.GetType().GetProperty("ComplexName"));
      Assert.IsNotNull(au.GetType().GetProperty("Capacity"));
      Assert.IsNotNull(au.UnitProvider); 
    }
  }
}
