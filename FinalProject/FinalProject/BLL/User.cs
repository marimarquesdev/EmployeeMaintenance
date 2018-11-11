using FinalProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BLL
{
    class User
    {
        int userId;
        string login;
        string password;
        string group;
        Employee employeeId;
        string status;

        public User()
        {
            userId = 0;
            login = "";
            password = "";
            group = "";
            employeeId = new Employee();
            status = "undefined";
        }

        public User(int userId, string login, string password, string group, Employee employeeId, string status)
        {
            this.userId = userId;
            this.login = login;
            this.password = password;
            this.group = group;
            this.employeeId = employeeId;
            this.status = status;
        }

        public int UserId { get => userId; set => userId = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Group { get => group; set => group = value; }
        public string Status { get => status; set => status = value; }
        public Employee EmployeeId { get => employeeId; set => employeeId = value; }

        public void SaveUser(User user)
        {
            UserDA.Save(user);
        }

        public bool IsValidUser(User user)
        {
            return UserDA.IsValidUser(user);
        }

        public void UpdateUser(User user)
        {
            UserDA.Update(user);
        }

        public void DeleteUser(User user)
        {
            UserDA.Delete(user);
        }

        public User SearchByID(int userId)
        {
            return UserDA.SearchByID(userId);
        }
    }
}
