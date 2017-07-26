using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
  public class Person : IModel
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Address PersonAddress = new Address();
    public char Gender { get; set; }
    public Guid Guid { get; set; }
    public ContactInfo ContactInformation = new ContactInfo();

    public string GetPhoneNumber()
    {
      return ContactInformation.GetPhoneNumber();
    }

    public string GetEmail()
    {
      return ContactInformation.GetEmail();
    }

    public bool Compare(ContactInfo c)
    {
      return ContactInformation.Equals(c);
    }

    public bool Compare(Address a)
    {
      return PersonAddress.Equals(a);
    }

    public override bool Equals(object obj)
    {
      if (obj == null && obj.GetType() != GetType())
      {
        return false;
      }

      var o = obj as Person;

      return (o.FirstName == FirstName && o.LastName == LastName && o.PersonAddress == PersonAddress && o.Gender == Gender && o.ContactInformation == ContactInformation);
    }

    public override int GetHashCode()
    {
      return (FirstName.GetHashCode() + LastName.GetHashCode());
    }
  }
}
