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
    static class UserDA
    {
        static string userFilePath = Application.StartupPath + @"\user.txt";
        static string userTemp = Application.StartupPath + @"\userTemp.txt";

        public static void Save(User user)
        {
                StreamWriter sw = new StreamWriter(userFilePath, true);
                sw.WriteLine(user.UserId + ","+ user.Login + "," + user.Password + "," +
                    user.Group + "," + user.EmployeeId + "," + user.Status);
                MessageBox.Show("User successfully created!");
                sw.Close();
        }

        public static bool IsValidUser(User user)
        {
            bool valid = false;
            if (File.Exists(userFilePath))
            {
                StreamReader sr = new StreamReader(userFilePath);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (fields[1] == user.Login && fields[2] == user.Password)
                    {
                        MessageBox.Show("Login successfully!");
                        valid = true; 
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            return valid;
        }

        public static void Update(User user)
        {
            StreamReader sr = new StreamReader(userFilePath);
            StreamWriter sw = new StreamWriter(userTemp);
            if (File.Exists(userFilePath))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (user.UserId != Convert.ToInt32(fields[0]))
                    {
                        sw.WriteLine(fields[0] + ","+fields[1] + "," + fields[2] + "," +
                            fields[3] + "," + fields[4] + "," + fields[5]);
                    }
                    line = sr.ReadLine();
                }
                sw.WriteLine(user.UserId + "," + user.Login + "," + user.Password + "," +
                    user.Group + "," + user.EmployeeId + "," + user.Status);
                sr.Close();
                sw.Close();
                File.Delete(userFilePath);
                File.Move(userTemp, userFilePath);
                MessageBox.Show("Update successfully!");
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }

        }

        public static void Delete(User user)
        {
            StreamReader sr = new StreamReader(userFilePath);
            StreamWriter sw = new StreamWriter(userTemp);
            if (File.Exists(userFilePath))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (user.UserId != Convert.ToInt32(fields[0]))
                    {
                        sw.WriteLine(fields[0] + "," + fields[1] + "," + fields[2] + "," +
                            fields[3] + "," + fields[4] + "," + fields[5]);
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                sw.Close();
                File.Delete(userFilePath);
                File.Move(userTemp, userFilePath);
                MessageBox.Show("Delete successfully!");
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }

        }

        public static User SearchByID(int userId)
        {
            StreamReader sr = new StreamReader(userFilePath);
            User user = new User();
            string line = sr.ReadLine();
            if (File.Exists(userFilePath))
            {
                while (line != null)
                {
                    string[] fields = line.Split(',');
                    if (userId == Convert.ToInt32(fields[0]))
                    {
                        user.UserId = Convert.ToInt32(fields[0]);
                        user.Login = fields[1];
                        user.Group = fields[3];
                        user.EmployeeId = Convert.ToInt32(fields[4]);
                        user.Status = fields[5];
                        sr.Close();
                        return user;
                    }
                    line = sr.ReadLine();
                }

                user = null;
                MessageBox.Show("Employee not found!", "Alert");
            }
            else
            {
                MessageBox.Show("File not found!", "Error");
            }
            return user;
        }
    }
}
