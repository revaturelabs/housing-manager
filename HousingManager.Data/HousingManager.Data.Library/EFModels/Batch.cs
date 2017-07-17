using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.EFModels
{
    public partial class Batch
    {
        public Batch()
        {
            TenantInfo = new HashSet<TenantInfo>();
        }

        public int BatchId { get; set; }
        public int BatchTypeId { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Size { get; set; }

        public virtual ICollection<TenantInfo> TenantInfo { get; set; }
        public virtual BatchType BatchType { get; set; }
    }
}
