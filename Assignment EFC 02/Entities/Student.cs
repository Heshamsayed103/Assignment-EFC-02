using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EFC_02.Entities
{
    internal class Student
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string FName { get; set; }

        [Required, MaxLength(50)]
        public string LName { get; set; }

        public string Address { get; set; }

        [Range(18, 100)]
        public int Age { get; set; }

        [ForeignKey("Department")]
        public int Dep_Id { get; set; }

        public Department Department { get; set; }
        public List<Stud_Course> Stud_Courses { get; set; } = new();
    }
}

