using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_Version2.Validation
{
    class Validator
    {

        public static bool IsValidId(string input, int size)
        {
            if (Regex.IsMatch(input, @"^\d{" + size + "}$"))
            {
                return true;
            }

            MessageBox.Show("Invalid Student Id", "Error");
            return false;


        }

        public static bool IsValidId(TextBox txtControl, int size)
        {
            if (Regex.IsMatch(txtControl.Text, @"^\d{" + size + "}$"))
            {
                return true;
            }

            MessageBox.Show(txtControl.Tag.ToString(), "Error");
            return false;


        }

        public static bool IsValidId(string input)
        {
            if (Regex.IsMatch(input, @"^\d{7}$"))
            {
                return true;
            }
            return false;

        }

        public static bool IsValidName(string input, String targetName)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsLetter(input[i]) && (!Char.IsWhiteSpace(input[i])))
                {
                    MessageBox.Show("Invalid " + targetName, "Error");
                    return false;
                }

            }
            return true;

        }

        public static bool IsValidName(string input, TextBox txtControl)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsLetter(input[i]) && (!Char.IsWhiteSpace(input[i])))
                {
                    MessageBox.Show("Invalid " + txtControl.Tag + "Confirmation");
                    txtControl.Clear();
                    txtControl.Focus();
                    return false;
                }

            }
            return true;

        }
    }
}
