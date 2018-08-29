using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransportDataAccess.Model;
using TransportDataAccess;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TRApi.Controllers
{
    //[Route("api/[controller]")]
    public class ApprovalStatusController : Controller
    {
        private readonly TransportContext _context;

        public ApprovalStatusController(TransportContext transportContext)
        {
            _context = transportContext;
        }

        // GET: api/values
        [HttpGet("api/ApprovalStatus/GetAllStatuses")]
        public List<RequestApprovalStatus> GetAllStatuses()
        {
            return _context.RequestApprovalStatus.Where(x => x.StatusId == 1).ToList();
        }
    }
}
