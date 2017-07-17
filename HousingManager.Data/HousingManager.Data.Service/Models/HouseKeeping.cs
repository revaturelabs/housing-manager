using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.Models
{
    public class HouseKeeping
    {
        public ApartmentUnit ApartmentUnit { get; set; }
        public DateTime LastCleaning { get; set; }
        public DateTime NextCleaning { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null && obj.GetType() != GetType())
            {
                return false;
            }

            var o = obj as HouseKeeping;

            return (o.ApartmentUnit == ApartmentUnit && o.LastCleaning == LastCleaning && o.NextCleaning == NextCleaning);
        }

        public override int GetHashCode()
        {
            return (ApartmentUnit.GetHashCode() + LastCleaning.GetHashCode() + NextCleaning.GetHashCode());
        }

        public ApartmentUnit GetApartmentUnit()
        {
            return ApartmentUnit;
        }

        public DateTime GetLastCleaning()
        {
            return LastCleaning;
        }

        public DateTime GetNextCleaning()
        {
            return NextCleaning;
        }
    }
}
