using ReviewMidleTermExam.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewMidleTermExam
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if (emp.IdExist(Convert.ToInt32(textBox1.Text)) && emp.IsValidId(textBox1.Text,4)&& emp.IsValidName(textBox2.Text) && emp.IsValidName(textBox3.Text))
            {
                emp.EmployeeId = Convert.ToInt32(textBox1.Text);
                emp.FirstName = textBox2.Text;
                emp.LastName = textBox3.Text;
                emp.JobTitle = textBox4.Text;
                emp.CreateEmployee(emp);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Would you like to exit the application?", "Alert",MessageBoxButtons.YesNo);
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
            empList = emp.List();
            foreach (Employee employee in empList)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(employee.EmployeeId));
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.JobTitle);
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
                    
                    int empID = Convert.ToInt32(textBox5.Text);
                    emp = emp.SearchById(empID);
                    ListViewItem item = new ListViewItem(Convert.ToString(emp.EmployeeId));
                    item.SubItems.Add(emp.FirstName);
                    item.SubItems.Add(emp.LastName);
                    item.SubItems.Add(emp.JobTitle);
                    listView1.Items.Add(item);
                    break;
                case 1:
                    string fName = textBox5.Text;
                    Employee employee = new Employee();
                    List<Employee> empList = new List<Employee>();
                    empList = employee.SearchByFName(fName);
                   
                    foreach (Employee item1 in empList)
                    {
                        ListViewItem lvi = new ListViewItem(item1.EmployeeId.ToString());
                        lvi.SubItems.Add(item1.FirstName);
                        lvi.SubItems.Add(item1.LastName);
                        lvi.SubItems.Add(item1.JobTitle);
                        listView1.Items.Add(lvi);
                    }
                    break;
                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choice = comboBox1.SelectedIndex;
            switch (choice)
            {
                case 0:
                    label6.Text = "Employee Number";
                    textBox5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = false;
                    textBox6.Visible = false;
                    break;
                case 1:
                    textBox5.Visible = true;
                    label6.Text = "First Name";
                    label6.Visible = true;
                    label7.Visible = false;
                    textBox6.Visible = false;
                    break;
                case 2:
                    textBox5.Visible = true;
                    label6.Text = "Last Name";
                    label6.Visible = true;
                    label7.Visible = false;
                    textBox6.Visible = false;
                    break;
                case 3:
                    textBox5.Visible = true;
                    label6.Text = "First Name";
                    label6.Visible = true;
                    label7.Text = "Last Name";
                    label7.Visible = true;
                    textBox6.Visible = true;
                    break;
                default:
                    break;
            }
            
        }
    }
}
