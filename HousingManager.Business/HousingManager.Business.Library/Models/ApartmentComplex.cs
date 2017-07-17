using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
  public class ApartmentComplex
  {
    public string ApartmentName { get; set; }
    public Address ApartmentAddress { get; set; }
    public ApartmentUnit List<ApartmentUnit> { get; set; }
  }
}
