using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewTest1
{
    public class Employee:Person
    {
        private long employeeId;

        public Employee():base()
        {
            this.EmployeeId = 0;
        }

        public Employee(long employeeId, string fn, string ln):base(fn,ln)
        {
            this.EmployeeId = employeeId;
        }

        public long EmployeeId { get => employeeId; set => employeeId = value; }

        public List<Employee> ListEmployee()
        {
            return EmployeeDA.ListEmployee(); ;
        }
    }
}
