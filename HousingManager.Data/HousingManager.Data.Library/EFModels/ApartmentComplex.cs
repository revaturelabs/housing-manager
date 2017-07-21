using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.Models
{
    public partial class ApartmentComplex
    {
        public ApartmentComplex()
        {
            ApartmentUnit = new HashSet<ApartmentUnit>();
        }

        public int ApartmentComplexId { get; set; }
        public int AddressId { get; set; }
        public string ApartmentName { get; set; }
        public bool? WalkingDistance { get; set; }
        public Guid Guid { get; set; }

        public virtual ICollection<ApartmentUnit> ApartmentUnit { get; set; }
        public virtual Address Address { get; set; }
    }
}
