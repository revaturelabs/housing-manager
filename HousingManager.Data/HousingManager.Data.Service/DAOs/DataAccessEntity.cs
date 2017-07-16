using HousingManager.Data.Library.EFModels;
using HousingManager.Data.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.DAOs
{
    public abstract class DataAccessEntity<T> : IDataAccess<T> where T: class
    {
        protected DbContext _Context;

        public DataAccessEntity(HousingManager_DB_SqlServerContext context)
        {
            _Context = context;
        }

        public T Create(T model)
        {
            var e = _Context.Set<T>().Add(model).Entity;
            _Context.SaveChanges();
            return e;
        }
        
        public List<T> Read()
        {
            return _Context.Set<T>().ToList();
        }

        public abstract T Get(T model);

        public abstract T Update(T model);

        public abstract bool Delete(T model);
    }
}
