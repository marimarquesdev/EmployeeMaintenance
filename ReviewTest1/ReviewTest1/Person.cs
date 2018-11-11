using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewTest1
{
    public class Person
    {
        string firstName;
        string lastName;

        public Person()
        {
            this.firstName = "";
            this.lastName = "";
        }
        public Person(string fn, string ln)
        {
            firstName = fn;
            lastName = ln;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
