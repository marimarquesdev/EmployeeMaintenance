using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BLL
{
    class Author:Person
    {
        int authorId;

        public Author():base()
        {
            AuthorId = 0;
        }

        public Author(int authorId, string firstName, string lastName, string gender, string birthDate, string maritalStatus, string email, string phone, string streetAddress, int apartmentNo, string city, string state, string zipCode) :base(firstName, lastName, gender, birthDate, maritalStatus, email, phone, streetAddress, apartmentNo, city, state, zipCode)
        {
            this.AuthorId = authorId;
        }

        public int AuthorId { get => authorId; set => authorId = value; }
    }
}
