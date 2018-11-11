using ReviewMidleTermExam.DAL;
using ReviewMidleTermExam.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewMidleTermExam.BLL
{
    class Employee
    {
        int employeeId;
        string firstName;
        string lastName;
        string jobTitle;

        public Employee()
        {
            employeeId = 0;
            firstName = "";
            lastName = "";
            jobTitle = "";
        }

        public Employee(int empId, string fn, string ln, string jt)
        {
            employeeId = empId;
            firstName = fn;
            lastName = ln;
            jobTitle = jt;
        }

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }

        public void CreateEmployee(Employee emp)
        {
            EmployeeDA.Create(emp);
        }

        public List<Employee> List()
        {
            return EmployeeDA.List();
        }

        public Employee SearchById(int empId)
        {
            return EmployeeDA.SearchById(empId);
        }

        public List<Employee> SearchByFName(string fn)
        {
            return EmployeeDA.SearchByFName(fn);
        }

        public bool IdExist(int empId)
        {
            return EmployeeDA.IdExist(empId);
        }
        public bool IsValidId(string input, int size)
        {
            return Validator.IsValidId(input, size);
        }
        public bool IsValidName(string input)
        {
            return Validator.IsValidName(input);
        }
    }
}
