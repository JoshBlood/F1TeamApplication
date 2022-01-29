using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1TeamApplication.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string CurrentDrivers { get; set; }
        public string ConstructorsPlacing { get; set; }
        public string PrimaryColour { get; set; }
        public string FirstDriver { get; set; }
        public string SecondDriver { get; set; }


    }
}
