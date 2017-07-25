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
            string uri = Url + typeof(T).Name;
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

        public override T Get(Guid guid)
        {
            string uri = Url + typeof(T).Name;
            string what = guid.ToString("D");
            var response = client.GetAsync(uri).Result;

            if (response.IsSuccessStatusCode)
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
            string temp = Url + typeof(T).Name;

            var response = client.GetAsync(temp).Result;

            List<T> obj = new List<T>();
            obj = JsonConvert.DeserializeObject<List<T>>(response.Content.ReadAsStringAsync().Result);
            
            return obj;
            
        }

        public override bool Add(T model)
        {
            string connect = Url + typeof(T).Name;
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
            string temp = Url + typeof(T).Name;

            var response = client.GetAsync(temp).Result;

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }

            return "Lol, wrong";
        }

        public string GetRoute()
        {
            return Url;
        }
    }
}
