using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EFC_02.Entities
{
    
    internal class Department
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        public int Ins_ID { get; set; }

        public DateTime HiringDate { get; set; }

        public List<Student> Students { get; set; } = new();
        public List<Instructor> Instructors { get; set; } = new();
    }
}
