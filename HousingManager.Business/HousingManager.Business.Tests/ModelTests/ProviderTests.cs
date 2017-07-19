using HousingManager.Business.Library.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HousingManager.Business.Tests.ModelTests
{
  [TestFixture]
  public class ProviderTests
  {
    [Test]
    public void ProviderModelTest()
    {
      var p = new Provider();

      Assert.IsNotNull(p.GetType().GetProperty("Issue"));
      Assert.IsNotNull(p.GetType().GetProperty("Email"));
      Assert.IsNotNull(p.GetType().GetProperty("PhoneNumber"));
      Assert.IsNotNull(p.Unit);
    }
  }
}
