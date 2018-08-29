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
    public class UserController : ControllerBase
    {

        private readonly TransportContext _context;


        public UserController(TransportContext transportContext)
        {
            _context = transportContext;
        }
        // GET: api/values
        [HttpGet("api/User/GetAllUsers")]
        public List<User> GetAllUsers()
        {
            return _context.User.Where(x => x.StatusId == 1).ToList();
        }

        [HttpGet("api/User/GetUserByUserName/{username}")]
        public User GetUserByUserName(string username)
        {
            return _context.User.FirstOrDefault(x => x.Username.ToLower().Equals(username.ToLower()));
        }

    }
}
