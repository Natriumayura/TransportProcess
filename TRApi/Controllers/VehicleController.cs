using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransportDataAccess;
using TransportDataAccess.Model;
using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TRApi.Controllers
{
    [EnableCors("MyPolicy")]
    [ApiController]
    public class VehicleController : Controller
    {


        private readonly TransportContext _context;

        public VehicleController(TransportContext transportContext)
        {
            _context = transportContext;
        }
        // GET: api/values
        [HttpGet("api/Vehicle/GetAllVehicles")]
        public List<Vehicle> GetAllVehicles()
        {
            return _context.Vehicle.Where(x => x.StatusId == 1).ToList();
        }

        [HttpGet("api/Vehicle/GetAllVehiclesByCategory/{categotyId:int}")]
        public List<Vehicle> GetAllVehiclesByCategory(int categotyId)
        {
            return _context.Vehicle.Where(x => x.StatusId == 1 && x.VehicleCategoryId==categotyId).ToList();
        }

        [HttpGet("api/Vehicle/GetAllVehiclesByDriverReference/{reference:int}")]
        public List<Vehicle> GetAllVehiclesByDriverReference(int reference)
        {
            return _context.Vehicle.Where(x => x.StatusId == 1 && x.DriverReference == reference).ToList();
        }


        [HttpGet("api/Vehicle/GetVehiclesByVehicleNo/{vehicleNo}")]
        public List<Vehicle> GetVehiclesByVehicleNo(string vehicleNo)
        {
            return _context.Vehicle.Where(x => x.StatusId == 1 && x.VehicleNo == vehicleNo).ToList();
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
