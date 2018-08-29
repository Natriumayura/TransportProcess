using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransportDataAccess.Model;
using TransportDataAccess;
using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TRApi.Controllers
{
    [EnableCors("MyPolicy")]
    public class PurposeController : ControllerBase
    {

        private readonly TransportContext _context;

        public PurposeController(TransportContext transportContext)
        {
            _context = transportContext;
        }
        // GET: api/values
        [HttpGet("api/Purpose/GetAllPurposes")]
        public List<Purpose> GetAllPurposes()
        {
            return _context.Purpose.Where(x=>x.StatusId==1).ToList();
        }

    }
}
