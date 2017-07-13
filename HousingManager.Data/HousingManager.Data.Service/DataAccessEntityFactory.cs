using HousingManager.Data.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service
{
    public class DataAccessEntityFactory : IDataAccessFactory
    {
        private static DbContext _Context = new HousingManagerDBEntities();

        public IDataAccess<Address> GetAddressDAO()
        {
            return new DataAccessEntity<Address>(_Context.Addresses);
        }
    }
}
