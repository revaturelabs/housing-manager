using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.DTOs
{
  public class ApartmentUnitDTO
  {
    public AddressDTO Addr { get; set; }
    public Guid Guid { get; set; }
  }
}
