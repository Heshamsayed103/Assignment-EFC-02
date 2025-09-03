using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EFC_02.Entities
{
    internal class Topic
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; } = new();
    }
}
