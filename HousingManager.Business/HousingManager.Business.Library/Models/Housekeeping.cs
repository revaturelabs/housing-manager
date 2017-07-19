using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
  public class Housekeeping
  {
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
  }
}
