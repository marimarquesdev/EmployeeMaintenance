using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test02.BLL
{
    class Person
    {
        string firstName;
        string lastName;

        public Person()
        {
            FirstName = "";
            lastName = "";
        }

        public Person(string fn, string ln)
        {
            FirstName = fn;
            lastName = ln;
        }

        public string FirstName{ get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
       
    }
}
