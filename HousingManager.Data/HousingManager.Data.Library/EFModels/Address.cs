using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.EFModels
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
