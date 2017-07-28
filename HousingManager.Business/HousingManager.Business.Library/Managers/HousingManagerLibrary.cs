using HousingManager.Business.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Managers
{
  public static class HousingManagerLibrary
  {
    public static bool ValidatePerson(Person person)
    {
      if (person.FirstName != "" && person.LastName != "")
      {
        return true;
      }
      return false;
    }

    public static bool ValidateApartmentUnit(ApartmentUnit apartmentUnit)
    {
      if (apartmentUnit.Capacity < 1)
      {
        return false;
      }
      return true;
    }
  }
}
