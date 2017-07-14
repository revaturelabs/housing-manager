using HousingManager.Data.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HousingManager.Data.Library.EFModels;

namespace HousingManager.Data.Service
{
    public class DataAccessEntityFactory : IDataAccessFactory
    {
        private static HousingManager_DB_SqlServerContext _Context = new HousingManager_DB_SqlServerContext();

        public IDataAccess<Address> GetAddressDAO()
        {
            return new DataAccessEntity<Address>(_Context);
        }
    }
}
