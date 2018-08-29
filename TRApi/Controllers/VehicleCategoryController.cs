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

    public class VehicleCategoryController : ControllerBase
    {
        private readonly TransportContext _context;

        public VehicleCategoryController(TransportContext transportContext)
        {
            _context = transportContext;
        }
        // GET: api/values
        [HttpGet("api/ VehicleCategory/GetAllVehicleCategories")]
        public List<VehicleCategory> GetAllVehicleCategories()
        {
            return _context.VehicleCategory.Where(x => x.StatusId == 1).ToList();   
        }
    }
}
