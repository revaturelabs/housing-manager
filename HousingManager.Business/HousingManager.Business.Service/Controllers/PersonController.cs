using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HousingManager.Business.Service.Brokers;
using HousingManager.Business.Library.Models;

namespace HousingManager.Business.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/Person")]
    public class PersonController : Controller
    {
        
        ServiceBroker<Person>_broker = BrokerFactory<Person>.GetInstance();

        // GET: api/Person
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _broker.TestGet();
        }

        // GET: api/Person/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Person
        [HttpPost]
        public void Post([FromBody]Person per)
        {
            //_broker.Add(per);
        }
        
        // PUT: api/Person/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
