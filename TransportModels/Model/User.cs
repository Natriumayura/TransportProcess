using System;
using System.Collections.Generic;
using System.Text;

namespace TransportDataAccess.Model
{
    public class User
    {
        public int UserId { get; set; }
        public int Id { get; set; }
       
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public int ModifiedUserId { get; set; }

    }
}
