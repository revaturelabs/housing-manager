using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.EFModels
{
    public partial class ContactInfo
    {
        public ContactInfo()
        {
            PersonContactInfo = new HashSet<PersonContactInfo>();
            ProviderContactInfo = new HashSet<ProviderContactInfo>();
        }

        public int ContactInfoId { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<PersonContactInfo> PersonContactInfo { get; set; }
        public virtual ICollection<ProviderContactInfo> ProviderContactInfo { get; set; }
    }
}
