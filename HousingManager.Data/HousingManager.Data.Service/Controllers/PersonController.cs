using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HousingManager.Data.Service.Interfaces;
using HousingManager.Data.Library.Models;
using HousingManager.Data.Service.DAOs;
using HousingManager.Data.Service.DTOs;
using HousingManager.Data.Service.Mapper;

namespace HousingManager.Data.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/Person")]
    public class PersonController : Controller
    {
        protected static HousingManagerDBContext _Context;
        private IDataAccess<Person> _PData;
        private MyMapper _Mapper = new MyMapper();

        public PersonController(HousingManagerDBContext context)
        {
            _Context = context;
            _PData = DataAccessEntityFactory.GetPersonDAO(_Context);
        }

        [HttpGet(Name = "GetAll", Order = 2)]
        [Route("GetAll")]
        public List<PersonDTO> Get( )
        {
            var listofpeople = _PData.Read();
            var listofpersondto = new List<PersonDTO>();
            for (int i = 0; i < listofpeople.Count; i++)
            {
                listofpersondto.Add(_Mapper.PersonEntitytoPersonDTO<PersonDTO>(listofpeople[i]));
            }

            return listofpersondto;
        }

        //[HttpGet("{first}, {last}", Name ="GetName", Order =0)]
        [Route("{first}/{last}")]
        public PersonDTO Get(string first, string last)
        {
            Person lookup = new Person();
            lookup.FirstName = first;
            lookup.LastName = last;

            return _Mapper.PersonEntitytoPersonDTO<PersonDTO>(_PData.Get(lookup));
        }

        [HttpPost]
        public void Post([FromBody]Person per)
        {
            _PData.Create(per);
        }

        [HttpPut]
        public void Put([FromBody]Person per)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public void Delete([FromBody]Person per)
        {
            _PData.Delete(per);
        }
    }
}