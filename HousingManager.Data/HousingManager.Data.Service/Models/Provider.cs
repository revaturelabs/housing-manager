using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.Models
{
    public class Provider
    {
        public string Name { get; set; }
        public ContactInfo ProviderContactInfo = new ContactInfo();

        public override bool Equals(object obj)
        {
            if (obj == null && obj.GetType() != GetType())
            {
                return false;
            }

            var o = obj as Provider;

            return (o.Name == Name && o.ProviderContactInfo.Email == ProviderContactInfo.Email && o.ProviderContactInfo.PhoneNumber == ProviderContactInfo.PhoneNumber);
        }

        public override int GetHashCode()
        {
            return (Name.GetHashCode() + ProviderContactInfo.GetHashCode());
        }

        public string GetName()
        {
            return Name;
        }

        public string GetProviderContactInfoEmail()
        {
            return ProviderContactInfo.Email;
        }

        public string GetProviderContactInfoPhone()
        {
            return ProviderContactInfo.PhoneNumber;
        }
    }
}
