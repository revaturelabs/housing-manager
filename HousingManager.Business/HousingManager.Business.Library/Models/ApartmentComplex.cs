using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
  public class ApartmentComplex : IModel
  {
    public string ApartmentName { get; set; }
    public Guid Guid { get; set; }
    public Address ApartmentAddress { get; set; }
    private List<ApartmentUnit> _ApartmentUnit = new List<ApartmentUnit>();

    public List<ApartmentUnit> AptUnitDTO
    {
      get
      {
        return _ApartmentUnit;
      }
      set
      {
        _ApartmentUnit = AptUnitDTO;
      }
    }

    public override bool Equals(object obj)
    {
      if (obj == null || obj.GetType() != GetType())
      {
        return false;
      }

      var o = obj as ApartmentComplex;
            if (o == null) return false;
      return (o.ApartmentName == ApartmentName && o.Guid == Guid && o.ApartmentAddress.Equals(ApartmentAddress));
    }

    public override int GetHashCode()
    {
      return (ApartmentName.GetHashCode());
    }
  }
}
