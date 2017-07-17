using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.EFModels
{
    public partial class Provider
    {
        public Provider()
        {
            ApartmentRequest = new HashSet<ApartmentRequest>();
            ApartmentUnit = new HashSet<ApartmentUnit>();
            ProviderContactInfo = new HashSet<ProviderContactInfo>();
            ProviderSupplyRequest = new HashSet<ProviderSupplyRequest>();
        }

        public int ProviderId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ApartmentRequest> ApartmentRequest { get; set; }
        public virtual ICollection<ApartmentUnit> ApartmentUnit { get; set; }
        public virtual ICollection<ProviderContactInfo> ProviderContactInfo { get; set; }
        public virtual ICollection<ProviderSupplyRequest> ProviderSupplyRequest { get; set; }
    }
}
