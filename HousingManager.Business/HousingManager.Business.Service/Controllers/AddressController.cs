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
    [Route("api/Address")]
    public class AddressController : Controller
    {
        ServiceBroker<Address> _broker = BrokerFactory<Address>.GetInstance();

        [HttpGet(Name ="GetAll", Order = 3)]
        public IEnumerable<Address> Get()
        {
            return _broker.GetAll();
        }

        [HttpGet("{id}", Name = "Get", Order = 2)]
        public Address Get(int id)
        {
            return _broker.Get(id);
        }

        [HttpGet(Name ="GetGuid", Order =1)]
        
        [HttpPost]
        public void Post([FromBody]Address value)
        {
            _broker.Add(value);
        }
        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {

        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
