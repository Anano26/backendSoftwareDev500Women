using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4Exercise6
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; } 
        public double Salary { get; set; } 
        public string FullName => Name + ' ' + Surname;

        public Employee()
        {

        }

        public Employee(string name, string surname, int id, double salary)
        {
            Name = name;
            Surname = surname;
            Id = id;
            Salary = salary;
        }

        public bool AddInDepartment(Department department)
        {
            return department.AddInDepartment(this);
        }

        public bool DeleteFromDepartment(Department department)
        {
            return department.DeleteFromDepartment(this);
        }
    }
}
