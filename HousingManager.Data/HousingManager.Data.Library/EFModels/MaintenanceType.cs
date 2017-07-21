using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.Models
{
    public partial class MaintenanceType
    {
        public MaintenanceType()
        {
            MaintenanceRequestApartmentUnit = new HashSet<MaintenanceRequest>();
            MaintenanceRequestMaintenanceType = new HashSet<MaintenanceRequest>();
        }

        public int MaintenanceTypeId { get; set; }
        public string Issue { get; set; }
        public Guid Guid { get; set; }

        public virtual ICollection<MaintenanceRequest> MaintenanceRequestApartmentUnit { get; set; }
        public virtual ICollection<MaintenanceRequest> MaintenanceRequestMaintenanceType { get; set; }
    }
}
