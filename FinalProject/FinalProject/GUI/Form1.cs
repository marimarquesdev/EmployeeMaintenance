using FinalProject.BLL;
using FinalProject.DAL;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Login = textBox1.Text;
            user.Password = textBox2.Text;
            if (user.IsValidUser(user))
            {
                EmployeeForm empForm = new EmployeeForm();
                empForm.Show();
            }
            else
            {
                MessageBox.Show("User and/or password incorrect or does not exist!", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
