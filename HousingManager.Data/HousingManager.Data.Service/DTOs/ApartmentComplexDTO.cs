using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.DTOs
{
  public class ApartmentComplexDTO
  {
    private List<ApartmentUnitDTO> _stuff = new List<ApartmentUnitDTO>();
    public string ApartmentName { get; set; }
    public List<ApartmentUnitDTO> AptUnitDTO
    {
      get
      {
        return _stuff;
      }
      set
      {
        _stuff = AptUnitDTO;
      }
    }
  }
}
