using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Manager_V2
{
    public class Course
    {
        // Properties
        public string Number { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Semester { get; set; }
        public string Description { get; set; }
        public string Teacher { get; set; }

        // Constructors
        public Course()
        {
            Number = "";
            Name = "";
            Year = "";
            Semester = "";
            Description = "";
            Teacher = "";
        }
    }
}
