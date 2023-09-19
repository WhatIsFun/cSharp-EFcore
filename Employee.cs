using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }

        public int EmployeeAge { get; set; }

        public Department department { get; set; }

        [ForeignKey("department")]
        public int Dept_ID { get; set; }
        public Course course { get; set; }

    }
}
