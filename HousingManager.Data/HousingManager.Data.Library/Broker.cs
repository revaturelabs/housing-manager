using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Data.Library
{
    public class Broker
    {
        public Address AddAddress()
        {
            var a = new Address();
            a.Street = "wordsworth";
            a.AptNum = 123;
            a.City = "Herndon";
            a.State = "Virginia";
            a.ZipCode = 12345;
            return a;
        }
        public Address AddAddress2()
        {
            var a = new Address();
            a = null;
            return a;
        }
    }
}
