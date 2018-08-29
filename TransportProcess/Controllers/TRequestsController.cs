using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransportDataAccess;
using TransportDataAccess.Model;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TransportProcess.Controllers
{
    [Route("api/[controller]")]
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
                _context.TRequest.Add(new TRequest {
                    CreatedDateTime = DateTime.Now,
                    CreatedUserId = 1,
                    CustomPurpose = "test",
                    ModifiedDateTime = DateTime.Now,
                    ModifiedUserId =1,
                    NeededDateTime = DateTime.Now,
                    RequestApproveStatusId =1,
                    RequestBy = 1,
                    RequestDescription = "test",
                    RequestedDate = DateTime.Now,
                    RequestPurposeId =1,
                    ReturnDateTime = DateTime.Now,
                    StatusId =1=
                    });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public List<TRequest> GetAll()
        {
            return _context.TRequest.ToList();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public TRequest GetById(long id)
        {
            var item = _context.TRequest.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }


        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
