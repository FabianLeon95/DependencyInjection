using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    interface IEmployeeDAL
    {
        List<Employee> GetAllEmployees();
    }

    class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() { ID = 1, Name = "Pranaya", Department = "IT" });
            employees.Add(new Employee() { ID = 2, Name = "Kumar", Department = "HR" });
            employees.Add(new Employee() { ID = 3, Name = "Rout", Department = "Payroll" });

            return employees;
        }
    }
}
