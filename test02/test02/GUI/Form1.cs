using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test02.BLL;
using test02.DAL;

namespace test02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to exit the application?","Alert",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(textBox1.Text);
            emp.FirstName = textBox2.Text;
            emp.LastName = textBox3.Text;
            emp.JobTitle = textBox4.Text;
            EmployeeDA.Create(emp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(textBox1.Text);
            emp.FirstName = textBox2.Text;
            emp.LastName = textBox3.Text;
            emp.JobTitle = textBox4.Text;
            EmployeeDA.Update(emp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeDA.Delete(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Employee emp = new Employee();
            emp = EmployeeDA.SearchById(textBox6.Text);
            ListViewItem item = new ListViewItem(emp.EmployeeId.ToString());
            item.SubItems.Add(emp.FirstName);
            item.SubItems.Add(emp.LastName);
            item.SubItems.Add(emp.JobTitle);
            listView1.Items.Add(item);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<Employee> empList = new List<Employee>();
            empList = EmployeeDA.List();
            foreach (Employee emp in empList)
            {
                ListViewItem item = new ListViewItem(emp.EmployeeId.ToString());
                item.SubItems.Add(emp.FirstName);
                item.SubItems.Add(emp.LastName);
                item.SubItems.Add(emp.JobTitle);
                listView1.Items.Add(item);
            }

        }
    }
}
