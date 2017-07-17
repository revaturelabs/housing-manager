using HousingManager.Data.Service.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Data.Tests
{
    [TestFixture]
    public class ApartmentComplexTest
    {
        [Test]
        public void ApartmentComplexIsEqualPositive()
        {
            var c = new ApartmentComplex();
            c.Name = "Ryan";
            c.WalkingDistance = true;
            c.Apartments.Add(new ApartmentUnit());
            c.Address.AptNum = 123;
            c.Address.City = "Herndon";
            c.Address.State = "Virginia";
            c.Address.Street = "WordsWorth ct";
            c.Address.ZipCode = 12345;
            var c1 = new ApartmentComplex();
            c1.Name = "Ryan";
            c1.WalkingDistance = true;
            c1.Apartments.Add(new ApartmentUnit());
            c1.Address.AptNum = 123;
            c1.Address.City = "Herndon";
            c1.Address.State = "Virginia";
            c1.Address.Street = "WordsWorth ct";
            c1.Address.ZipCode = 12345;
            var chash = c.GetHashCode();
            var c1hash = c1.GetHashCode();

            Assert.IsTrue(c.Equals(c1) && chash == c1hash);
        }

        [Test]
        public void ApartmentComplexIsEqualNegative()
        {
            var c = new ApartmentComplex();
            c.Name = "Ryan";
            c.WalkingDistance = true;
            c.Apartments.Add(new ApartmentUnit());
            c.Address.AptNum = 123;
            c.Address.City = "Herndon";
            c.Address.State = "Virginia";
            c.Address.Street = "WordsWorth ct";
            c.Address.ZipCode = 12345;
            var c1 = new ApartmentComplex();
            c1.Name = "Bryan";
            c1.WalkingDistance = true;
            c1.Apartments.Add(new ApartmentUnit());
            c1.Address.AptNum = 123;
            c1.Address.City = "Herndon";
            c1.Address.State = "Virginia";
            c1.Address.Street = "WordsWorth ct";
            c1.Address.ZipCode = 12345;
            var chash = c.GetHashCode();
            var c1hash = c1.GetHashCode();

            Assert.IsFalse(c.Equals(c1) && chash == c1hash);
        }

        [Test]
        public void ApartmentNamePositive()
        {
            var n = new ApartmentComplex();
            n.Name = "Ryan";
            var name = n.GetApartmentName();

            Assert.IsNotNull(name);
        }

        [Test]
        public void ApartmentNameNegative()
        {
            var n = new ApartmentComplex();
            var name = n.GetApartmentName();

            Assert.IsNull(name);
        }

        [Test]
        public void ApartmentComplexAddressAptNumPositive()
        {
            var c = new ApartmentComplex();
            c.Address.AptNum = 123;
            c.Address.City = "Herndon";
            c.Address.State = "Virginia";
            c.Address.Street = "WordsWorth ct";
            c.Address.ZipCode = 12345;
            var PAddress = c.GetAddressAptNum();

            Assert.IsNotNull(PAddress);
        }

        [Test]
        public void ApartmentComplexAddressAptNumNegative()
        {
            var c = new ApartmentComplex();
            c.Address.City = "Herndon";
            c.Address.State = "Virginia";
            c.Address.Street = "WordsWorth ct";
            c.Address.ZipCode = 12345;
            var PAddress = c.GetAddressAptNum();

            Assert.NotNull(PAddress);
        }

        [Test]
        public void ApartmentComplexAddressCityPositive()
        {
            var c = new ApartmentComplex();
            c.Address.AptNum = 123;
            c.Address.City = "Herndon";
            c.Address.State = "Virginia";
            c.Address.Street = "WordsWorth ct";
            c.Address.ZipCode = 12345;
            var PAddress = c.GetAddressCity();

            Assert.IsNotNull(PAddress);
        }

        [Test]
        public void ApartmentComplexAddressCityNegative()
        {
            var c = new ApartmentComplex();
            c.Address.State = "Virginia";
            c.Address.Street = "WordsWorth ct";
            c.Address.ZipCode = 12345;
            var PAddress = c.GetAddressCity();

            Assert.IsNull(PAddress);
        }

        [Test]
        public void ApartmentComplexAddressStatePositive()
        {
            var c = new ApartmentComplex();
            c.Address.AptNum = 123;
            c.Address.City = "Herndon";
            c.Address.State = "Virginia";
            c.Address.Street = "WordsWorth ct";
            c.Address.ZipCode = 12345;
            var PAddress = c.GetAddressState();

            Assert.IsNotNull(PAddress);
        }

        [Test]
        public void ApartmentComplexAddressStateNegative()
        {
            var c = new ApartmentComplex();
            c.Address.City = "Herndon";
            c.Address.Street = "WordsWorth ct";
            c.Address.ZipCode = 12345;
            var PAddress = c.GetAddressState();

            Assert.IsNull(PAddress);
        }

        [Test]
        public void ApartmentComplexAddressStreetPositive()
        {
            var c = new ApartmentComplex();
            c.Address.AptNum = 123;
            c.Address.City = "Herndon";
            c.Address.State = "Virginia";
            c.Address.Street = "WordsWorth ct";
            c.Address.ZipCode = 12345;
            var PAddress = c.GetAddressStreet();

            Assert.IsNotNull(PAddress);
        }

        [Test]
        public void ApartmentComplexAddressStreetNegative()
        {
            var c = new ApartmentComplex();
            c.Address.City = "Herndon";
            c.Address.State = "Virginia";
            c.Address.ZipCode = 12345;
            var PAddress = c.GetAddressStreet();

            Assert.IsNull(PAddress);
        }

        [Test]
        public void ApartmentComplexAddressZipCodePositive()
        {
            var c = new ApartmentComplex();
            c.Address.AptNum = 123;
            c.Address.City = "Herndon";
            c.Address.State = "Virginia";
            c.Address.Street = "WordsWorth ct";
            c.Address.ZipCode = 12345;
            var PAddress = c.GetAddressZipCode();

            Assert.IsNotNull(PAddress);
        }

        [Test]
        public void ApartmentComplexAddressZipCodeNegative()
        {
            var c = new ApartmentComplex();
            c.Address.City = "Herndon";
            c.Address.State = "Virginia";
            c.Address.Street = "WordsWorth ct";
            var PAddress = c.GetAddressZipCode();

            Assert.IsNotNull(PAddress);
        }

        public void WalkingDistancePositive()
        {
            var n = new ApartmentComplex();
            n.WalkingDistance = true;
            var WalkingDIstance = n.GetWalkingDistance();

            Assert.IsTrue(WalkingDIstance);
        }

        [Test]
        public void WalkingDistanceNegative()
        {
            var n = new ApartmentComplex();
            n.WalkingDistance = false;
            var WalkingDistance = n.GetWalkingDistance();

            Assert.IsFalse(WalkingDistance);
        }

        [Test]
        public void ApartmentsPositive()
        {
            var n = new ApartmentComplex();
            n.Apartments = new List<ApartmentUnit>();
            var Apartment = n.GetApartments();

            Assert.IsNotNull(Apartment);
        }

        [Test]
        public void ApartmentsNegative()
        {
            var n = new ApartmentComplex();
            var Apartment = n.GetApartments();

            Assert.IsEmpty(Apartment);
        }
    }
}
