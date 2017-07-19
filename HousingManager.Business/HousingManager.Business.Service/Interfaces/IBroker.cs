using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HousingManager.Business.Library.Models;

namespace HousingManager.Business.Service.Interfaces
{
    public interface IBroker<T> where T : IModel
    {
        T Get( );
        List<T> GetAll( );

        string TestGet( );
    }
}
