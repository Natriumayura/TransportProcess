using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransportDataAccess;
using Microsoft.EntityFrameworkCore;
using TransportDataAccess.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TRApi.Controllers
{ 
    public class RequestAllocationController : Controller
    {


        private readonly TransportContext _context;

        public RequestAllocationController(TransportContext transportContext)
        {
            _context = transportContext;
        }
        // GET: api/values
        [HttpGet("api/RequestAllocation/GetAllRequestAllocations")]
        public List<RequestAllocation> GetAllRequestAllocations()
        {
            return _context.RequestAllocation.Include(req=>req.Request).Include(v=>v.Vehicle).Where(x => x.StatusId == 1).ToList();
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
