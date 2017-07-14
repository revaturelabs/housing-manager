using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HousingManager.Business.Service.Brokers
{
    public class DataBroker<T> where T: class
    {
        private static string _Url = "";

        private HttpClient _Client = new HttpClient();

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

        public List<T> Get(string ctrlName)
        {
            var res = _Client.GetAsync(_Url + ctrlName).Result;
            if (res.IsSuccessStatusCode)
            {
                var content = res.Content.ReadAsStringAsync().Result;
                var r = JsonConvert.DeserializeObject<List<T>>(content);
                return r;
            }
            return null;
        }
    }
}
