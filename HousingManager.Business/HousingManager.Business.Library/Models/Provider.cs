using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
  public class Provider
  {
    public string Issue { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public Guid Guid { get; set; }
    private ApartmentUnit _Unit = new ApartmentUnit();

    public ApartmentUnit Unit
    {
      get
      {
        return _Unit;
      }
      set
      {
        _Unit = Unit;
      }
    }
  }
}
