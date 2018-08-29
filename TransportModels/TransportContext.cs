using Microsoft.EntityFrameworkCore;
using TransportDataAccess.Model;

namespace TransportDataAccess
{
    public class TransportContext : DbContext
    {
        public TransportContext(DbContextOptions<TransportContext> options)
            : base(options)
        {
        }

        public DbSet<TRequest> TRequest { get; set; }
        public DbSet<RequestApprovalStatus> RequestApprovalStatus { get; set; }
        public DbSet<Purpose> Purpose { get; set; }
        public DbSet<VehicleCategory> VehicleCategory { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<RequestAllocation> RequestAllocation { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<PermissionLevel> PermissionLevel { get; set; }
        public DbSet<UserPermissionLevelAllocation> UserPermissionLevelAllocation { get; set; }
    }
}