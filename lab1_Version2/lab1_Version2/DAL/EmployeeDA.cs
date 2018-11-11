using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab1_Version2.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1_Version2.DAL
{
    static class EmployeeDA
    {
        static string filePath = Application.StartupPath + @"\employee.bat";
        static string fileTemp = Application.StartupPath + @"\fileTemp.txt";
        public static void SaveRecord(Employee employee)
        {
            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine(employee.EmployeeID+ ","+employee.FirstName+","+employee.LastName+","+employee.JobTitle);
            sw.Close();
        }

        public static bool IsDuplicateId(int id)
        {
            //check if the file exists
            if (File.Exists(filePath))
            {
                // create the object of type StreamReader
                StreamReader sr = new StreamReader(filePath);
                //read the first line
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (Convert.ToInt32(fields[0]) == id)
                    {
                        sr.Close();
                        MessageBox.Show("Duplicate Id", "Invalid Id");
                        return true;
                    }
                    //read the next line
                    line = sr.ReadLine();
                }
                sr.Close();
                return false; // Id is OK
            }
            else
            {
                MessageBox.Show("File not found!");
            }
            return false;

        }

        public static Employee Search(long id)
        {
            Employee employee = new Employee();
            
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath, true);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (id == Convert.ToInt32(fields[0]))
                    {
                        employee.EmployeeID = Convert.ToInt32(fields[0]);
                        employee.FirstName = fields[1];
                        employee.LastName = fields[2];
                        employee.JobTitle = fields[3];
                        sr.Close();
                        return employee;
                    }
                    line = sr.ReadLine();
                }
                   
                        employee = null;
                        MessageBox.Show("Employee not found!", "Alert");

            }
            else
            {
                MessageBox.Show("File not found!", "Error");
            }
            return employee;
        }

        public static List<Employee> SearchFirstName(string firstName)
        {
            List<Employee> listEmployee = new List<Employee>();
            Employee employee;

            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath, true);
                string line = sr.ReadLine();
                while (line != null)
                {
                    employee = new Employee();
                    string[] fields = line.Split(',');
                    if (firstName == fields[1])
                    {
                        employee.EmployeeID = Convert.ToInt32(fields[0]);
                        employee.FirstName = fields[1];
                        employee.LastName = fields[2];
                        employee.JobTitle = fields[3];
                        listEmployee.Add(employee);
                       
                    }
                    line = sr.ReadLine();
                   
                }
                sr.Close();
                return listEmployee;

                MessageBox.Show("Employee not found!", "Alert");
            }
            else
            {
                MessageBox.Show("File not found!", "Error");
            }
            return listEmployee;
        }

        public static List<Employee> SearchLastName(string lastName)
        {
            List<Employee> listEmployee = new List<Employee>();
            Employee employee;

            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath, true);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                   
                    if (lastName == fields[2])
                    {
                        employee = new Employee();
                        employee.EmployeeID = Convert.ToInt32(fields[0]);
                        employee.FirstName = fields[1];
                        employee.LastName = fields[2];
                        employee.JobTitle = fields[3];
                        listEmployee.Add(employee);
                       
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                return listEmployee;

                
                MessageBox.Show("Employee not found!", "Alert");

            }
           
            else
            {
                MessageBox.Show("File not found!", "Error");
            }
            return listEmployee;

        }
        public static Employee SearchFullName(string firstName, string lastName)
        {
            Employee employee = new Employee();

            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath, true);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (firstName == fields[1] && lastName == fields[2])
                    {
                        employee.EmployeeID = Convert.ToInt32(fields[0]);
                        employee.FirstName = fields[1];
                        employee.LastName = fields[2];
                        employee.JobTitle = fields[3];
                        sr.Close();
                        return employee;
                    }
                    line = sr.ReadLine();
                }

                // employee = null;
                MessageBox.Show("Employee not found!", "Alert");

            }
            else
            {
                MessageBox.Show("File not found!", "Error");
            }
            return employee;
        }
        public static List<Employee> List()
        {
            List<Employee> listEmployee = new List<Employee>() ;
            Employee employee; 

            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath, true);
                                
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    employee = new Employee();
                    employee.EmployeeID = Convert.ToInt32(fields[0]);
                    employee.FirstName = fields[1];
                    employee.LastName = fields[2];
                    employee.JobTitle = fields[3];
                    listEmployee.Add(employee);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            else
            {
                MessageBox.Show("File not found!", "Error");
            }
            
            return listEmployee;
        }

        public static void Update(Employee employee)
        {
            StreamReader sr = new StreamReader(filePath);
            StreamWriter sw = new StreamWriter(fileTemp);
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] split = line.Split(',');
                if (employee.EmployeeID != Convert.ToInt32(split[0]))
                {
                    sw.WriteLine(split[0] + ","+ split[1] + "," + split[2]
                        + "," + split[3]);
                }
                line = sr.ReadLine();
            }
            sw.WriteLine(employee.EmployeeID + "," + employee.FirstName + "," + employee.LastName + "," + employee.JobTitle);
            sr.Close();
            sw.Close();
            File.Delete(filePath);
            File.Move(fileTemp,filePath);
            MessageBox.Show("Update successfully!");
        }

        public static void DeleteRecord(Employee employee)
        {
            StreamReader sr = new StreamReader(filePath);
            StreamWriter sw = new StreamWriter(fileTemp);
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                if (employee.EmployeeID != Convert.ToInt32(fields[0]))
                {
                    sw.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," +
                        fields[3]);
                }
                line = sr.ReadLine();
            }
            sr.Close();
            sw.Close();
            File.Delete(filePath);
            File.Move(fileTemp, filePath);
            MessageBox.Show("Delete successfully!");
        }
    }
}
