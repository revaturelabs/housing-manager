using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HousingManager.Data.Service.Interfaces;
using HousingManager.Data.Library.Models;
using System.Net.Http;
using Newtonsoft.Json;
using HousingManager.Data.Service.DAOs;
using HousingManager.Data.Service.DTOs;
using HousingManager.Data.Service.Mapper;

namespace HousingManager.Data.Service.Controllers
{
  [Produces("application/json")]
  [Route("api/Address")]
  public class AddressController : Controller
  {
    protected static HousingManagerDBContext _Context;
    private IDataAccess<Address> _AdrData;
    private MyMapper _Mapper = new MyMapper();

    public AddressController(HousingManagerDBContext context)
    {
      _Context = context;
      _AdrData = DataAccessEntityFactory.GetAddressDAO(_Context);
    }
    // GET: api/Address
    [HttpGet]
    public List<AddressDTO> Get()
    {
      var listofaddresses = _AdrData.Read();
      var listofaddressdto = new List<AddressDTO>();

      for (int i = 0; i < listofaddresses.Count; i++)
      {
        listofaddressdto.Add(_Mapper.AddressEntitytoAddressDTO<AddressDTO>(listofaddresses[i]));
      }

      return listofaddressdto;
    }

    // GET: api/Address/5
    [HttpGet("{id}")]
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

    // PUT: api/Address/
    [HttpPut]
    public void Put([FromBody]Address adr)
    {
      throw new NotImplementedException();
    }

    // DELETE: api/ApiWithActions/
    [HttpDelete]
    public void Delete([FromBody]Address adr)
    {
      _AdrData.Delete(adr);
    }
  }
}
