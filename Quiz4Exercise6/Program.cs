using Quiz4Exercise6;
using System.Linq;

var randomNerd = new Employee("Bill", "Gates", 1, 10000);
var randomNerd2 = new Employee("Elon", "Musk", 3, 999);

var itDepartment = new Department("IT", 25);
var hrDepartment = new Department("HR", 5);

var company = new Company(new List<Department>() { itDepartment, hrDepartment});

itDepartment.AddInDepartment(randomNerd);
hrDepartment.AddInDepartment(randomNerd2);

itDepartment.PrintEmployees();
hrDepartment.PrintEmployees();

company.PrintDepartmentsList();
company.PrintEmployeeListForAllDepartments();
company.NumberOfEmployeesPerDepartment();   

