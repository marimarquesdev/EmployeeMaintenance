using FinalProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BLL
{
    class Employee : Person
    {
        long employeeId;
        string jobTitle;
        DateTime startDate;
        string departmentName;
        double salary;

        public Employee()
        {
        }

        public Employee(long employeeId, string jobTitle, DateTime startDate, string departmentName, double salary)
        {
            this.employeeId = employeeId;
            this.jobTitle = jobTitle;
            this.startDate = startDate;
            this.departmentName = departmentName;
            this.salary = salary;
        }

        public long EmployeeId { get => employeeId; set => employeeId = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }
        public double Salary { get => salary; set => salary = value; }

        public void SaveEmployee(Employee employee)
        {
            EmployeeDA.Save(employee);
        }
    }
}
