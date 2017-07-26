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

    public override bool Equals(object obj)
    {
      if (obj == null && obj.GetType() != GetType())
      {
        return false;
      }

      var o = obj as Provider;

      return (o.Issue == Issue && o.Email == Email && o.PhoneNumber == PhoneNumber && o.Guid == Guid && o.Unit == Unit);
    }

    public override int GetHashCode()
    {
      return (Issue.GetHashCode() + Email.GetHashCode());
    }
  }
}
