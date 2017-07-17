using HousingManager.Business.Library.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousingManager.Business.Service.Brokers
{
    public class PersonBroker : DataBroker
    {
        public List<Person> GetPeople()
        {
            var res = _Client.GetAsync(_Url + "/api/person").Result;
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
    }
}
