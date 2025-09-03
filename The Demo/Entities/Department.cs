using EF_02.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.Entities
{
    internal class Department
    {
        public int Id { get; set; }


        public string DeptName { get; set; }

        //[ForeignKey(nameof(Department.manager))]
        //public int EmployeeId { get; set; }

        //public Employee manager { get; set; } //Navigitional Proparty 
        public List<Employee> employee { get; set; }



    }
}
