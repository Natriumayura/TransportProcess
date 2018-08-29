using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransportDataAccess;
using TransportDataAccess.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TRApi.Controllers
{

    public class PermissionLevelController : ControllerBase
    {
        // GET: api/values
        private readonly TransportContext _context;

        public PermissionLevelController(TransportContext transportContext)
        {
            _context = transportContext;
        }
        [HttpGet("api/PermissionLevel/GetAllPermissionLevels")]
        public List<PermissionLevel> Get()
        {
            return _context.PermissionLevel.Where(x => x.StatusId == 1).ToList();
        }

    }
}
