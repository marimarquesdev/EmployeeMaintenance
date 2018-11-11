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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            User user = new User();
            int option = comboBox1.SelectedIndex.GetHashCode();
            switch (option)
            {
                case 0:
                    user = user.SearchByID(Convert.ToInt32(textBox1.Text));
                    ListViewItem item = new ListViewItem(user.UserId.ToString());
                    item.SubItems.Add(user.Login);
                    item.SubItems.Add(user.EmployeeId.ToString());
                    item.SubItems.Add(user.Group);
                    item.SubItems.Add(user.Status);
                    listView1.Items.Add(item);
                    break;

                default:
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Close();
        }
    }
}
