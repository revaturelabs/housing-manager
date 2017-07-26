using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.DTOs
{
  public class PersonBatchDTO
  {

    public Guid PersonGuid { get; set; }
    public Guid ApartmentGuid { get; set; }
    public DateTime MoveInDate { get; set; }
    public DateTime MoveOutDate { get; set; }
    public string Gender { get; set; }

  }
}
