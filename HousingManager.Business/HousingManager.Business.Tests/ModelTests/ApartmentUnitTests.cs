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
      //Assert.IsNotNull(au.UnitProvider); 
    }

    [Test]
    public void ApartmentUnitMethodTest()
    {
      Guid ID = Guid.NewGuid();

      var au = new ApartmentUnit();
      au.UnitNumber = 1;
      au.ComplexName = "Worldgate";
      au.Capacity = 2;
      au.Guid = ID;

      var au1 = new ApartmentUnit();
      au1.UnitNumber = 1;
      au1.ComplexName = "Worldgate";
      au1.Capacity = 2;
      au1.Guid = ID;

      var chash = au.GetHashCode();
      var c1hash = au1.GetHashCode();

      Assert.IsTrue(au.Equals(au1));
      Assert.IsTrue(chash == c1hash);
    }
  }
}
