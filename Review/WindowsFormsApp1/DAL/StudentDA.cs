using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.BLL;
using System.Windows.Forms;

namespace WindowsFormsApp1.DAL
{
    class StudentDA
    {
        static string filePath = Application.StartupPath + @"\students.dat";
        /// <summary>
        /// This method save the student object data to the file.
        /// </summary>
        /// <param name="student"></param>
        public static void SaveRecord (Student student)
        {
            StreamWriter sw = new StreamWriter(filePath,true);
            sw.WriteLine(student.StudentId+", "+student.FirstName+", "+student.LastName);
            sw.Close();
        }
    }
}
