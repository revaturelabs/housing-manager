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

        public override Address Get(Address model)
        {
            return _Context.Set<Address>().FirstOrDefault(a => a.StreetName == model.StreetName && 
                                                            a.AptNum == model.AptNum && 
                                                            a.City == model.City && 
                                                            a.State == model.State && 
                                                            a.ZipCode == model.ZipCode);
        }
    }
}
