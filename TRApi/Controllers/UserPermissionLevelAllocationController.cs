using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransportDataAccess.Model;
using TransportDataAccess;
using Microsoft.EntityFrameworkCore;
using TRApi.Extra;
using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TRApi.Controllers
{
    [EnableCors("MyPolicy")]
    public class UserPermissionLevelAllocationController : ControllerBase
    {
        private readonly TransportContext _context;


        public UserPermissionLevelAllocationController(TransportContext transportContext)
        {
            _context = transportContext;
        }
        // GET: api/values
        [HttpGet("api/UserPermissionLevelAllocation/GetAllPermissionAllocations")]
        public List<UserPermissionLevelAllocation> GetAllPermissionAllocations()
        {
            return _context.UserPermissionLevelAllocation.Include(x => x.PermissionLevel).Include(y => y.User).Where(z => z.StatusId == 1).ToList();
        }

        [HttpGet("api/UserPermissionLevelAllocation/GetPermissionAllocationsByUserName/{username}")]
        public List<UserPermissionLevelAllocation> GetPermissionAllocationsByUserName(string username)
        {
            var permissionLevels = _context.UserPermissionLevelAllocation.Include(x => x.PermissionLevel).Include(y => y.User).Where(z => z.StatusId == 1 && z.User.Username.ToLower().Equals(username)).ToList();
            if (permissionLevels.Count > 0)
            {
                return permissionLevels;
            }
            else
            {
                return _context.UserPermissionLevelAllocation.Include(x => x.PermissionLevel).Include(y => y.User).Where(z => z.StatusId == 1 && z.User.Username.Equals(Params.defUser)).ToList();
            }
        }


    }
}
