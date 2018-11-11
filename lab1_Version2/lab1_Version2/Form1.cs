using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab1_Version2.DAL;
using lab1_Version2.BLL;
using lab1_Version2.Validation;

namespace lab1_Version2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Would you like to exit the application? ","Confirmation",MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (!EmployeeDA.IsDuplicateId(Convert.ToInt32(textBox1.Text))&&Validator.IsValidId(textBox1.Text,4)&&
                Validator.IsValidName(textBox2.Text,"Name"))
            {
                Employee employee = new Employee();
                employee.EmployeeID = Convert.ToInt32(textBox1.Text);
                employee.FirstName = textBox2.Text;
                employee.LastName = textBox3.Text;
                employee.JobTitle = textBox4.Text;
                EmployeeDA.SaveRecord(employee);
            }
            else
            {
                MessageBox.Show("Employee not saved");
            }
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int option = comboBox1.SelectedIndex.GetHashCode();
            switch (option)
            {
                case 0:
                    label6.Text = "Employee ID: ";
                    label6.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = false;
                    label7.Visible = false;
                    textBox5.Clear();
                    textBox6.Clear();
                    break;
                case 1:
                    label6.Text = "First Name ";
                    label6.Visible = true;
                    label7.Visible = false;
                    textBox5.Visible = true;
                    textBox6.Visible = false;
                    textBox5.Clear();
                    textBox6.Clear();
                    break;
                case 2:
                    label6.Text = "Last Name ";
                    label6.Visible = true;
                    label7.Visible = false;
                    textBox5.Visible = true;
                    textBox6.Visible = false;
                    textBox5.Clear();
                    textBox6.Clear();
                    break;
                case 3:
                    label6.Text = "First Name ";
                    label7.Text = "Last Name ";
                    label6.Visible = true;
                    label7.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox5.Clear();
                    textBox6.Clear();
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Employee employee = new Employee();
            List<Employee> listEmployee = new List<Employee>();
            int option = comboBox1.SelectedIndex.GetHashCode();
            switch (option)
            {
                case 0:
                    employee = EmployeeDA.Search(Convert.ToInt32(textBox5.Text));
                    ListViewItem item = new ListViewItem(employee.EmployeeID.ToString());
                    item.SubItems.Add(employee.FirstName);
                    item.SubItems.Add(employee.LastName);
                    item.SubItems.Add(employee.JobTitle);
                    listView1.Items.Add(item);
                    break;
                case 1:
                    //listEmployee = EmployeeDA.SearchFirstName(textBox5.Text);
                    //ListViewItem item1 = new ListViewItem(employee.EmployeeID.ToString());
                    //item1.SubItems.Add(employee.FirstName);
                    //item1.SubItems.Add(employee.LastName);
                    //item1.SubItems.Add(employee.JobTitle);
                    //listView1.Items.Add(item1);

                    List<Employee> listEmployee1 = new List<Employee>();
                    listEmployee1 = EmployeeDA.SearchFirstName(textBox5.Text);
                    ListViewItem item1;
                    foreach (Employee aEmp in listEmployee1)
                    {
                        listEmployee1 = EmployeeDA.SearchFirstName(textBox5.Text);
                        item1 = new ListViewItem(aEmp.EmployeeID.ToString());
                        item1.SubItems.Add(aEmp.FirstName);
                        item1.SubItems.Add(aEmp.LastName);
                        item1.SubItems.Add(aEmp.JobTitle);
                        listView1.Items.Add(item1);  
                    }
                    break;
                case 2:
                    List<Employee> listEmployee2 = new List<Employee>();
                    listEmployee2 = EmployeeDA.SearchLastName(textBox5.Text);
                    ListViewItem item2;
                    foreach (Employee aEmp in listEmployee2)
                    {
                        listEmployee2 = EmployeeDA.SearchFirstName(textBox5.Text);
                        item2 = new ListViewItem(aEmp.EmployeeID.ToString());
                        item2.SubItems.Add(aEmp.FirstName);
                        item2.SubItems.Add(aEmp.LastName);
                        item2.SubItems.Add(aEmp.JobTitle);
                        listView1.Items.Add(item2);
                    }
                    break;
                case 3:
                    employee = EmployeeDA.SearchFullName(textBox5.Text,textBox6.Text);
                    ListViewItem item3 = new ListViewItem(employee.EmployeeID.ToString());
                    item3.SubItems.Add(employee.FirstName);
                    item3.SubItems.Add(employee.LastName);
                    item3.SubItems.Add(employee.JobTitle);
                    listView1.Items.Add(item3);
                    break;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<Employee> listEmployee = new List<Employee>();
            listEmployee = EmployeeDA.List();

                foreach (Employee aEmp in listEmployee)
                {
                ListViewItem item = new ListViewItem(aEmp.EmployeeID.ToString());
                item.SubItems.Add(aEmp.FirstName);
                item.SubItems.Add(aEmp.LastName);
                item.SubItems.Add(aEmp.JobTitle);
                listView1.Items.Add(item);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeID = Convert.ToInt32(textBox1.Text);
            emp.FirstName = textBox2.Text;
            emp.LastName = textBox3.Text;
            emp.JobTitle = textBox4.Text;
            emp.UpdateEmployee(emp);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeID = Convert.ToInt32(textBox1.Text);
            emp.DeleteEmployee(emp);
        }
    }
}
