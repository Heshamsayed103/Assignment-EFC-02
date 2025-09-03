using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Entities
{
    // Model  - Entity
    internal class Employee
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Salary { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        //public Department? department { get; set; }
        public Department? WorkFor { get; set; }
        //public int WorkForId { get; set; }


    }
}
