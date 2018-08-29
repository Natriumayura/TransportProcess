using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransportDataAccess;
using TransportDataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TRApi.Controllers
{
  //  [Route("api/TRequests")]

    [EnableCors("MyPolicy")]
    [ApiController]
    public class TRequestsController : ControllerBase
    {

        private readonly TransportContext _context;
        public TRequestsController(TransportContext context)
        {
            _context = context;

            if (_context.TRequest.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.TRequest.Add(new TRequest
                {
                    CreatedDateTime = DateTime.Now,
                    UserId = 1,
                    CustomPurpose = "test",
                    ModifiedDateTime = DateTime.Now,
                    ModifiedUserId = 1,
                    NeededDateTime = DateTime.Now,
                    RequestApproveStatusId = 1,
                    RequestBy = 1,
                    RequestDescription = "test",
                    RequestedDate = DateTime.Now,
                    RequestPurposeId = 1,
                    ReturnDateTime = DateTime.Now,
                    StatusId = 1 
                    });
                _context.SaveChanges();
            }
        }

        [HttpGet(  "api/TRequests/GetAllRequests")]
        public ActionResult<List<TRequest>> GetAllRequests()
        {
            return _context.TRequest.Where(x => x.StatusId == 1).ToList();
        }

        [HttpGet("api/TRequests/GetRequestById/{id}",  Name = "GetTR")]
        public ActionResult<TRequest> GetRequestById(long id)
        {
            var item = _context.TRequest.Where(x => x.Id == id && x.StatusId==1).FirstOrDefault();
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpGet("api/TRequests/GetRequestByRequestStatusId/{id}")]
        public ActionResult<List<TRequest>> GetRequestByRequestStatusId(long id)
        {
            var items = _context.TRequest.Include(y=>y.User).Where(x => x.RequestApproveStatusId== id && x.StatusId==1).ToList();
            if (items == null)
            {
                return NotFound();
            }
            return items;
        }


        
        [HttpPost("api/TRequests/CreateRequest")]
        public void CreateRequest(TRequest requestStr)
        {
           
            _context.TRequest.Add(requestStr);
            _context.SaveChanges();
        }



        [HttpPut("api/TRequests/UpdateRequest/{id:long}/{reqStatusId:int}")]
        public IActionResult UpdateRequest(long id,int reqStatusId)
        {
            var tRequest = _context.TRequest.FirstOrDefault(x => x.Id == id && x.StatusId==1);
            if (tRequest == null)
            {
                return NotFound();
            }
            tRequest.RequestApproveStatusId = reqStatusId;

            _context.TRequest.Update(tRequest);
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("api/TRequests/DeleteRequest{id}")]
        public void DeleteRequest(int id)
        {
        }
    }
    public class abc
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
