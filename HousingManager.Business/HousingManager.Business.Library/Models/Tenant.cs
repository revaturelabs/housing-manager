using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
    public class Tenant
    {
        Person _person = new Person();
        
        Person tenant {
            get { return _person; }
            set { _person = tenant; }
        }

        DateTime MoveIn { get; set; }
        DateTime MoveOut { get; set; }


        Address _address = new Address();
        Address address
        {
            get { return _address; }
            set { _address = address; }
        }
        
        bool hasCar { get; set; }

        string batchName { get; set; }
    }
}
