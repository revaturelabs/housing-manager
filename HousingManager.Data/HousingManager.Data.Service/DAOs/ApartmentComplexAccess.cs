using HousingManager.Data.Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.DAOs
{
  public class ApartmentComplexAccess : DataAccessEntity<ApartmentComplex>
  {
    public ApartmentComplexAccess(HousingManagerDBContext context) : base(context)
    { }

    public override ApartmentComplex Get(ApartmentComplex model)
    {
      return _Context.Set<ApartmentComplex>().FirstOrDefault(a => a.ApartmentName == model.ApartmentName);
    }

    public override List<ApartmentComplex> Read()
    {
      return _Context.Set<ApartmentComplex>()
        .Include(a => a.ApartmentUnit)
          .ThenInclude(ad => ad.Address)
        .ToList();
    }
  }
}
