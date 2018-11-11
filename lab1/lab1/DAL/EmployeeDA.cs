using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab1.BLL;


namespace lab1.DAL
{
    class EmployeeDA
    {
        static string filePath = Application.StartupPath + @"\employee.dat";

        public static void Save(Employee employee)
        {
            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine(employee.EmployeeNumber + ", "+employee.FirstName + ", " + employee.LastName + ", "+ employee.JobTitle);
            sw.Close();
        }

        public static Employee SearchById(int id)
        {
            Employee employee = new Employee();
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (Convert.ToInt32(fields[0]) == id)
                    {
                        employee.EmployeeNumber = Convert.ToInt32(fields[0]);
                        employee.FirstName = fields[1];
                        employee.LastName = fields[2];
                        employee.JobTitle = fields[3];
                        sr.Close();
                        return employee;
                    }
                    line = sr.ReadLine();
                }
            }
            else
            {
                MessageBox.Show("Employee not found!");
            }
            return null;
        }

        public static List<Employee> SearchByName(string name)
        {
            List<Employee> employee = new List<Employee>();
           
            
            return employee;
        }

        public static List<Employee> ListAllRecords()
        {
            List<Employee> employee = new List<Employee>();

            return employee;
        }


    }
}
