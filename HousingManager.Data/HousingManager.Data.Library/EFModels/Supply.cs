using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.Models
{
    public partial class Supply
    {
        public Supply()
        {
            ApartmentSupplyRequest = new HashSet<ApartmentSupplyRequest>();
            ProviderSupplyRequest = new HashSet<ProviderSupplyRequest>();
        }

        public int SupplyId { get; set; }
        public string Type { get; set; }
        public Guid Guid { get; set; }

        public virtual ICollection<ApartmentSupplyRequest> ApartmentSupplyRequest { get; set; }
        public virtual ICollection<ProviderSupplyRequest> ProviderSupplyRequest { get; set; }
    }
}
