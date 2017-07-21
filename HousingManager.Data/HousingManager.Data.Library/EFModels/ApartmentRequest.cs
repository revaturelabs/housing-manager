using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.Models
{
    public partial class ApartmentRequest
    {
        public int ApartmentRequestId { get; set; }
        public int ManagerId { get; set; }
        public int ProviderId { get; set; }
        public DateTime? Submitted { get; set; }
        public int Beds { get; set; }
        public Guid Guid { get; set; }

        public virtual Person Manager { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
