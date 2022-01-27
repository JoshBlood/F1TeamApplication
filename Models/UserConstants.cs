using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1TeamApplication.Models
{
    public class UserConstants
    {
        public static List<User> Users = new List<User>()
        {
            new User() { UserId = 104, Username = "Josh", GivenName = "Josh", Surname = "Bloodworth", Email = "Josh@gmail.com",
                Role = "Admin", MobileNumber = 01234 },
        };
    }
}
