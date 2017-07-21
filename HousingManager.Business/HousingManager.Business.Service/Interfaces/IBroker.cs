using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HousingManager.Business.Library.Models;

namespace HousingManager.Business.Service.Interfaces
{
    public interface IBroker<T> where T : IModel
    {
        T Get(int id );
        List<T> GetAll( );
        bool Add(T model);
        bool Delete(int id);

        string TestGet( );
    }
}
