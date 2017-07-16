using HousingManager.Data.Library.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.DAOs
{
    public class AddressDataAccess : DataAccessEntity<Address>
    {
        public AddressDataAccess(HousingManager_DB_SqlServerContext context) : base(context) { }

        public override bool Delete(Address model)
        {
            throw new NotImplementedException();
        }

        public override Address Get(Address model)
        {
            throw new NotImplementedException();
        }

        public override Address Update(Address model)
        {
            throw new NotImplementedException();
        }
    }
}
