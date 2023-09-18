namespace EFConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            //var emp1 = new Employee { EmployeeName = "Mohammed", EmployeeAge = 24 };
            //var emp2 = new Employee { EmployeeName = "Ahmed", EmployeeAge = 26 };
            //var emp3 = new Employee { EmployeeName = "Said", EmployeeAge = 30 };

            //_context.Add(emp1);
            //_context.Add(emp2);
            //_context.Add(emp3);

            Employee emp = _context.Employees.Where(y => y.Id == 1).FirstOrDefault();
            emp.EmployeeName = "Matar";
            _context.Update(emp);
            _context.SaveChanges();

        }
    }
}