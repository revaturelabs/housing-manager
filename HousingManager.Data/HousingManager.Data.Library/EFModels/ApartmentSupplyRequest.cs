using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.Models
{
    public partial class ApartmentSupplyRequest
    {
        public int SupplyRequestId { get; set; }
        public int SupplyId { get; set; }
        public int ApartmentUnitId { get; set; }
        public DateTime? Submitted { get; set; }
        public Guid Guid { get; set; }

        public virtual ApartmentUnit ApartmentUnit { get; set; }
        public virtual Supply Supply { get; set; }
    }
}
