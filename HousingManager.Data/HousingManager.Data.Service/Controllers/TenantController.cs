using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HousingManager.Data.Library.Models;
using HousingManager.Data.Service.Interfaces;
using HousingManager.Data.Service.DAOs;
using HousingManager.Data.Service.DTOs;
using HousingManager.Data.Service.Mapper;

namespace HousingManager.Data.Service.Controllers
{
  [Produces("application/json")]
  [Route("api/Tenant")]
  public class TenantController : Controller
  {
    protected static HousingManagerDBContext _Context;
    private MyMapper _Mapper = new MyMapper();
    private IDataAccess<TenantInfo> _TenantData;

    public TenantController(HousingManagerDBContext context)
    {
      _Context = context;
      _TenantData = DataAccessEntityFactory.GetTenantDAO(_Context);
    }
    // GET: api/Tenant
    [HttpGet]
    public List<TenantDTO> Get()
    {
      var tenantdata = _TenantData.Read();
      var TenantDTOs = new List<TenantDTO>();
      foreach(var item in tenantdata)
      {
        TenantDTOs.Add(_Mapper.TenantEntitytoTenantDTO<TenantDTO>(item));
        TenantDTOs[TenantDTOs.Count -1].FirstName = item.Person.FirstName;
        TenantDTOs[TenantDTOs.Count - 1].LastName = item.Person.LastName;
        TenantDTOs[TenantDTOs.Count - 1].Batch = item.Batch.BatchType.Type;
      }
      return TenantDTOs;
    }

    // GET: api/Tenant/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST: api/Tenant
    [HttpPost]
    public void Post([FromBody]string value)
    {
    }

    // PUT: api/Tenant/5
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
