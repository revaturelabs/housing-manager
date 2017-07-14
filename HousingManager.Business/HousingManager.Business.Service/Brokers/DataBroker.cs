using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HousingManager.Business.Service.Brokers
{
    public class DataBroker
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
    }
}
