using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Data.Library
{
    class Address
    {
        public string Street { get; set; }
        public int AptNum { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }
}
