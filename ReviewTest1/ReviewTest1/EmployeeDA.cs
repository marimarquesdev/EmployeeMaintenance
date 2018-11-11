using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ReviewTest1
{
    public static class EmployeeDA
    {
        static string filePath = Application.StartupPath + @"\employee.txt";

        public static List<Employee> ListEmployee()
        {
            List<Employee> empList = new List<Employee>();

            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] filds = line.Split(',');
                    Employee employee = new Employee();
                    employee.EmployeeId = Convert.ToInt32(filds[0]);
                    employee.FirstName = filds[1];
                    employee.LastName = filds[2];
                    empList.Add(employee);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            else
            {
                MessageBox.Show("File not found!");
            }
            return empList;
        }

        public static void Update(Employee emp)
        {

           
        }
    }



}       


