using HousingManager.Data.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HousingManager.Data.Library.Model1;

namespace HousingManager.Data.Service
{
    public class DataAccessEntityFactory : IDataAccessFactory
    {
        private static DbContext _Context = new HousingManagerDBContext();

        public IDataAccess<Address> GetAddressDAO()
        {
            return new DataAccessEntity<Address>(_Context.Address);
        }
    }
}
