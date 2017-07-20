using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HousingManager.Data.Service.Interfaces;
using HousingManager.Data.Library.EFModels;
using HousingManager.Data.Service.DAOs;
using HousingManager.Data.Service.DTOs;
using HousingManager.Data.Service.Mapper;

namespace HousingManager.Data.Service.Controllers
{
  [Produces("application/json")]
  [Route("api/Person")]
  public class PersonController : Controller
  {
    protected static HousingManager_DB_SqlServerContext _Context;
    private IDataAccess<Person> _PData;
    private MyMapper _Mapper = new MyMapper();

    public PersonController(HousingManager_DB_SqlServerContext context)
    {
      _Context = context;
      _PData = DataAccessEntityFactory.GetPersonDAO(_Context);
    }

    // GET: api/Person
    [HttpGet]
    public List<PersonDTO> Get()
    {
      var listofpeople = _PData.Read();
      var listofpersondto = new List<PersonDTO>();
      for (int i = 0; i < listofpeople.Count; i++)
      {
        listofpersondto.Add(_Mapper.PersonEntitytoPersonDTO<PersonDTO>(listofpeople[i]));
      }

      return listofpersondto;
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