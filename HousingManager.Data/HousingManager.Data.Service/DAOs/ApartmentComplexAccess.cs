using HousingManager.Data.Library.EFModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.DAOs
{
  public class ApartmentComplexAccess : DataAccessEntity<ApartmentComplex>
  {
    public ApartmentComplexAccess(HousingManager_DB_SqlServerContext context) : base(context)
    { }

    public override ApartmentComplex Get(ApartmentComplex model)
    {
      return _Context.Set<ApartmentComplex>().FirstOrDefault(a => a.ApartmentName == model.ApartmentName);
    }

    public override List<ApartmentComplex> Read()
    {
      return _Context.Set<ApartmentComplex>().Include(a => a.ApartmentUnit).ToList();
    }
  }
}
