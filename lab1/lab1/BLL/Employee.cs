using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.BLL
{
    class Employee
    {
        private double employeeNumber;
        private string firstName;
        private string lastName;
        private string jobTitle;

        public double EmployeeNumber { get => employeeNumber; set => employeeNumber = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
    }
}
