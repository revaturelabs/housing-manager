using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HousingManager.Data.Service.Interfaces;
using HousingManager.Data.Library.EFModels;
using System.Net.Http;
using Newtonsoft.Json;
using HousingManager.Data.Service.DAOs;

namespace HousingManager.Data.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/Address")]
    public class AddressController : Controller
    {
        private IDataAccess<Address> _AdrData = DataAccessEntityFactory.GetAddressDAO();

        // GET: api/Address
        [HttpGet]
        public List<Address> Get()
        {
            return _AdrData.Read();
            //var res = new HttpResponseMessage();
            //try
            //{
            //    var aList = _AdrData.Read();
            //    if (aList.Count > 0)
            //    {
            //        res.Content = new StringContent(JsonConvert.SerializeObject(aList), System.Text.Encoding.UTF8, "application/json");
            //        res.StatusCode = System.Net.HttpStatusCode.OK;
            //    }
            //    else
            //    {
            //        res.StatusCode = System.Net.HttpStatusCode.NoContent;
            //    }
            //}
            //catch
            //{
            //    res.StatusCode = System.Net.HttpStatusCode.InternalServerError;
            //    return res;
            //}
            //return res;
        }

        // GET: api/Address/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Address
        [HttpPost]
        public void Post([FromBody]Address adr)
        {
            _AdrData.Create(adr);
        }
        
        // PUT: api/Address/5
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
