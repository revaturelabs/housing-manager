using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HousingManager.Business.Library.Models;

namespace HousingManager.Business.Service.Brokers
{
    public class ApartmentComplexController : Controller
    {
        ApartmentComplexBroker _broker = new ApartmentComplexBroker();

        [HttpGet]
        public IEnumerable<ApartmentComplex> Get()
        {
            return _broker.GetAll();    
        }


        
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }
        
        public void Delete()
        {

        }
    }
}