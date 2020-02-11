using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        #region Overrides
        public override string ToString()
        {
            return string.Format("ID = {0}, Name = {1}, Department = {2}", ID, Name, Department);
        }
        #endregion
    }
}
