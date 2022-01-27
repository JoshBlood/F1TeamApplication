using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1TeamApplication.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }    
        public string GivenName { get; set; }   
        public string Surname { get; set; }
        public string Email { get; set; }   
        public string Role { get; set; }
        public int MobileNumber { get; set; }
        public string Password { get; set; }
    }
}
