using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HousingManager.Data.Service.Interfaces;
using HousingManager.Data.Library.EFModels;
using HousingManager.Data.Service.DAOs;

namespace HousingManager.Data.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/Person")]
    public class PersonController : Controller
    {
        private IDataAccess<Person> _PData = DataAccessEntityFactory.GetPersonDAO();

        // GET: api/Person
        [HttpGet]
        public List<Person> Get()
        {
            return _PData.Read();
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
            _PData.Create(per);
        }

        // PUT: api/Person/
        [HttpPut]
        public void Put([FromBody]Person per)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Person/
        [HttpDelete]
        public void Delete([FromBody]Person per)
        {
            _PData.Delete(per);
        }
    }
}