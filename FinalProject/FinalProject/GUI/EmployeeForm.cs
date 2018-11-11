using FinalProject.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(empId.Text);
            emp.FirstName = firstName.Text;
            emp.LastName = lastName.Text;
            emp.Gender = gender.Text;
            emp.BirthDate = birthDate.Text;
            emp.Email = email.Text;
            emp.Phone = phone.Text;
            emp.StreetAddress = streetAddress.Text;
            emp.ApartmentNo = Convert.ToInt16(aptNumber.Text);
            emp.City = city.SelectedText;
            emp.State = state.SelectedText;
            emp.ZipCode = zipcode.Text;
        //    emp.StartDate = Convert.ToDateTime(startDate.Text);
            emp.JobTitle = jobTitle.SelectedText;
            emp.DepartmentName = department.SelectedText;
            emp.Salary = Convert.ToDouble(salary.Text);
            emp.SaveEmployee(emp);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Would you like to exit the application? ", "Confirmation", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserId = Convert.ToInt16(userId.Text);
            user.Login = userName.Text;
            user.Password = passwd.Text;
            user.Group = userGroup.Text;
            user.EmployeeId = Convert.ToInt32(employeeId.Text);
            user.Status = userStatus.Text;
            user.SaveUser(user);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Would you like to exit the application? ", "Confirmation", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserId = Convert.ToInt16(userId.Text);
            user.Login = userName.Text;
            user.Password = passwd.Text;
            user.Group = userGroup.Text;
            user.EmployeeId = Convert.ToInt32(employeeId.Text);
            user.Status = userStatus.Text;
            user.UpdateUser(user);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserId = Convert.ToInt16(userId.Text);
            user.DeleteUser(user);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Show();
        }
    }
}
