using System;
using System.Collections.Generic;

namespace HousingManager.Data.Library.EFModels
{
    public partial class PersonContactInfo
    {
        public int PersonId { get; set; }
        public int ContactInfoId { get; set; }

        public virtual ContactInfo ContactInfo { get; set; }
        public virtual Person Person { get; set; }
    }
}
