using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceDemo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string v;
        private string ln1;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public Person()
        {
            firstName = "";
            lastName = "";
        }
        public Person(string fn, string ln)
        {
           firstName = fn;
           lastName = ln;
        }

        public Person(string fn, string ln, string v, string ln1) : this(fn, ln)
        {
            this.v = v;
            this.ln1 = ln1;
        }

        public virtual String getName()
        {
            return FirstName + " " + LastName;

        }
    }
}
