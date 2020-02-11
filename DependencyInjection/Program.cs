using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());
            var employees = employeeBL.GetEmployeesByDepartment("IT");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }

            Console.ReadKey();
        }
    }
}
