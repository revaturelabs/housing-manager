using HousingManager.Data.Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.DAOs
{
  public class ApartmentUnitDataAccess : DataAccessEntity<TenantInfo>
  {
    public ApartmentUnitDataAccess(HousingManagerDBContext context) : base(context)
    { }
    

    public override TenantInfo Get(TenantInfo model)
    {
      throw new NotImplementedException();
    }

    public override List<TenantInfo> Read()
    {
      return _Context.Set<TenantInfo>()
        .Include(au => au.ApartmentUnit)
          .ThenInclude(ac => ac.ApartmentComplex)
          .ThenInclude(au2 => au2.ApartmentUnit)
          .ThenInclude(ad => ad.Address)
        .Include(p => p.Person)
        .ToList();
    }
  }
}
