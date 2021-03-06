﻿using HousingManager.Data.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.DAOs
{
  public class PersonDataAccess : DataAccessEntity<Person>
  {
    public PersonDataAccess(HousingManagerDBContext context) : base(context)
    {
    }

    public override Person Get(Person model)
    {
      return _Context.Set<Person>().FirstOrDefault(p => p.FirstName == model.FirstName && p.LastName == model.LastName);
    }
  }
}
