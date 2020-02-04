using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesData
{
    public static class Data
    {
        public static List<Employee> Employees = new List<Employee>()
        {
            new Employee(12354548, "Ivan", "Ivanov", "Ivanovich", 10),
            new Employee(45659754, "Cristiano", "Ronaldo", "Yuriyovich", 11),
            new Employee(13454898, "Lionel", "Messi", "Dmytrovich",7),
            new Employee(12354878, "Erica", "Hale", "Bogdanivna", 5),
            new Employee(78874542, "Megan", "Fox", "Ivanivna", 18)
        };
    }
}
