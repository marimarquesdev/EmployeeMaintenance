using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab1.BLL;
using lab1.DAL;
using lab1.Validation;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte exit = Convert.ToByte(MessageBox.Show("Would you like to exit the application?","Exit", MessageBoxButtons.YesNo));
            if (exit == 6)
            {
                Application.Exit();
            }
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            if (Validator.IsValidId(textBox1.Text,7)&& (Validator.IsValidName(textBox2.Text))&& (Validator.IsValidName(textBox3.Text))&&(Validator.IsValidName(textBox4.Text))&&(!Validator.IsDuplicatedId(Convert.ToInt32(textBox1.Text))))
            {
                employee.EmployeeNumber = Convert.ToDouble(textBox1.Text.Trim());
                employee.FirstName = textBox2.Text.Trim();
                employee.LastName = textBox3.Text.Trim();
                employee.JobTitle = textBox4.Text;
                EmployeeDA.Save(employee);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
