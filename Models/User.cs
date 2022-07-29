using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Device_Management_Web.Models
{
    public class User
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
    }
}