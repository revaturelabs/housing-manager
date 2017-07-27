using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HousingManager.Data.Library.Models;
using HousingManager.Data.Service.Mapper;
using HousingManager.Data.Service.Interfaces;
using HousingManager.Data.Service.DAOs;
using HousingManager.Data.Service.DTOs;

namespace HousingManager.Data.Service.Controllers
{
  [Produces("application/json")]
  [Route("api/ApartmentUnit")]
  public class ApartmentUnitController : Controller
  {
    protected static HousingManagerDBContext _Context;
    private MyMapper _Mapper = new MyMapper();
    private IDataAccess<TenantInfo> _ApartmentUnitData;

    public ApartmentUnitController(HousingManagerDBContext context)
    {
      _Context = context;
      _ApartmentUnitData = DataAccessEntityFactory.GetApartmentUnitDAO(_Context);
    }
    // GET: api/ApartmentUnit
    [HttpGet]
    public List<TenantDTO> Get()
    {
      var units = _ApartmentUnitData.Read();
      var tad = new List<TenantDTO>();
      
      foreach(var item in units)
      {
        tad.Add(_Mapper.TenantEntitytoTenantDTO<TenantDTO>(item));
        tad[tad.Count - 1].FirstName = item.Person.FirstName;
        tad[tad.Count - 1].LastName = item.Person.LastName;
        tad[tad.Count - 1].ApartmentComplexName = item.ApartmentUnit.ApartmentComplex.ApartmentName;
        tad[tad.Count - 1].Capacity = 6 - item.ApartmentUnit.TenantInfo.Count;
        tad[tad.Count - 1].Address = _Mapper.AddressEntitytoAddressDTO<AddressDTO>(item.ApartmentUnit.Address);
      }

      return tad;
    }

    // GET: api/ApartmentUnit/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST: api/ApartmentUnit
    [HttpPost]
    public void Post([FromBody]PersonBatchDTO pbDTO)
    {
      var myTenantInfo = new TenantInfo();

      myTenantInfo.ApartmentUnitId = _Context.ApartmentUnit.Where(b => b.Guid == pbDTO.ApartmentGuid).FirstOrDefault().ApartmentUnitId;
      myTenantInfo.PersonId = _Context.Person.Where(p => p.Guid == pbDTO.PersonGuid).FirstOrDefault().PersonId;
      myTenantInfo.Gender = "Male";
      myTenantInfo.MoveOutDate = DateTime.Now;
      myTenantInfo.MoveInDate = DateTime.Now;
      myTenantInfo.BatchId = 3;
      
      _ApartmentUnitData.Create(myTenantInfo);
    }

    // PUT: api/ApartmentUnit/5
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
