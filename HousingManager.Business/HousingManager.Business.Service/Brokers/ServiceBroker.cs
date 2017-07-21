using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HousingManager.Business.Service.Interfaces;
using HousingManager.Business.Library.Models;
using Newtonsoft.Json;
using System.Net.Http;

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
            var type = new T();
            string uri = Url + type.GetType().Name;
            var response = client.GetAsync(uri).Result;

            if(response.IsSuccessStatusCode)
            {
                T obj = new T();
                obj =
                JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
                return obj;
            }

            else
            {
                return null;
            }
        }

        public override List<T> GetAll( )
        {
            var type = new T();
            
            string temp = Url + type.GetType().Name;

            var response = client.GetAsync(temp).Result;

            List<T> obj = new List<T>();
            obj = JsonConvert.DeserializeObject<List<T>>(response.Content.ReadAsStringAsync().Result);
            //obj = JsonConvert.DeserializeAnonymousType<List<T>>(response.Content.ReadAsStringAsync().Result, obj);
            
            return obj;
            
        }

        public override bool Add(T model)
        {
            var content = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");
            var response = client.PostAsync(Url, content).Result;

            if(response.IsSuccessStatusCode)
            {
                return true;
            }


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
