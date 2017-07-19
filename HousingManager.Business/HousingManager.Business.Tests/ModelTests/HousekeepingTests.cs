using HousingManager.Business.Library.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HousingManager.Business.Tests.ModelTests
{
  [TestFixture]
  public class HousekeepingTests
  {
    [Test]
    public void HousekeepingModelTest()
    {
      var h = new Housekeeping();

      Assert.IsNotNull(h.CurrentDate);
      Assert.IsNotNull(h.NextDate);
    }
  }
}
