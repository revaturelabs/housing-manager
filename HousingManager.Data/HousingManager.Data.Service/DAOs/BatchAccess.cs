using HousingManager.Data.Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.DAOs
{
    public class BatchAccess : DataAccessEntity<Batch>
  {
    public BatchAccess(HousingManagerDBContext context) : base(context)
    { }

    public override Batch Get(Batch model)
    {
      return _Context.Set<Batch>().FirstOrDefault(a => a.BatchType  == model.BatchType);
    }

    public override List<Batch> Read()
    {
      return _Context.Set<Batch>().Include(b => b.BatchType).ToList();
    }
  }
}
