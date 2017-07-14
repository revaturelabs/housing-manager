using System;
using System.Collections.Generic;
//using 
namespace HousingManager.Data.Library.Model1
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public string StreetName { get; set; }
        public string AptNum { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }
}
