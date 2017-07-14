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
            a.AptNumber = "112";
            a.StreetName = "111 Maple Dr";
            a.State = "Texas";
            a.City = "Houston";
            a.ZipCode = "78363";
            return a;
        }

        public Address AddAddress2()
        {
            var a = new Address();
            a.AptNumber = "112";
            a.StreetName = "111 Maple Dr";
            a.State = "Texas";
            a.City = "Houston";
            a.ZipCode = "78363";
            return a;
        }
  }
}
