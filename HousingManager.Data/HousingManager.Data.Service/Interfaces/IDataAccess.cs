using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Data.Service.Interfaces
{
    public interface IDataAccess<T>
    {
        T Create(T model);
        List<T> Read();
        T Update(T model);
        bool Delete(T model);
    }
}
