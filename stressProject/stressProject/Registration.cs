using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stressProject
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.UseSystemPasswordChar = !(checkBox1.Checked == true);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
