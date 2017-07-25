using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HousingManager.Business.Library.Models;

namespace HousingManager.Business.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/ContactInfo")]
    public class ContactInfoController : Controller
    {
        [HttpGet(Name ="GetGuid", Order =1)]
        public ContactInfo Get(Guid personGuid)
        {
            ContactInfo data = new ContactInfo();
            

            return null;
        }
    }
}