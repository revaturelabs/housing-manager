using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.EFModels
{
    public partial class BatchType
    {
        public BatchType()
        {
            Batch = new HashSet<Batch>();
        }

        public int BatchTypeId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Batch> Batch { get; set; }
    }
}
