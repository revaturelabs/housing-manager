using HousingManager.Data.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.Models
{
  public class ProviderSupplyRequest
  {
    public int SupplyId { get; set; }
    public int ProviderId { get; set; }
    public int ManagerId { get; set; }
    public DateTime Submitted { get; set; }
    public Person Manager = new Person();
    public Provider Provider = new Provider();
    public Supply Supply = new Supply();

    public override bool Equals(object obj)
    {
      if (obj == null && obj.GetType() != GetType())
      {
        return false;
      }

      var o = obj as ProviderSupplyRequest;

      return (o.Submitted == Submitted && o.Manager == Manager && o.Provider == Provider && o.Supply == Supply);
    }

    public override int GetHashCode()
    {
      return (Submitted.GetHashCode() + Manager.GetHashCode() + Provider.GetHashCode() + Supply.GetHashCode());
    }

    public DateTime GetDateSubmitted()
    {
      return Submitted;
    }

    public Person GetManager()
    {
      return Manager;
    }

    public Provider GetProvider()
    {
      return Provider;
    }

    public Supply GetSupply()
    {
      return Supply;
    }
  }
}
