using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMaintenance.Business
{
    class Person
    {
        string lastName;
        string firstName;
        string phoneNumber;
        string email;

        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }

        public Person()
        {
           lastName = "";
           firstName = "";
           phoneNumber = "";
           email = "";
        }

        public Person(string lastName, string firstName, string phoneNumber, string email)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public virtual string Information()
        {
            return FirstName + " " + LastName;
        }
    }
}
