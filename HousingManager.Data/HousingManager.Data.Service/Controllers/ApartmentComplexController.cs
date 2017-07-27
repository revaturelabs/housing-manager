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
  [Route("api/ApartmentComplex")]
  public class ApartmentComplexController : Controller
  {
    protected static HousingManagerDBContext _Context;
    private MyMapper _Mapper = new MyMapper();
    private IDataAccess<ApartmentComplex> _AptCpx;

    public ApartmentComplexController(HousingManagerDBContext context)
    {
      _Context = context;
      _AptCpx = DataAccessEntityFactory.GetApartmentComplexDAO(_Context);
    }

    // GET: api/ApartmentComplex
    [HttpGet]
    public List<ApartmentComplexDTO> Get()
    {
      var Apartments = _AptCpx.Read();
      var AptDTO = new List<ApartmentComplexDTO>();

      foreach(var item in Apartments)
      {
        AptDTO.Add(_Mapper.ApartmentComplexEntityToApartmentComplexDTO<ApartmentComplexDTO>(item));
        foreach (var thing in item.ApartmentUnit)
        {
          AptDTO[AptDTO.Count - 1].AptUnitDTO.Add(_Mapper.ApartmentUnitEntityToApartmentUnitDTO<ApartmentUnitDTO>(thing));
          AptDTO[AptDTO.Count - 1].AptUnitDTO[AptDTO[AptDTO.Count - 1].AptUnitDTO.Count - 1].Capacity = 6 - thing.TenantInfo.Count;
          AptDTO[AptDTO.Count - 1].AptUnitDTO[AptDTO[AptDTO.Count - 1].AptUnitDTO.Count - 1].Addr = _Mapper.AddressEntitytoAddressDTO<AddressDTO>(thing.Address);
         }
      }

      return AptDTO;
    }

    // GET: api/ApartmentComplex/5
    [HttpGet("{id}")]
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
