using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test02.BLL
{
    class Employee : Person
    {
        int employeeId;
        string jobTitle;

        public Employee():base()
        {
            employeeId = 0;
            jobTitle = "";
        }

        public Employee(int employeeId, string firstName, string lastName, string jobTitle) : base(firstName, lastName)
        {
            this.employeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            this.jobTitle = jobTitle;
        }

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
    }
}
