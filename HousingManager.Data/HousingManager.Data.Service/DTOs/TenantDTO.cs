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
    public string ApartmentComplexName { get; set; }
    public int Capacity { get; set; }
    public AddressDTO Address { get; set; }
    public Guid Guid { get; set; }
  }
}
