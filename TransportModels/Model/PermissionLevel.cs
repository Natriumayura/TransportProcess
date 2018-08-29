﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TransportDataAccess.Model
{
    public class PermissionLevel
    {
        public int Id { get; set; }
        public int PermissionLevelId { get; set; }
        public string PermissionLevelDesc { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public int ModifiedUserId { get; set; }

    }
}
