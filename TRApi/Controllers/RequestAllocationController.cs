using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransportDataAccess;
using Microsoft.EntityFrameworkCore;
using TransportDataAccess.Model;
using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TRApi.Controllers
{

    [EnableCors("MyPolicy")]
    [ApiController]
    public class RequestAllocationController : Controller
    {


        private readonly TransportContext _context;

        public RequestAllocationController(TransportContext transportContext)
        {
            _context = transportContext;
        }
        // GET: api/values
        //[HttpGet("api/RequestAllocation/GetAllRequestAllocations")]
        //public List<RequestAllocation> GetAllRequestAllocations()
        //{
        //    return _context.RequestAllocation.Include(req=>req.Request).Include(v=>v.Vehicle).Where(x => x.StatusId == 1).ToList();
        //}

        [HttpPost("api/RequestAllocation/CreateAllocation")]
        public void CreateAllocation(RequestAllocation requestAllocStr)
        {

            _context.RequestAllocation.Add(requestAllocStr);
            _context.SaveChanges();
        }

        [HttpGet("api/RequestAllocation/GetMyAllocatedRequest/{userId}")]
        public List<AllocatedReqs> GetMyAllocatedRequest(int userId)
        {
            return _context.AllocatedReqs.Where(x=>x.UserId == userId).ToList();
        }

     
    }
}
