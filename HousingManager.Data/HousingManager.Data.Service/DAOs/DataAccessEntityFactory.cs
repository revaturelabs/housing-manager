﻿using HousingManager.Data.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HousingManager.Data.Library.EFModels;

namespace HousingManager.Data.Service.DAOs
{
  public static class DataAccessEntityFactory
  {
    private static HousingManager_DB_SqlServerContext _Context = new HousingManager_DB_SqlServerContext();

    public static IDataAccess<Address> GetAddressDAO()
    {
      return new AddressDataAccess(_Context);
    }

    public static IDataAccess<Person> GetPersonDAO()
    {
      return new PersonDataAccess(_Context);
    }

    public static IDataAccess<ApartmentComplex> GetApartmentComplexDAO()
    {
      return new ApartmentComplexAccess(_Context);
    }
  }
}
