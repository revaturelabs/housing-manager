using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
  public class Person
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Address PersonAddress { get; set; }
    public char Gender { get; set; }
    public ContactInfo ContactInformation { get; set; }
  }
}
