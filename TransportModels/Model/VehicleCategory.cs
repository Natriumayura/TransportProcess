﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TransportDataAccess.Model
{
    public class VehicleCategory
    {
        public int Id { get; set; }
        public int VehicleCategoryId { get; set; }
        public string VehicleCategoryDesc { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public int ModifiedUserId { get; set; }

    }
}
