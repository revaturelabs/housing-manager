using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.EFModels
{
    public partial class HouseKeeping
    {
        public int HousekeepingId { get; set; }
        public int ApartmentUnitId { get; set; }
        public DateTime LastCleaning { get; set; }
        public DateTime NextCleaning { get; set; }
    }
}
