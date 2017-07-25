using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
  public class Tenant : IModel
  {
    private Person _person = new Person();
        
    public Person tenant {
        get { return _person; }
        set { _person = tenant; }
    }

    public DateTime MoveIn { get; set; }
    public DateTime MoveOut { get; set; }

    private Address _address = new Address();
    public Address address
    {
        get { return _address; }
        set { _address = address; }
    }
        
    public bool hasCar { get; set; }

    public string batchName { get; set; }

    public Guid Guid { get; set; }
  }
}
