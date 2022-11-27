using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4Exercise6
{
    internal class Company
    {
        private List<Department> _departments;

        public Company()
        {
            _departments = new List<Department>();
        }

        public Company(List<Department> departments) => _departments = departments;

        public void PrintDepartmentsList()
        {
            _departments.ForEach(x => Console.WriteLine(x.Name));
        }

        public void PrintEmployeeListForAllDepartments()
        {
            _departments.ForEach(x => x.PrintEmployees());
        }

        public void NumberOfEmployeesPerDepartment()
        {
            _departments.ForEach(x => Console.WriteLine(x.Name + ' ' + x.Employees.Count));
        }
    }
}
