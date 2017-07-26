using HousingManager.Data.Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.DAOs
{
  public class TenantDataAccess : DataAccessEntity<TenantInfo>
  {
    public TenantDataAccess(HousingManagerDBContext context) : base(context)
    { }

    public override TenantInfo Get(TenantInfo model)
    {
      throw new NotImplementedException();
    }
    public override List<TenantInfo> Read()
    {
      return _Context.Set<TenantInfo>()
        .Include(p => p.Person)
        .Include(b => b.Batch)
          .ThenInclude(bt => bt.BatchType)
        .ToList();
    }
  }
}
