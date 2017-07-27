using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using HousingManager.Business.Library.Models;
using HousingManager.Business.Library.Managers;

namespace HousingManager.Business.Tests.HousinigManagerTests
{
    [TestFixture]
    public class HousingManagerLibraryTests
    {
        
        [Test]
        public void ValidateApartmentUnitTestPos()
        {
            ApartmentUnit testSubject = new ApartmentUnit();

            testSubject.Capacity = 4;

            Assert.IsTrue(HousingManagerLibrary.ValidateApartmentUnit(testSubject));
        }

        [Test]
        public void ValidateApartumentUnitTestNeg()
        {
            ApartmentUnit testSubject = new ApartmentUnit();

            testSubject.Capacity = 0;

            Assert.IsFalse(HousingManagerLibrary.ValidateApartmentUnit(testSubject));
        }
    }
}
