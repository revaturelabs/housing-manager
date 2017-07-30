using HousingManager.Business.Library.Models;
using HousingManager.Business.Service.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Tests.BrokerTests
{
    [TestFixture]
    public class BrokerTests
    {


    [Test]
    public void IBrokerTest1()
    {
      var mock = new Mock<IBroker<ApartmentUnit>>();

      var mockList = new Mock<List<ApartmentUnit>>();

      var mockUnit = new Mock<ApartmentUnit>();

      mockList.Setup(o => o.Add(mockUnit.Object));
      mock.Setup(m => m.GetAll()).Returns(mockList.Object);

      Assert.NotNull(mock.Object.GetAll());
     

    }

    }
}
