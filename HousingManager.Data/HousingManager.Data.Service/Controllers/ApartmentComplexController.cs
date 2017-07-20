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
  [Route("api/ApartmentComplex")]
  public class ApartmentComplexController : Controller
  {
    protected static HousingManager_DB_SqlServerContext _Context;
    private IDataAccess<ApartmentComplex> _AptCpx;

    public ApartmentComplexController(HousingManager_DB_SqlServerContext context)
    {
      _Context = context;
      _AptCpx = DataAccessEntityFactory.GetApartmentComplexDAO(_Context);
    }

    // GET: api/ApartmentComplex
    [HttpGet]
    public List<ApartmentComplex> Get()
    {
      return _AptCpx.Read();
    }

    // GET: api/ApartmentComplex/5
    [HttpGet("{id}", Name = "Get")]
    public string Get(int id)
    {
      return "value";
    }

    // POST: api/ApartmentComplex
    [HttpPost]
    public void Post([FromBody]ApartmentComplex aptcpx)
    {
      _AptCpx.Create(aptcpx);
    }

    // PUT: api/ApartmentComplex/5
    [HttpPut("{id}")]
    public void Put([FromBody]ApartmentComplex aptcpx)
    {
      throw new NotImplementedException();
    }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      throw new NotImplementedException();
    }
  }
}
