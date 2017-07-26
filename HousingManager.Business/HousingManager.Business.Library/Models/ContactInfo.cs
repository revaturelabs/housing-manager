using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;



namespace HousingManager.Business.Library.Models
{
  public class ContactInfo : IModel
  {
    public string EmailAddress { get; set; }     
    public string PhoneNumber { get; set; }
    public Guid Guid { get; set; }

    public override bool Equals(object obj)
    {
      if (obj == null || obj.GetType() != GetType())
      {
        return false;
      }
            
      var o = obj as ContactInfo;
           
      return (o.EmailAddress == EmailAddress && o.PhoneNumber == PhoneNumber);
    }

    public override int GetHashCode()
    {
      return (EmailAddress.GetHashCode() + PhoneNumber.GetHashCode());
    }

    public string GetEmail()
    {
      return EmailAddress;
    }

    public string GetPhoneNumber()
    {
      return PhoneNumber;
    }
  }
}
