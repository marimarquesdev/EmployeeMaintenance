using lab1_Version2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_Version2.BLL
{
    class Employee
    {
        private long employeeID;
        private string firstName;
        private string lastName;
        private string jobTitle;

        public long EmployeeID { get => employeeID; set => employeeID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }

        public void UpdateEmployee(Employee employee)
        {
            EmployeeDA.Update(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            EmployeeDA.DeleteRecord(employee);
        }
    }
}
