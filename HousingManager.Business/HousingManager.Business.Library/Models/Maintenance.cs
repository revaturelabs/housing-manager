using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
  public class Maintenance
  {
    public string Issue { get; set; }
    public ApartmentUnit ApartmentUnitNumber { get; set; }
    public DateTime SubmissionDate { get; set; }
  }
}
