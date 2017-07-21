using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.Models
{
    public partial class MaintenanceRequest
    {
        public int MaintenanceRequestId { get; set; }
        public int MaintenanceTypeId { get; set; }
        public int ApartmentUnitId { get; set; }
        public int ManagerId { get; set; }
        public DateTime Submitted { get; set; }
        public string Desctiption { get; set; }
        public Guid Guid { get; set; }

        public virtual MaintenanceType ApartmentUnit { get; set; }
        public virtual MaintenanceType MaintenanceType { get; set; }
    }
}
