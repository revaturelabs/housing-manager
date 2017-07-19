using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
  public class Maintenance : IModel
  {
    public string Issue { get; set; }
    private ApartmentUnit _ApartmentUnitNumber = new ApartmentUnit();
    private DateTime _SubmissionDate = new DateTime();

    public ApartmentUnit ApartmentUnitNumber
    {
      get
      {
        return _ApartmentUnitNumber;
      }
      set
      {
        _ApartmentUnitNumber = ApartmentUnitNumber;
      }
    }

    public DateTime SubmissionDate {
      get
      {
        return _SubmissionDate;
      }
      set
      {
        _SubmissionDate = SubmissionDate;
      }
    }
  }
}
