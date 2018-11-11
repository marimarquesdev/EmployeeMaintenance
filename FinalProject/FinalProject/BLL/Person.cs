using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BLL
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string gender;
        private string birthDate;
        private string maritalStatus;
        private string email;
        private string phone;
        private string streetAddress;
        private int apartmentNo;
        private string city;
        private string state;
        private string zipCode;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public string MaritalStatus { get => maritalStatus; set => maritalStatus = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string StreetAddress { get => streetAddress; set => streetAddress = value; }
        public int ApartmentNo { get => apartmentNo; set => apartmentNo = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }

        public Person(string firstName, string lastName, string gender, string birthDate, string maritalStatus, string email, string phone, string streetAddress, int apartmentNo, string city, string state, string zipCode)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.BirthDate = birthDate;
            this.MaritalStatus = maritalStatus;
            this.Email = email;
            this.Phone = phone;
            this.StreetAddress = streetAddress;
            this.ApartmentNo = apartmentNo;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
        }

        public Person()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Gender = "";
            this.BirthDate = "";
            this.MaritalStatus = "undefined";
            this.Email = "";
            this.Phone = "";
            this.StreetAddress = "";
            this.ApartmentNo = 0;
            this.City = "";
            this.State = "";
            this.ZipCode = "";
        }
    }
}
