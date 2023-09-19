namespace EFConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            //var emp1 = new Employee { EmployeeName = "Mohammed", EmployeeAge = 24, Dept_ID = 9 };
            //var emp2 = new Employee { EmployeeName = "Ahmed", EmployeeAge = 26, Dept_ID = 10 };
            //var emp3 = new Employee { EmployeeName = "Said", EmployeeAge = 30, Dept_ID = 9 };

            //_context.Add(emp1);
            //_context.Add(emp2);
            //_context.Add(emp3);

            //Employee emp = _context.Employees.Where(y => y.Id == 1).FirstOrDefault();
            //emp.EmployeeName = "Matar";
            //_context.Update(emp);
            //_context.SaveChanges();
            //-------------------------------------------
            //var dept1 = new Department { name = "HR", description = "Human Resources Department"};
            //var dept2 = new Department { name = "IT", description = "Information Technology Department" };
            //var cor1 = new Course { Course_name = "Java", emp_Id= 6, Dept_ID = 9};
            //_context.Add(dept1);
            //_context.Add(dept2);
            //_context.Add(cor1);
            //_context.SaveChanges();
            double ageaverage = _context.Employees.Average(x => x.EmployeeAge);

            var employeees = _context.Employees.Where(x => x.EmployeeAge > 17)
                                         .ToList()
                                         .OrderBy(x => x.Id)
                                         .Skip(1)
                                         .Take(1);

            foreach (Employee emp in employeees)
            {
                Console.WriteLine($"employee name:{emp.EmployeeName} employee age:{emp.EmployeeAge}");
            }




            //Joins to get data from multile tables
            //var emps = _context.Employees
            //           .Join(_context.departments, Employee => Employee.Id, department => department.id,
            //                 (Employee, department) => new { EmpName = Employee.EmployeeName, EmpAge = Employee.EmployeeAge, DeptName = department.name }
            //           ).Where(x => x.EmpAge > 18);
            //foreach (var emp in emps)
            //{
            //    Console.WriteLine(emp.EmpName + emp.EmpAge + emp.DeptName);
            //}


            // var depts = _context.Departments.ToList().Take(2);
            //var depts = _context.Departments.ToList().Skip(1);
            //foreach (var dept in depts) 
            //{
            //    Console.WriteLine(dept.id+dept.name+dept.description);
            //}

        }
    }
}