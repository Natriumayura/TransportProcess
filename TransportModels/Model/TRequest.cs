using System;
using System.Collections.Generic;
using System.Text;

namespace TransportDataAccess.Model
{
    public class TRequest
    {
        public int Id { get; set; }
        public int RequestBy { get; set; }
        public DateTime RequestedDate { get; set; }
        public DateTime NeededDateTime { get; set; }
        public DateTime ReturnDateTime { get; set; }
        public string RequestDescription { get; set; }
        public int RequestPurposeId { get; set; }
        public string CustomPurpose { get; set; }
        public int RequestApproveStatusId { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int UserId { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public int ModifiedUserId { get; set; }
        public User User { get; set; }
                                           //   public RequestApprovalStatus RequestApprovalStatus { get;set;}
    }
}
