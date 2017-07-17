using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
    public class Batch
    {
      public string BatchName { get; set; }
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }
      public int size { get; set; }
      public static List<Person> People = new List<Person>();

      public Person FindPerson(Person person)
      {
        return People.Find(p => p == person);
      }

      
    }
}
