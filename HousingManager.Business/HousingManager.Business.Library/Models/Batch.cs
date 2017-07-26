using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
  public class Batch : IModel
  {
    public string BatchName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Size { get; set; }
    public Guid Guid { get; set; }
    public List<Person> People = new List<Person>();

    public Person FindPerson(Person person)
    {
      return People.Find(p => p == person);
    }

    public override bool Equals(object obj)
    {
      if (obj == null && obj.GetType() != GetType())
      {
        return false;
      }

      var o = obj as Batch;

      return (o.BatchName == BatchName && o.StartDate == StartDate && o.EndDate == EndDate && o.Size == Size && o.Guid == Guid);
    }

    public override int GetHashCode()
    {
      return (BatchName.GetHashCode());
    }
  }
}
