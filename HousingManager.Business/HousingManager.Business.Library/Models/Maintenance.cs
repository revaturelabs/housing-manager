using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
  public class Maintenance : IModel
  {
    public string Issue { get; set; }
    public Guid Guid { get; set; }
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

    public override bool Equals(object obj)
    {
      if (obj == null || obj.GetType() != GetType())
      {
        return false;
      }

      var o = obj as Maintenance;

      return (o.Issue == Issue && o.Guid == Guid && o.ApartmentUnitNumber == ApartmentUnitNumber && o.SubmissionDate == SubmissionDate);
    }

    public override int GetHashCode()
    {
      return (Issue.GetHashCode());
    }
  }
}
