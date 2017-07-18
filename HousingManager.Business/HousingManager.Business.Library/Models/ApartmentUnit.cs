using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
  public class ApartmentUnit
  {
    public int UnitNumber { get; set; }
    public string ComplexName { get; set; }
    public int Capacity { get; set; }
    //public Provider UnitProvider { get; set; }
  }
}
