using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Manager_V2
{
    public class InClass:Course
    {
        // Properties
        public string ClassRoom;
        public string Hours;
        public string Finals;
        public string TeacherOffice;

        // Constuctor
        public InClass()
        {
            ClassRoom = "";
            Hours = "";
            Finals = "";
            TeacherOffice = "";
        }
    }
}
