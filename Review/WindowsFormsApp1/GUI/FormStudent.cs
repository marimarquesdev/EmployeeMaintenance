using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.Validation;

namespace WindowsFormsApp1
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void buttonStoreData_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            //  student.StudentId = 1234567;
            if (Validator.IsValidId(textBox1.Text, 7))
            {
                student.StudentId = Convert.ToInt32(textBox1.Text);
            }
            else
            {
                textBox1.Text = "";
                return;
            }
            student.FirstName = "Mary";
            student.LastName = "Brown";
            MessageBox.Show(student.StudentId + "\n" + student.FirstName + "\n" + student.LastName);
              student.SaveStudent(student);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormStudent_Load(object sender, EventArgs e)
        {

        }

        //private void buttonShow_Click(object sender, EventArgs e)
        //{
        //    Student student = new Student();
        //    student.StudentId = 1234567;
        //    student.FirstName = "Mary";
        //    student.LastName = "Brown";
        //    MessageBox.Show(student.StudentId + "\n" + student.FirstName + "\n" + student.LastName);


        //}
    }
}
