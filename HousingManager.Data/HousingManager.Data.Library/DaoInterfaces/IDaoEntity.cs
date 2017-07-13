using System;
using System.Collections.Generic;
using System.Text;

namespace HousingManager.Data.Library.DaoInterfaces
{
    interface IDaoEntity<T>
    {
        T Create(T obj);
        List<T> Read();
        T Update(T obj);
        bool Delete(T obj);
    }
}
