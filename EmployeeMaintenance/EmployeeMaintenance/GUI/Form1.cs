using EmployeeMaintenance.Business;
using EmployeeMaintenance.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validator.IsValidId(maskedTextBox2.Text,4) && Validator.IdExist(Convert.ToInt32(maskedTextBox2.Text)) && Validator.IsEmailValid(textBox4.Text))
            {
                Employee emp = new Employee();
                emp.EmpNumber = Convert.ToInt32(maskedTextBox2.Text);
                emp.LastName = textBox2.Text;
                emp.FirstName = textBox3.Text;
                emp.PhoneNumber = maskedTextBox1.Text;
                emp.Email = textBox4.Text;
                emp.Create(emp);
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Would you like to exit the application?", "Alert", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<Employee> empList = new List<Employee>();
            Employee emp = new Employee();
            empList = emp.Display();
            foreach (Employee employee in empList)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(employee.EmpNumber));
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.PhoneNumber);
                item.SubItems.Add(employee.Email);
                listView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Employee emp = new Employee();
            int choice = comboBox1.SelectedIndex;
            switch (choice)
            {
                case 0:
                    int empID = Convert.ToInt32(textBox1.Text);
                    emp = emp.SearchByEmpNumber(empID);
                    ListViewItem item1 = new ListViewItem(Convert.ToString(emp.EmpNumber));
                    item1.SubItems.Add(emp.LastName);
                    item1.SubItems.Add(emp.FirstName);
                    item1.SubItems.Add(emp.PhoneNumber);
                    item1.SubItems.Add(emp.Email);
                    listView1.Items.Add(item1);
                    break;
                case 1:
                    string fName = textBox1.Text;
                    Employee employee = new Employee();
                    List<Employee> empList = new List<Employee>();
                    empList = employee.SearchByFName(fName);

                    foreach (Employee item2 in empList)
                    {
                        ListViewItem lvi = new ListViewItem(item2.EmpNumber.ToString());
                        lvi.SubItems.Add(item2.LastName);
                        lvi.SubItems.Add(item2.FirstName);
                        lvi.SubItems.Add(item2.PhoneNumber);
                        lvi.SubItems.Add(item2.Email);
                        listView1.Items.Add(lvi);
                    }
                    break;
                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            int choice = comboBox1.SelectedIndex;
            switch (choice)
            {
                case 0:
                    label7.Text = "Employee Number";
                    textBox1.Visible = true;
                    break;
                case 1:
                    label7.Text = "First Name";
                    textBox1.Visible = true;
                    break;
              
            }

        }
    }
}
