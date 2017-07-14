using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
  public class Person
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Address PersonAddress = new Address();
    public char Gender { get; set; }
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
  }
}
