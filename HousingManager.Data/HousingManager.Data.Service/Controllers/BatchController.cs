using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HousingManager.Data.Service.DTOs;
using HousingManager.Data.Library.Models;
using HousingManager.Data.Service.DAOs;
using HousingManager.Data.Service.Interfaces;
using HousingManager.Data.Service.Mapper;

namespace HousingManager.Data.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/Batch")]
    public class BatchController : Controller
    {
    protected static HousingManagerDBContext _Context;
    private IDataAccess<Batch> _BData;
    private MyMapper _Mapper = new MyMapper();
    public BatchController(HousingManagerDBContext context)
        
    {
      _Context = context;
      _BData = DataAccessEntityFactory.GetBatchDAO(_Context);
    }

    // GET: api/Batch
    [HttpGet]
        public List<BatchDTO> Get()
        {
          var bd = _BData.Read();
      var listofbatchdto = new List<BatchDTO>();
      for (int i = 0; i < bd.Count; i++)
      {
        listofbatchdto.Add(_Mapper.BatchEntitytoBatchDTO<BatchDTO>(bd[i]));
        listofbatchdto[i].BatchType = (_Context.Batch.Where(b => b.Guid == listofbatchdto[i].Guid).FirstOrDefault()).BatchType.Type + " " + listofbatchdto[i].StarDate.ToString().Substring(0, 9);
      }

      return listofbatchdto;
    }

        // GET: api/Batch/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Batch
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Batch/5
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
