using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesData
{
    public class Employee
    {
        private string _employeeFirstName;
        public string EmployeeFirstName { get => _employeeFirstName; set => _employeeFirstName = value; }

        private string _employeeLastName;
        public string EmployeeLastName { get => _employeeLastName; set => _employeeLastName = value; }

        private string _employeeFathersName;
        public string EmployeeFathersName { get => _employeeFathersName; set => _employeeFathersName = value; }

        private long _employeeID;
        public long EmployeeID { get => _employeeID; set => _employeeID = value; }

        private decimal _employeeSalaryPerHour;
        public decimal SalaryPerHour { get => _employeeSalaryPerHour; set => _employeeSalaryPerHour = value; }

        public Employee() {}
        public Employee(long id, string fname, string lname, string Fname, decimal s)
        {
            _employeeID = id;
            _employeeFirstName = fname;
            _employeeLastName = lname;
            _employeeFathersName = Fname;
            _employeeSalaryPerHour = s;
        }

        public override string ToString()
        {
            return $"ID:{_employeeID} | First Name:{_employeeFirstName} | Last Name:{_employeeLastName} | Father`s Name:{_employeeFathersName} | Salary:{_employeeSalaryPerHour}";
        }

    }
}
