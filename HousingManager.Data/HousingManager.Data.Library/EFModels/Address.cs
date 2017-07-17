using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.EFModels
{
    public partial class Address
    {
        public Address()
        {
            ApartmentComplex = new HashSet<ApartmentComplex>();
        }

        public int AddressId { get; set; }
        public string StreetName { get; set; }
        public string AptNum { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public virtual ICollection<ApartmentComplex> ApartmentComplex { get; set; }
        public virtual ApartmentUnit ApartmentUnit { get; set; }
    }
}
