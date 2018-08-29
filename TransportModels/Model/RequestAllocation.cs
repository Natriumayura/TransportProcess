using System;
using System.Collections.Generic;
using System.Text;

namespace TransportDataAccess.Model
{
    public  class RequestAllocation
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int VehicleId { get; set; }
        public int StatusId { get; set; }
        public bool IsJourneyCompleted { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public int ModifiedUserId { get; set; }
        public Vehicle Vehicle { get; set; }
        public TRequest Request { get; set; }
    }
}
