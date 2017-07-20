using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HousingManager.Business.Service.Interfaces;
using HousingManager.Business.Library.Models;
using Newtonsoft.Json;

namespace HousingManager.Business.Service.Brokers
{
    public class ServiceBroker<T> : BaseBroker<T> where T : IModel, new()
    {
        internal ServiceBroker( )
        {
            Url = "http://housingmanagerdata.azurewebsites.net/api/";
        }

        public override T Get(int id )
        {
           
            throw new NotImplementedException();
        }

        public override List<T> GetAll( )
        {
            var type = new T();
            
            string temp = Url + type.GetType().Name;

            var response = client.GetAsync(temp).Result;

            List<T> obj = new List<T>();
            JsonConvert.DeserializeAnonymousType<List<T>>(response.Content.ReadAsStringAsync().Result, obj);
            
            return obj;
            
        }

        public override bool Add(T model)
        {
            return false;
        }

        public override bool Delete(int id)
        {
            return false;
        }


        public override string TestGet( )
        {
            var blah = new T();

            string temp = Url + blah.GetType().Name;

            var response = client.GetAsync(temp).Result;

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }

            return "Lol, wrong";
        }
    }
}
