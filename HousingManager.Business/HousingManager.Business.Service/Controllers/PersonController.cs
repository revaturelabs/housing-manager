using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HousingManager.Business.Service.Brokers;
using HousingManager.Business.Library.Models;
using HousingManager.Business.Service.Interfaces;
using HousingManager.Business.Library.Managers;
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
        public bool PostToApt([FromBody] PersonAptGuid toAssign)
        {
            var PBroker = new ServiceBroker<Person>();
            var ABroker = new ServiceBroker<ApartmentUnit>();

            var person = PBroker.Get(toAssign.Person);
            var apt = ABroker.Get(toAssign.ApartmentUnit);

            
            // Call Manager
            if(!HousingManagerLibrary.ValidatePerson(person) || !HousingManagerLibrary.ValidateApartmentUnit(apt))
            {
                return false;
            }

            var route = new ServiceBroker<Person>().GetRoute();
            route += "apartmentunit/";
            
            try
            {
                HttpClient client = new HttpClient();
                var content = new StringContent(JsonConvert.SerializeObject(toAssign), System.Text.Encoding.UTF8, "application/json");
                var response = client.PostAsync(route, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

                return false;
            }

            catch
            {
                return false;
            }

        }


        
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
