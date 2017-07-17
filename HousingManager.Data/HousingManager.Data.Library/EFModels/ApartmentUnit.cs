using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.EFModels
{
    public partial class ApartmentUnit
    {
        public ApartmentUnit()
        {
            ApartmentSupplyRequest = new HashSet<ApartmentSupplyRequest>();
            TenantInfo = new HashSet<TenantInfo>();
        }

        public int ApartmentUnitId { get; set; }
        public int ApartmentComplexId { get; set; }
        public int AddressId { get; set; }
        public int ProviderId { get; set; }
        public int Capacity { get; set; }

        public virtual ICollection<ApartmentSupplyRequest> ApartmentSupplyRequest { get; set; }
        public virtual ICollection<TenantInfo> TenantInfo { get; set; }
        public virtual Address Address { get; set; }
        public virtual ApartmentComplex ApartmentComplex { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
