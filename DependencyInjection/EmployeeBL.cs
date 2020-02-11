using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class EmployeeBL
    {
        private IEmployeeDAL _employeeDAL;

        public EmployeeBL(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeDAL.GetAllEmployees();
        }

        public List<Employee> GetEmployeesByDepartment(string department)
        {
            return _employeeDAL.GetAllEmployees().Where(e => e.Department == department).ToList();
        }
    }
}
