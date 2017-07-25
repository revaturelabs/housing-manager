using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.DTOs
{
  public class AddressDTO
  {
    public string StreetName { get; set; }
    public string AptNum { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int ZipCode { get; set; }
    public Guid Guid { get; set; }
  }
}
