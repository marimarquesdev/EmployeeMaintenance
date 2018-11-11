using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MyIdValidator
{
    public partial class MyIdValidator: UserControl
    {
        public MyIdValidator()
        {
            InitializeComponent();
        }

        public static bool IsValidNumber(TextBox textBox, int size)
        {
            if (!(Regex.IsMatch(textBox.Text, @"^\d{" + size + "}$")))
            {
                MessageBox.Show(textBox.Tag + " does not comply with the requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (!IsValidNumber(textBox1,4))
            {
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}
