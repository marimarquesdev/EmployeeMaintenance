using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Employee emp = new Employee();
            List<Employee> empList = new List<Employee>();
            empList = emp.ListEmployee();
            foreach (Employee employee in empList)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(employee.EmployeeId));
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                listView1.Items.Add(item);
            }
            //listView1.Items.Clear();
            //listView1 = ;
            //List<Employee> empList = new List<Employee>();
            //Employee emp = new Employee(1234,"Mary","Brown");
            //empList.Add(emp);
            //Employee emp1 = new Employee(3456, "Thomas", "Brown");
            //empList.Add(emp1);
            //foreach (Employee empItem in empList)
            //{
            //    ListViewItem item = new ListViewItem(Convert.ToString(empItem.EmployeeId));
            //    item.SubItems.Add(empItem.FirstName);
            //    item.SubItems.Add(empItem.LastName);
            //    listView1.Items.Add(item);
            //}
        }
    }
}
