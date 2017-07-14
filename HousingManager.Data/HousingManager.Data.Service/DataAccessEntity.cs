using HousingManager.Data.Library.EFModels;
using HousingManager.Data.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service
{
    public class DataAccessEntity<T> : IDataAccess<T> where T: class
    {
        private DbContext _Context;

        public DataAccessEntity(HousingManager_DB_SqlServerContext context)
        {
            _Context = context;
        }

        public T Create(T model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T model)
        {
            throw new NotImplementedException();
        }

        public List<T> Read()
        {
            return _Context.Set<T>().ToList();
        }

        public T Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}
