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

    public override bool Equals(object obj)
    {
      if (obj == null && obj.GetType() != GetType())
      {
        return false;
      }

      var o = obj as ApartmentComplex;

      return (o.ApartmentName == ApartmentName && o.Guid == Guid && o.ApartmentAddress == ApartmentAddress && o.ApartmentUnit == ApartmentUnit);
    }

    public override int GetHashCode()
    {
      return (ApartmentName.GetHashCode());
    }
  }
}
