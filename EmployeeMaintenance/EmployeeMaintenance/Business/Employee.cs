using EmployeeMaintenance.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMaintenance.Business
{
    class Employee : Person
    {
        int empNumber;

        public int EmpNumber { get => empNumber; set => empNumber = value; }

        public Employee(): base()
        {
            empNumber = 0;
        }

        public Employee(int empNumber, string lastName, string firstName, string phoneNumber, string email) : base(lastName, firstName, phoneNumber, email)
        {
            this.empNumber = empNumber;
            LastName = lastName;
            FirstName = firstName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public void Create(Employee employee)
        {
            EmployeeDA.Create(employee);
        }

        public Employee SearchByEmpNumber(int empNumber)
        {
            return EmployeeDA.SearchByEmpNumber(empNumber);
        }

        public List<Employee> SearchByFName(string firtName)
        {
            return EmployeeDA.SearchByFName(firtName);
        }

        public List<Employee> Display()
        {
            return EmployeeDA.Display();
        }
		
		public override string Information(){
			return empNumber + " "+FirstName + " "+LastName;
		}
    }
}
