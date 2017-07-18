using HousingManager.Business.Library.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Tests.ModelTests
{
  [TestFixture]
  public class MaintenanceTest
  {
    [Test]
    public void MaintenanceModelTest()
    {
      var m = new Maintenance();

      m.Issue = "This is a test";

      ApartmentUnit au = new ApartmentUnit(); 

      Assert.IsNotNull(m.Issue);
      Assert.IsNotNull(m.ApartmentUnitNumber);
      Assert.IsNotNull(m.SubmissionDate);
    }
  }
}
