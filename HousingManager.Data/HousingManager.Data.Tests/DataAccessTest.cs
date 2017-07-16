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
        private static string _ConString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=HousingManager.DB.SqlServer;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        private IDataAccess<Address> _AdrData = new DataAccessEntityFactory().GetAddressDAO();

        [SetUp]
        public void SetUp()
        {
            new SqlCommand("test_Setup", new SqlConnection(_ConString)).ExecuteNonQuery();
        }

        [TearDown]
        public void TearDown()
        {
            new SqlCommand("test_Teardown", new SqlConnection(_ConString)).ExecuteNonQuery();
        }

        [Test]
        public void ReadTest()
        {
            Assert.IsTrue(_AdrData.Read().Count >= 1);
        }
    }
}
