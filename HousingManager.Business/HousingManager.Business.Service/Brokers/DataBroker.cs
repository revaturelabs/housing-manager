using HousingManager.Business.Library.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HousingManager.Business.Service.Brokers
{
    public class DataBroker
    {
        protected static string _Url = "http://localhost:50566/";

        protected HttpClient _Client = new HttpClient();

        public string GetValues()
        {
            var res = _Client.GetAsync(_Url + "/api/values").Result;
            if (res.IsSuccessStatusCode)
            {
                return res.Content.ReadAsStringAsync().Result;
            }
            else
            {
                return "error";
            }
        }

        public List<Address> GetAddresses()
        {
            var res = _Client.GetAsync(_Url + "/api/address").Result;
            if (res.IsSuccessStatusCode)
            {
                var content = res.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Address>>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
