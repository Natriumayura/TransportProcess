using System;
using System.Collections.Generic;
using System.Text;

namespace TransportDataAccess.Model
{
    public class Purpose
    {
        public int Id { get; set; }
        public int PurposeId { get; set; }
        public string PurposeDesc { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public int ModifiedUserId { get; set; }

    }
}
