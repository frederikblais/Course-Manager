using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Manager_V2
{
    public class Online:Course
    {
        // Properties
        public string Link { get; set; }
        public string Pass { get; set; }
        public string YT { get; set; }

        // Constructors
        public Online()
        {
            Link = "";
            Pass = "";
            YT = "";
        }
    }
}
