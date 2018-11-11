using ReviewMidleTermExam.BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewMidleTermExam.DAL
{
    static class EmployeeDA
    {
        static string filePath = Application.StartupPath + @"/employee.txt";

        public static void Create(Employee employee)
        {
            if (File.Exists(filePath))
            {
                StreamWriter sw = new StreamWriter(filePath, true);
                sw.WriteLine(employee.EmployeeId + ","+employee.FirstName + ","+ employee.LastName + "," + employee.JobTitle);
                sw.Close();
                MessageBox.Show("Employee saved!");
            }
            else
            {
                MessageBox.Show("File does not exist!", "Alert");
            }
        }

        public static List<Employee> List()
        {
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath, true);
                List<Employee> empList = new List<Employee>();
                Employee employee;
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    employee = new Employee();
                    employee.EmployeeId = Convert.ToInt32(fields[0]);
                    employee.FirstName = fields[1];
                    employee.LastName = fields[2];
                    employee.JobTitle = fields[3];
                    empList.Add(employee);
                    line = sr.ReadLine();
                }
                sr.Close();
                return empList;
            }
            else
            {
                MessageBox.Show("File does not exist!", "Alert");
                return null;
            }
        }

        public static Employee SearchById(int empId)
        {
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath, true);
                Employee employee = new Employee();
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (empId == Convert.ToInt32(fields[0]))
                    {
                        employee.EmployeeId = Convert.ToInt32(fields[0]);
                        employee.FirstName = fields[1];
                        employee.LastName = fields[2];
                        employee.JobTitle = fields[3];
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                return employee;
            }
            else
            {
                MessageBox.Show("File does not exist!", "Alert");
                return null;
            }

        }

        public static List<Employee> SearchByFName(string fn)
        {
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath, true);
                List<Employee> empList = new List<Employee>();
                Employee employee;
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (fn == fields[1])
                    {
                        employee = new Employee();
                        employee.EmployeeId = Convert.ToInt32(fields[0]);
                        employee.FirstName = fields[1];
                        employee.LastName = fields[2];
                        employee.JobTitle = fields[3];
                        empList.Add(employee);
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                return empList;
            }
            else
            {
                MessageBox.Show("File does not exist!", "Alert");
                return null;
            }

        }

        public static bool IdExist(int empId)
        {
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                if (empId == Convert.ToInt32(fields[0]))
                {
                    MessageBox.Show("Id alredy exist!");
                    sr.Close();
                    return false;
                }
                line = sr.ReadLine();
            }
            sr.Close();
            return true;
        }

    }
}
