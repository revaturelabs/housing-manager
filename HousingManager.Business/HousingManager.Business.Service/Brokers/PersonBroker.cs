using HousingManager.Business.Library.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HousingManager.Business.Service.Brokers
{
    public class PersonBroker : DataBroker
    {
        private string _PUrl = _Url + "/api/person";

        public List<Person> GetPeople()
        {
            var res = _Client.GetAsync(_PUrl).Result;
            if (res.IsSuccessStatusCode)
            {
                var content = res.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Person>>(content);
            }
            else
            {
                return null;
            }
        }

        public void AddPerson(Person per)
        {
            var content = new StringContent(JsonConvert.SerializeObject(per), System.Text.Encoding.UTF8, "application/json");
            _Client.PostAsync(_PUrl, content);
        }


    }
}
