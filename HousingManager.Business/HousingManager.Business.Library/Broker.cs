using HousingManager.Business.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library
{
    public class Broker
    {
      public Address AddAddress()
      {
        var a = new Address();
        a.AptNumber = "12";
        a.City = "Fresno";
        a.State = "Texas";
        a.StreetName = "Around the way";
        a.ZipCode = "77777";
        return a;
      }

    public Address AddAddress2()
    {
      var a = new Address();
      return a = null;
    }
  }
}
