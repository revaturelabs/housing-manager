using HousingManager.Data.Library.Models;
using HousingManager.Data.Service.Controllers;
using HousingManager.Data.Service.DTOs;
using HousingManager.Data.Service.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HousingManager.Data.Tests
{
  [TestFixture]
  public class ApartmentUnitTest
  {
    [Test]
    public void Get_Returns_Something()
    {
      var options = new DbContextOptionsBuilder<HousingManagerDBContext>()
                .UseInMemoryDatabase(databaseName: "Get_gets_from_database")
                .Options;

      using (var context = new HousingManagerDBContext(options))
      {
        var service = new PersonController(context);
        var people = service.Get();

        Assert.That(people, Is.Not.Null);
      }

    }

    [Test]
    public void Post_Adds_Something()
    {
      var options = new DbContextOptionsBuilder<HousingManagerDBContext>()
                .UseInMemoryDatabase(databaseName: "Add_writes_to_database")
                .Options;

      var per = new Library.Models.Person { FirstName = "Sally", LastName = "Shally" };
      
      using (var context = new HousingManagerDBContext(options))
      {
        var service = new PersonController(context);
        service.Post(per);
      }
      
      using (var context = new HousingManagerDBContext(options))
      {
        Assert.AreEqual(1, context.Person.Count());
      }
    }
  }
}
