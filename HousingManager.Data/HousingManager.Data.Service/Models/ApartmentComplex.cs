using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.Models
{
    public class ApartmentComplex
    {
        public Address Address = new Address();
        public string Name { get; set; }
        public bool WalkingDistance { get; set; }
        public List<ApartmentUnit> Apartments { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null && obj.GetType() != GetType())
            {
                return false;
            }

            var o = obj as ApartmentComplex;

            return (o.Address.AptNum == Address.AptNum && o.Address.City == Address.City && o.Address.State == Address.State && o.Address.Street == Address.Street && o.Address.ZipCode == Address.ZipCode
                && o.Name == Name && o.WalkingDistance == WalkingDistance && o.Apartments == Apartments);
        }

        public override int GetHashCode()
        {
            return (Address.AptNum.GetHashCode() + Address.City.GetHashCode() + Address.State.GetHashCode() + Address.State.GetHashCode() + Address.Street.GetHashCode() + Name.GetHashCode()
                + WalkingDistance.GetHashCode() + Apartments.GetHashCode());
        }

        public int GetAddressAptNum()
        {
            return Address.AptNum;
        }

        public string GetAddressCity()
        {
            return Address.City;
        }

        public string GetAddressState()
        {
            return Address.State;
        }

        public string GetAddressStreet()
        {
            return Address.Street;
        }

        public int GetAddressZipCode()
        {
            return Address.ZipCode;
        }

        public string GetApartmentName()
        {
            return Name;
        }

        public bool GetWalkingDistance()
        {
            return WalkingDistance;
        }

        public List<ApartmentUnit> GetApartments()
        {
            return Apartments;
        }
    }
}
