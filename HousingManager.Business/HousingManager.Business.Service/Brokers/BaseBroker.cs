using HousingManager.Business.Service.Interfaces;
using HousingManager.Business.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace HousingManager.Business.Service.Brokers
{
    public abstract class BaseBroker<T>  : IBroker<T> where T: IModel
    {
        internal HttpClient client = new HttpClient();
        internal string Url;
        public abstract T Get(int id );
        public abstract List<T> GetAll( );
        public abstract bool Add(T model);
        public abstract bool Delete(int id);


        public abstract string TestGet( );

    }
}
