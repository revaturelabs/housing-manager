using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.EFModels
{
    public partial class Person
    {
        public Person()
        {
            ApartmentRequest = new HashSet<ApartmentRequest>();
            PersonContactInfo = new HashSet<PersonContactInfo>();
            ProviderSupplyRequest = new HashSet<ProviderSupplyRequest>();
        }

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<ApartmentRequest> ApartmentRequest { get; set; }
        public virtual ICollection<PersonContactInfo> PersonContactInfo { get; set; }
        public virtual ICollection<ProviderSupplyRequest> ProviderSupplyRequest { get; set; }
        public virtual TenantInfo TenantInfo { get; set; }
    }
}
