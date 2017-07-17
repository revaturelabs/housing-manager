using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.EFModels
{
    public partial class ProviderContactInfo
    {
        public int ProviderId { get; set; }
        public int ContactInfoId { get; set; }

        public virtual ContactInfo ContactInfo { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
