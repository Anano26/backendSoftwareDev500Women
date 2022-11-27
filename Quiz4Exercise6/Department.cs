using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4Exercise6
{
    internal class Department
    {
        public string Name { get; set; }
        private int _maxEmployeeNumber;
        public List<Employee> Employees;

        public Department()
        {
            Name = "";
            _maxEmployeeNumber = 30;
            Employees= new List<Employee>();
        }
        
        public Department(string name, int maxEmployeeNumber)
        {
            Name = name;
            _maxEmployeeNumber = maxEmployeeNumber;
            Employees = new List<Employee>();
        }

        public bool AddInDepartment(Employee employee)
        {
            if (Employees.Count < _maxEmployeeNumber)
            {
                Employees.Add(employee);
                return true;
            }

            return false;
        }

        public bool DeleteFromDepartment(Employee employee)
        {
            if (Employees.Contains(employee))
            {
                Employees.Remove(employee);
                return true;
            }
            return false;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Department name: " + this.Name);
            Employees.ForEach(employee => Console.WriteLine(employee.FullName));
        }
    }
}
