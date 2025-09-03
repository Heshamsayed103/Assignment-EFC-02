using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EFC_02.Entities
{
    internal class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_ID { get; set; }
        public Topic Topic { get; set; }
        public List<Stud_Course> Stud_Courses { get; set; } = new();
        public List<Course_Inst> Course_Instructors { get; set; } = new();
    }
}
