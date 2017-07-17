using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.EFModels
{
    public partial class TenantInfo
    {
        public int TenantInfo1 { get; set; }
        public int PersonId { get; set; }
        public int BatchId { get; set; }
        public int ApartmentUnitId { get; set; }
        public string Gender { get; set; }
        public DateTime MoveInDate { get; set; }
        public DateTime MoveOutDate { get; set; }
        public bool? HasCar { get; set; }

        public virtual ApartmentUnit ApartmentUnit { get; set; }
        public virtual Batch Batch { get; set; }
        public virtual Person Person { get; set; }
    }
}
