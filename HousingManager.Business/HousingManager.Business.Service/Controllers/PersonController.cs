using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HousingManager.Business.Service.Brokers;
using HousingManager.Business.Library.Models;
using HousingManager.Business.Service.Interfaces;
using System.Net.Http;
using Newtonsoft.Json;

namespace HousingManager.Business.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/Person")]
    public class PersonController : Controller
    {
        
        IBroker<Person> _broker = BrokerFactory<Person>.GetInstance();

        [HttpGet]
        public List<Person> Get()
        {
            return _broker.GetAll();
        }

        
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return _broker.Get(id);
        }

        [HttpGet]
        [Route("{first}/{last}")]
        public Person Get(string first, string last)
        {
            // Get Person by first/last
            var route = new ServiceBroker<Person>().GetRoute();

            route += first + "/" + last;
            try
            {
                HttpClient client = new HttpClient();
                var response = client.GetAsync(route).Result;

                if (response.IsSuccessStatusCode)
                {
                    Person obj =
                        JsonConvert.DeserializeObject<Person>(response.Content.ReadAsStringAsync().Result);
                    return obj;
                }

                else return null;
            }

            catch { return null; }

        }
        
        
        [HttpPost]
        public void Post([FromBody]Person per)
        {
            _broker.Add(per);
        }


        [HttpPost]
        [Route("assign")]
        public void PostToApt([FromBody] PersonAptGuid)


        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _broker.Delete(id);
        }
    }
}
