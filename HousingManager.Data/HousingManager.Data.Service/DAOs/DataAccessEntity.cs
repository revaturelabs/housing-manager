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
        
        public virtual List<T> Read()
        {
            return _Context.Set<T>().ToList();
        }

        public T Update(T model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T model)
        {
            var entity = Get(model);
            if (entity != null)
            {
                var e = _Context.Set<T>().Remove(entity);
                _Context.SaveChanges();
                return e != null;
            }
            return false;
        }

        public abstract T Get(T model);
    }
}
