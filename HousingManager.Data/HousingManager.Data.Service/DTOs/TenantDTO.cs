using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.DTOs
{
  public class TenantDTO
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Guid Guid { get; set; }

    public string Batch { get; set; }
    public string Gender { get; set; }
  }
}
