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
        public ApartmentComplex Get()
        {
            return _broker.Get();
        }


        [HttpGet]
        public IEnumerable<ApartmentComplex> GetAll()
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