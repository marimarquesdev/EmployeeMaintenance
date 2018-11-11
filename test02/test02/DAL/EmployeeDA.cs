using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test02.BLL;

namespace test02.DAL
{
    static class EmployeeDA
    {
        static string filePath = Application.StartupPath + @"/employee.txt";
        static string fileTemp = Application.StartupPath + @"/temp.txt";

        public static void Create(Employee emp)
        {
            if (File.Exists(filePath))
            {
                StreamWriter sw = new StreamWriter(filePath,true);
                sw.WriteLine(emp.EmployeeId + "," + emp.FirstName + "," + emp.LastName + "," + emp.JobTitle);
                sw.Close();
                MessageBox.Show("Employee successfully created!");
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }

       public static void Update(Employee emp)
        {
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                StreamWriter sw = new StreamWriter(fileTemp);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');

                    if (Convert.ToInt32(fields[0]) != emp.EmployeeId)
                    {
                        sw.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3]);
                    }
                    line = sr.ReadLine();
                }
                sw.WriteLine(emp.EmployeeId + "," + emp.FirstName + "," + emp.LastName + "," + emp.JobTitle);
                sr.Close();
                sw.Close();
                File.Delete(filePath);
                File.Move(fileTemp, filePath);
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }

        public static void Delete(string employeeId)
        {
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                StreamWriter sw = new StreamWriter(fileTemp);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');

                    if (fields[0] != employeeId)
                    {
                        sw.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," + fields[3]);
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                sw.Close();
                File.Delete(filePath);
                File.Move(fileTemp, filePath);
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }

        public static Employee SearchById(string empId)
        {
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath, true);
                Employee emp = new Employee();
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (empId == fields[0])
                    {
                        emp.EmployeeId = Convert.ToInt32(fields[0]);
                        emp.FirstName = fields[1];
                        emp.LastName = fields[2];
                        emp.JobTitle = fields[3];
                        return emp;
                    }
                    line = sr.ReadLine();
                }
                
            }
            else
            {
                MessageBox.Show("File does not exist!");
                return null;
            }
            return null;
        }

        public static List<Employee> SearchByFN(string firstName)
        {
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath, true);
                List<Employee> empList = new List<Employee>();
                Employee emp;
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    emp = new Employee();
                    if (firstName == fields[1])
                    {
                        emp.EmployeeId = Convert.ToInt32(fields[0]);
                        emp.FirstName = fields[1];
                        emp.LastName = fields[2];
                        emp.JobTitle = fields[3];
                        empList.Add(emp);
                        return empList;
                    }
                }
            }
            else
            {
                MessageBox.Show("File does not exist!");
                return null;
            }
            return null;
        }

        public static List<Employee> SearchByLN(string lastName)
        {
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath, true);
                List<Employee> empList = new List<Employee>();
                Employee emp;
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    emp = new Employee();
                    if (lastName == fields[1])
                    {
                        emp.EmployeeId = Convert.ToInt32(fields[0]);
                        emp.FirstName = fields[1];
                        emp.LastName = fields[2];
                        emp.JobTitle = fields[3];
                        empList.Add(emp);
                        return empList;
                    }
                }
            }
            else
            {
                MessageBox.Show("File does not exist!");
                return null;
            }
            return null;
        }

        public static List<Employee> List()
        {
            if (File.Exists(filePath))
            {
                List<Employee> listEmp = new List<Employee>();
                Employee emp;
                StreamReader sr = new StreamReader(filePath);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    emp = new Employee();
                    emp.EmployeeId = Convert.ToInt32(fields[0]);
                    emp.FirstName = fields[1];
                    emp.LastName = fields[2];
                    emp.JobTitle = fields[3];
                    listEmp.Add(emp);
                    line = sr.ReadLine();
                }
                sr.Close();
                return listEmp;
            }
            else
            {
                MessageBox.Show("File does not exist!");
                return null;
            }
        }
    }
}
