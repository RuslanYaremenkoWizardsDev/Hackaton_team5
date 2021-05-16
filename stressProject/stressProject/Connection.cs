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
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        public Button but1, but2, but3;
        public string filename;
        public string connectionStr;

        private void Connection_Click(object sender, EventArgs e)
        {
            connectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""" + filename + @""";Integrated Security=True;Connect Timeout=30";
            Properties.Settings.Default["Conecction"] = connectionStr;
            Properties.Settings.Default.Save();
            if (Way.Text.Length > 0)
            {
                MessageBox.Show("Connection Successfull");
                but1.Enabled = true;
                but3.Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Something wrong");
            }
        }

        private void PathSetting_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.mdf)|*.mdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                Way.Text = filename;
            }
        }

        

    }
}
