using System;
using System.Collections.Generic;
using System.Text;

namespace TransportDataAccess.Model
{
    public class AllocatedReqs
    {
        public int Id { get; set; }
        public DateTime RequestedDate { get; set; }
        public DateTime NeededDateTime { get; set; }
        public DateTime ReturnDateTime { get; set; }
        public string ApprovalStatus { get; set; }
        public string CustomPurpose { get; set; }
        public string VehicleNo { get; set; }
        public string RequestedUser { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int UserId { get; set; }
        public string VehicleCategoryDesc { get; set; }
    }
}
