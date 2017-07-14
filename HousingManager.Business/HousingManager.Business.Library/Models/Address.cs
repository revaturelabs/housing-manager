using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
  public class Address
  { 
    public string StreetName { get; set; }
    public string AptNum { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }

    public override bool Equals(object obj)
    {
      if (obj == null && obj.GetType() != GetType())
      {
        return false;
      }

      var o = obj as Address;

      return (o.AptNum == AptNum && o.StreetName == StreetName && o.City == City && o.State == State && o.ZipCode == ZipCode);
    }

    public override int GetHashCode()
    {
      return (AptNum.GetHashCode() + StreetName.GetHashCode());
    }

  }
}
