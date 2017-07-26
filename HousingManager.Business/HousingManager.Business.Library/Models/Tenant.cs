using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
  public class Tenant : IModel
  {
    private Person _Person = new Person();
        
    public Person tenant {
        get { return _Person; }
        set { _Person = tenant; }
    }

    public DateTime MoveIn { get; set; }
    public DateTime MoveOut { get; set; }

    private Address _Address = new Address();
    public Address Address
    {
        get { return _Address; }
        set { _Address = Address; }
    }
        
    public bool HasCar { get; set; }

    public string BatchName { get; set; }

    public Guid Guid { get; set; }

    public override bool Equals(object obj)
    {
      if (obj == null || obj.GetType() != GetType())
      {
        return false;
      }

      var o = obj as Tenant;

      return (o.tenant == tenant && o.MoveIn == MoveIn && o.MoveOut == MoveOut && o.Address == Address && o.HasCar == HasCar && o.BatchName == BatchName && o.Guid == Guid);
    }

    public override int GetHashCode()
    {
      return (MoveIn.GetHashCode() + MoveOut.GetHashCode());
    }
  }
}
