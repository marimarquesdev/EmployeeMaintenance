using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewMidleTermExam.Validation
{
    static class Validator
    {
        public static bool IsValidId(string input, int size)
        {
            if (Regex.IsMatch(input, @"^\d{" + size +"}$"))
            {
                return true;
            }

            MessageBox.Show("Invalid employeeId!","Error");
            return false;
        }

        public static bool IsValidName(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i])&& Char.IsWhiteSpace(input[i]))
                {
                    MessageBox.Show("Invalid First Name e/or Last Name");
                    return false;
                }
            }
            return true;
        }
    }
}
