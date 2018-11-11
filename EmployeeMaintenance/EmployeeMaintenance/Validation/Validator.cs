using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMaintenance.Validation
{
    static class Validator
    {
        static string filePath = Application.StartupPath + @"/employee.txt";
        public static bool IsValidId(string input, int size)
        {
            if (Regex.IsMatch(input, @"^\d{" + size + "}$"))
            {
                return true;
            }

            MessageBox.Show("Invalid employee number!", "Error");
            return false;
        }

        public static bool IdExist(int empNumber)
        {
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                if (empNumber == Convert.ToInt32(fields[0]))
                {
                    MessageBox.Show("Employee number already exists!","Error");
                    sr.Close();
                    return false;
                }
                line = sr.ReadLine();
            }
            sr.Close();
            return true;
        }

        public static bool IsEmailValid(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Email is invalid!","Error");
                return false;
            }
        }

        public static bool IsValidName(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]) && Char.IsWhiteSpace(input[i]))
                {
                    MessageBox.Show("Invalid Last Name e/or First Name");
                    return false;
                }
            }
            
            return true;
        }
    }
}
