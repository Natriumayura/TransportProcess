using System;
using System.Collections.Generic;
using System.Text;

namespace TransportDataAccess.Model
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int VehicleCategoryId { get; set; }
        public string VehicleNo { get; set; }
        public string DriverName { get; set; }
        public int DriverContactDetails { get; set; }
        public int DriverReference { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public int ModifiedUserId { get; set; }

    }
}
