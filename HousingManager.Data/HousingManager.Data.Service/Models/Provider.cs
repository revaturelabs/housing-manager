using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.Models
{
    public class Provider
    {
        public string Name { get; set; }
        public ContactInfo ProviderContactInfo { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null && obj.GetType() != GetType())
            {
                return false;
            }

            var o = obj as Provider;

            return (o.Name == Name && o.ProviderContactInfo == ProviderContactInfo);
        }

        public override int GetHashCode()
        {
            return (Name.GetHashCode() + ProviderContactInfo.GetHashCode());
        }

        public string GetName()
        {
            return Name;
        }

        public ContactInfo GetProviderContactInfo()
        {
            return ProviderContactInfo;
        }
    }
}
