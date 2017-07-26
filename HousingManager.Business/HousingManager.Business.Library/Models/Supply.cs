using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Business.Library.Models
{
  public class Supply : IModel
  {
    public string Content { get; set; }
    public Guid Guid { get; set; }

    public override bool Equals(object obj)
    {
      if (obj == null && obj.GetType() != GetType())
      {
        return false;
      }

      var o = obj as Supply;

      return (o.Content == Content && o.Guid == Guid);
    }

    public override int GetHashCode()
    {
      return (Content.GetHashCode());
    }
  }
}
