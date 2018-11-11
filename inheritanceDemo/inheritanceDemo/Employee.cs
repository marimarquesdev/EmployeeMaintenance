using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceDemo
{
    public class Employee:Person
    {
        private int employeeId;

        public int EmployeeId { get => employeeId; set => employeeId = value; }

        public Employee():base()
        {
            employeeId = 0;
        }

        public Employee(int employeeId, string fn, string ln) : base(fn, ln)
        {
            this.employeeId = employeeId;
        }
        public override string getName()
        {
            return employeeId + " - "+ base.getName();
        }
    }
}
