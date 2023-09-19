using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
    public class Course
    {
        [Key]
        public int Course_id { get; set; }
        public string Course_name { get; set; }

        
        public Employee Employee { get; set; }

        [ForeignKey("Employee")]
        public int emp_Id { get; set; }
        public Department dept { get; set; }
        [ForeignKey("dept")]
        public int Dept_ID { get; set; }


    }
}
