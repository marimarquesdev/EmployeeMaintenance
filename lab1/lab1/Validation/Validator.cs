using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab1.BLL;
using lab1.DAL;

namespace lab1.Validation
{
    class Validator
    {
        static string filePath = Application.StartupPath + @"\employee.dat";
        public static bool IsValidId(string input, int size)
        {
            if (Regex.IsMatch(input,@"^\d{"+size+"}$"))
            {
                return true;
            }
            MessageBox.Show(input,"Error");
            return false;
        }

        public static bool IsValidName(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetter(input[i])&&(!char.IsWhiteSpace(input[i])))
                {
                 //   MessageBox.Show(textControl.Tag.ToString(), "Error");
                  //  textControl.Clear();
                  //  textControl.Focus();
                    return false; 
                }
            }
            return true;
        }

        public static bool IsDuplicatedId(int id)
        {
            //check if the file exists 
            if (File.Exists(filePath))
            {
                //create the object of type StreamReader
                StreamReader sr = new StreamReader(filePath);
                //read the first line
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (Convert.ToInt64(fields[0])==id)
                    {
                        sr.Close();
                        return true;
                    }
                    //read the next line
                    line = sr.ReadLine();
                }
                sr.Close();
                return false;
            }
            else
            {
                MessageBox.Show("File does not exit!");
            }

            return false; //Id is not duplicated
        }

       
    }
}
