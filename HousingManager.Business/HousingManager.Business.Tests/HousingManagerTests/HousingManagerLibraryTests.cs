using HousingManager.Business.Library.Managers;
using HousingManager.Business.Library.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Tests
{
    [TestFixture]
    public class HousingManagerLibraryTests
    {
        [Test]
        public void ValidatePersonMethodTestPos( )
        {
            Person p = new Person();

            p.FirstName = "Daniel";
            p.LastName = "Larner";

            Assert.IsTrue(HousingManagerLibrary.ValidatePerson(p));
        }

        [Test]
        public void ValidatePersonMethodTestNeg( )
        {
            Person p = new Person();

            p.FirstName = "";
            p.LastName = "string";

            Assert.IsFalse(HousingManagerLibrary.ValidatePerson(p));
        }

        [Test]
        public void ValidateApartmentUnitTestPos( )
        {
            ApartmentUnit testSubject = new ApartmentUnit();

            testSubject.Capacity = 4;

            Assert.IsTrue(HousingManagerLibrary.ValidateApartmentUnit(testSubject));
        }

        [Test]
        public void ValidateApartumentUnitTestNeg( )
        {
            ApartmentUnit testSubject = new ApartmentUnit();

            testSubject.Capacity = 0;

            Assert.IsFalse(HousingManagerLibrary.ValidateApartmentUnit(testSubject));
        }
    }
}
