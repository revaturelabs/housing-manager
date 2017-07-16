using HousingManager.Data.Library.EFModels;
using HousingManager.Data.Service;
using HousingManager.Data.Service.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HousingManager.Data.Tests
{
    [TestFixture]
    public class DataAccessTest
    {
        private static string _ConString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=HousingManager.DB.SqlServer;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private IDataAccess<Address> _AdrData = new DataAccessEntityFactory().GetAddressDAO();

        [SetUp]
        public void SetUp()
        {
            using (var con = new SqlConnection(_ConString))
            {
                con.Open();
                new SqlCommand("testSetup", con).ExecuteNonQuery();
                con.Close();
            }
        }

        [TearDown]
        public void TearDown()
        {
            using (var con = new SqlConnection(_ConString))
            {
                con.Open();
                new SqlCommand("testTeardown", con).ExecuteNonQuery();
                con.Close();
            }
        }

        [Test]
        public void CreateTest()
        {
            var adr = new Address
            {
                StreetName = "500 Test Street",
                AptNum = "500",
                City = "TestVille",
                State = "Test",
                ZipCode = 12345
            };
            var entity = _AdrData.Create(adr);
            Assert.IsTrue(adr.StreetName == entity.StreetName &&
                adr.AptNum == entity.AptNum &&
                adr.City == entity.City &&
                adr.State == entity.State &&
                adr.ZipCode == entity.ZipCode);
        }

        [Test]
        public void ReadTest()
        {
            Assert.IsTrue(_AdrData.Read().Count >= 1);
        }
    }
}
