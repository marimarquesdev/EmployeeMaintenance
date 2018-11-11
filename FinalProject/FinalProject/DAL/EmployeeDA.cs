using FinalProject.BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.DAL
{
    static class EmployeeDA
    {
        static string employeeFile = Application.StartupPath + @"\employee.txt";
        public static void Save(Employee employee)
        {
            StreamWriter sw = new StreamWriter(employeeFile, true);
                sw.WriteLine(employee.EmployeeId + "," + employee.FirstName + "," + employee.LastName + "," +
                    employee.Gender + "," + employee.BirthDate + "," + employee.Email + "," + employee.Phone
                    +"," + employee.StreetAddress + ","+employee.ApartmentNo + ","+employee.City + ","+employee.City
                    +","+ employee.State + "," + employee.ZipCode + ","+ employee.StartDate + "," + employee.JobTitle
                    +","+ employee.DepartmentName + "," + employee.Salary);
                MessageBox.Show("Employee successfully created!");
                sw.Close();
        }
    }
}
