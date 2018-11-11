using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Validation
{
    public static class Validator
    {
        public static bool IsValidId(string input, short howMany)
        {
            bool valid = true;
            if (input.Length != howMany)
            {
                valid = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(input);
                    valid = true;
                }
                catch (Exception)
                {
                    valid = false;
                    Console.WriteLine("Invalid input!");
                }
            }
            return valid; 
        }
    }
}
