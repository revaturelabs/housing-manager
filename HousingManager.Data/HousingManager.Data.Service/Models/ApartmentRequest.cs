using HousingManager.Data.Library.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.Models
{
    public class ApartmentRequest
    {
        public DateTime Submitted { get; set; }
        public int Beds { get; set; }
        public Person Manager { get; set; }
        public Provider Provider { get; set; }
    }
}
