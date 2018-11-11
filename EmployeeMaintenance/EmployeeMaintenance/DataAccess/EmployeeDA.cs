using EmployeeMaintenance.Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMaintenance.DataAccess
{
    static class EmployeeDA
    {
        static string filePath = Application.StartupPath + @"/employee.txt";

        public static void Create(Employee employee)
        {
            if (File.Exists(filePath))
            {
                StreamWriter sw = new StreamWriter(filePath, true);
                sw.WriteLine(employee.EmpNumber + "," + employee.LastName + "," + employee.FirstName + "," + employee.PhoneNumber + "," + employee.Email);
                sw.Close();
                MessageBox.Show("Employee saved!");
            }
            else
            {
                MessageBox.Show("File does not exist!", "Alert");
            }
        }

        public static Employee SearchByEmpNumber(int empNumber)
        {
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath, true);
                Employee employee = new Employee();
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (empNumber == Convert.ToInt32(fields[0]))
                    {
                        employee.EmpNumber = Convert.ToInt32(fields[0]);
                        employee.LastName = fields[1];
                        employee.FirstName = fields[2];
                        employee.PhoneNumber = fields[3];
                        employee.Email = fields[4];
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
        public static List<Employee> SearchByFName(string firtName)
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
                    if (firtName == fields[2])
                    {
                        employee = new Employee();
                        employee.EmpNumber = Convert.ToInt32(fields[0]);
                        employee.LastName = fields[1];
                        employee.FirstName = fields[2];
                        employee.PhoneNumber = fields[3];
                        employee.Email = fields[4];
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

        public static List<Employee> Display()
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
                    employee.EmpNumber = Convert.ToInt32(fields[0]);
                    employee.LastName = fields[1];
                    employee.FirstName = fields[2];
                    employee.PhoneNumber = fields[3];
                    employee.Email = fields[4];
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
    }
}
