using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
    public class Department
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }
        public string description { get; set; }

        public List<Employee> employees { get; set; }

        public List<Course> courses { get; set; }

    }
}
