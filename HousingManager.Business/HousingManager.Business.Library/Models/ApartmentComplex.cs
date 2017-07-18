using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
  public class ApartmentComplex
  {
    public string ApartmentName { get; set; }
    public Address ApartmentAddress { get; set; }
    private List<ApartmentUnit> _ApartmentUnit = new List<ApartmentUnit>();

    public List<ApartmentUnit> ApartmentUnit
    {
      get
      {
        return _ApartmentUnit;
      }
      set
      {
        _ApartmentUnit = ApartmentUnit;
      }

    }
  }
}
