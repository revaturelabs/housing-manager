using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.DTOs
{
    public class BatchDTO
    {
    public string BatchType { get; set; }
    public DateTime StarDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Size { get; set; }
    public Guid Guid { get; set; }
  }
}
