using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.Models
{
    public class ApartmentUnit
    {
        public Provider Provider { get; set; }
        public Address Address { get; set; }
        public int Capacity { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null && obj.GetType() != GetType())
            {
                return false;
            }

            var o = obj as ApartmentUnit;

            return (o.Provider.Name == Provider.Name && o.Provider.ProviderContactInfo.Email == Provider.ProviderContactInfo.Email && o.Provider.ProviderContactInfo.PhoneNumber == Provider.ProviderContactInfo.PhoneNumber
                && o.Address.AptNum == Address.AptNum && o.Address.City == Address.City && o.Address.State == Address.State && o.Address.Street == Address.Street && o.Address.ZipCode == Address.ZipCode);
        }

        public override int GetHashCode()
        {
            return (Provider.Name.GetHashCode() + Provider.ProviderContactInfo.Email.GetHashCode() + Provider.ProviderContactInfo.PhoneNumber.GetHashCode() + Address.AptNum.GetHashCode()
                + Address.City.GetHashCode() + Address.State.GetHashCode() + Address.State.GetHashCode() + Address.Street.GetHashCode());
        }

        public string GetProviderName()
        {
            return Provider.Name;
        }

        public string GetProviderContactInfoEmail()
        {
            return Provider.ProviderContactInfo.Email;
        }

        public string GetProviderContactInfoPhone()
        {
            return Provider.ProviderContactInfo.PhoneNumber;
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
    }
}
