using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using HousingManager.Business.Library.Models;

namespace HousingManager.Business.Tests
{
    [TestFixture]
    public class BatchTest
    {
      [Test]
      public void BatchTestPositive()
      {
      var p = new Person();
      p.FirstName = "Andre";
      p.LastName = "Ballard";
      p.Gender = 'm';
      var p1 = new Person();
      p.FirstName = "Andre";
      p.LastName = "Ballard2";
      Batch b = new Batch();
        b.BatchName = "dotnet";
      b.StartDate = DateTime.Now;
      b.EndDate = DateTime.Now;
      b.size = 15;
      b.People.Add(p);
      b.People.Add(p1);

      Assert.IsNotNull(b);
      }

    [Test]
    public void FindPersonPositive()
    {
      var p = new Person();
      p.FirstName = "Andre";
      p.LastName = "Ballard";
      p.Gender = 'm';
      var p1 = new Person();
      p1.FirstName = "Andre";
      p1.LastName = "Ballard2";
      Batch b = new Batch();
      b.BatchName = "dotnet";
      b.StartDate = DateTime.Now;
      b.EndDate = DateTime.Now;
      b.size = 15;
      b.People.Add(p);
      b.People.Add(p1);
      var person = b.FindPerson(p1);
      Console.WriteLine(person.FirstName);
      Assert.IsNotNull(person);
    }

    [Test]
    public void FindPersonNegative()
    {
      var p = new Person();
      p.FirstName = "Andre";
      p.LastName = "Ballard";
      p.Gender = 'm';
      var p1 = new Person();
      p1.FirstName = "Andre";
      p1.LastName = "Ballard2";
      var p2 = new Person();
      p2.FirstName = "Andre";
      p2.LastName = "Ballard3";
      Batch b = new Batch();
      b.BatchName = "dotnet";
      b.StartDate = DateTime.Now;
      b.EndDate = DateTime.Now;
      b.size = 15;
      b.People.Add(p);
      b.People.Add(p1);
      var person = b.FindPerson(p2);
      //Console.WriteLine(person.FirstName);
      Assert.IsNull(person);
    }

  }
}
