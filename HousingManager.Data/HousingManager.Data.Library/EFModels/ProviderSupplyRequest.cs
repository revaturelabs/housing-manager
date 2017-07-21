using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.Models
{
    public partial class ProviderSupplyRequest
    {
        public int SupplyRequestId { get; set; }
        public int SupplyId { get; set; }
        public int ProviderId { get; set; }
        public int ManagerId { get; set; }
        public DateTime? Submitted { get; set; }
        public Guid Guid { get; set; }

        public virtual Person Manager { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual Supply Supply { get; set; }
    }
}
