using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.Interfaces
{
    public interface IDataFactory
    {
        IDataAccess<Address> GetAddressDataAccessEntity();
    }
}
