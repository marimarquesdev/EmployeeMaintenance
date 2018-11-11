using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
   public class Student
    {
        //class fields
        private int studentId;
        private string firstName;
        private string lastName;
             

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int StudentId { get => studentId; set => studentId = value; }

        //methods
        public void SaveStudent(Student aStudent)
        {
            StudentDA.SaveRecord(aStudent);
        }
    }
}
