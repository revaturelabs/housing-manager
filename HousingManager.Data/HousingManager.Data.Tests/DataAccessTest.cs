using HousingManager.Data.Library.EFModels;
using HousingManager.Data.Service;
using HousingManager.Data.Service.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Data.Tests
{
    [TestFixture]
    public class DataAccessTest
    {
        private IDataAccess<Address> _AdrData = new DataAccessEntityFactory().GetAddressDAO();

        [SetUp]
        public void SetUp()
        {
            
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
