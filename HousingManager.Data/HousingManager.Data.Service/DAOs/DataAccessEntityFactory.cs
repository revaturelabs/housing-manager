using HousingManager.Data.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HousingManager.Data.Library.Models;

namespace HousingManager.Data.Service.DAOs
{
  public static class DataAccessEntityFactory
  {
    //private static HousingManager_DB_SqlServerContext _Context = new HousingManager_DB_SqlServerContext();

    public static IDataAccess<Address> GetAddressDAO(HousingManagerDBContext _Context)
    {
      return new AddressDataAccess(_Context);
    }

    public static IDataAccess<Person> GetPersonDAO(HousingManagerDBContext _Context)
    {
      return new PersonDataAccess(_Context);
    }

    public static IDataAccess<ApartmentComplex> GetApartmentComplexDAO(HousingManagerDBContext _Context)
    {
      return new ApartmentComplexAccess(_Context);
    }

    public static IDataAccess<Batch> GetBatchDAO(HousingManagerDBContext _Context)
    {
      return new BatchAccess(_Context);
    }

    public static IDataAccess<TenantInfo> GetTenantDAO(HousingManagerDBContext _Context)
    {
      return new TenantDataAccess(_Context);
    }
  }
}
