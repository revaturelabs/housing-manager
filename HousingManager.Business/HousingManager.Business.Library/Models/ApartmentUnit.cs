using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
    public class ApartmentUnit : IModel
    {
        public int UnitNumber { get; set; }
        public string ComplexName { get; set; }
        public int Capacity { get; set; }
        public Guid Guid { get; set; }
        public Address Addr { get; set; }


        //private Provider _UnitProvider = new Provider();
        //public Provider UnitProvider
        //{
        //  get
        //  { 
        //    return _UnitProvider;
        //  }
        //  set
        //  {
        //    _UnitProvider = UnitProvider;
        //  }
        //}

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            var o = obj as ApartmentUnit;

            return (o.UnitNumber == UnitNumber && o.ComplexName == ComplexName && o.Capacity == Capacity && o.Guid == Guid);
        }

        public override int GetHashCode( )
        {
            return (UnitNumber.GetHashCode() + Capacity.GetHashCode());
        }
    }
}
