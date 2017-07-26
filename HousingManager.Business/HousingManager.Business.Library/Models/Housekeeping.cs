using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
  public class Housekeeping : IModel
  {
    public Guid Guid { get; set; }
    private DateTime _CurrentDate = new DateTime();
    public DateTime CurrentDate
    {
      get
      {
        return _CurrentDate;
      }
      set
      {
        _CurrentDate = CurrentDate;
      }
    }

    private DateTime _NextDate = new DateTime();
    public DateTime NextDate
    {
      get
      {
        return _NextDate;
      }
      set
      {
        _NextDate = NextDate;
      }
    }

    public override bool Equals(object obj)
    {
      if (obj == null || obj.GetType() != GetType())
      {
        return false;
      }

      var o = obj as Housekeeping;

      return (o.Guid == Guid && o.CurrentDate == CurrentDate && o.NextDate == NextDate);
    }

    public override int GetHashCode()
    {
      return (Guid.GetHashCode());
    }
  }
}
