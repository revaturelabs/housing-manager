using HousingManager.Data.Service.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Data.Tests
{
  [TestFixture]
  public class HouseKeepingTest
  {
    [Test]
    public void HouseKeppingIsPositive()
    {
      var c = new HouseKeeping();
      c.ApartmentUnit = new ApartmentUnit();
      c.LastCleaning = new DateTime(2017, 10, 01);
      c.NextCleaning = new DateTime(2017, 01, 10);
      var c1 = new HouseKeeping();
      c1.ApartmentUnit = new ApartmentUnit();
      c1.LastCleaning = new DateTime(2017, 10, 01);
      c1.NextCleaning = new DateTime(2017, 01, 10);
      var chash = c.GetHashCode();
      var c1hash = c1.GetHashCode();

      Assert.IsTrue(c.Equals(c1) && chash == c1hash);
    }

    [Test]
    public void HouseKeepingIsNegative()
    {
      var c = new HouseKeeping();
      c.ApartmentUnit = new ApartmentUnit();
      c.LastCleaning = new DateTime(2017, 10, 01);
      c.NextCleaning = new DateTime(2017, 01, 10);
      var c1 = new HouseKeeping();
      c1.ApartmentUnit = new ApartmentUnit();
      c1.LastCleaning = new DateTime(2017, 10, 01);
      c1.NextCleaning = new DateTime(2017, 10, 10);
      var chash = c.GetHashCode();
      var c1hash = c1.GetHashCode();

      Assert.IsFalse(c.Equals(c1) && chash == c1hash);
    }

    [Test]
    public void ApartmentUnitPositive()
    {
      var n = new HouseKeeping();
      n.ApartmentUnit = new ApartmentUnit();
      var ApartmentUnit = n.GetApartmentUnit();

      Assert.IsNotNull(ApartmentUnit);
    }

    [Test]
    public void ApartmentUnitNegative()
    {
      var n = new HouseKeeping();
      var ApartmentUnit = n.GetApartmentUnit();

      Assert.IsNotNull(ApartmentUnit);
    }

    [Test]
    public void LastCleaningPositive()
    {
      var n = new HouseKeeping();
      n.LastCleaning = new DateTime(2017, 10, 01);
      var LastCleaning = n.GetLastCleaning();

      Assert.IsNotNull(LastCleaning);
    }

    [Test]
    public void LastCleaningNegative()
    {
      var n = new HouseKeeping();
      var LastCleaning = n.GetLastCleaning();

      Assert.IsNotNull(LastCleaning);
    }

    [Test]
    public void NextCleaningPositive()
    {
      var n = new HouseKeeping();
      n.LastCleaning = new DateTime(2017, 10, 01);
      var NextCleaning = n.GetNextCleaning();

      Assert.IsNotNull(NextCleaning);
    }

    [Test]
    public void NextCleaningNegative()
    {
      var n = new HouseKeeping();
      var NextCleaning = n.GetNextCleaning();

      Assert.IsNotNull(NextCleaning);
    }
  }
}
