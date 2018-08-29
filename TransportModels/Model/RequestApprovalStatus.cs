using System;
using System.Collections.Generic;
using System.Text;

namespace TransportDataAccess.Model
{
    public class RequestApprovalStatus
    {
        public int Id { get; set; }
        public int RequestApprovalStatusId { get; set; }
        public string ApprovalStatus { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedUserid { get; set; }

    }
}
