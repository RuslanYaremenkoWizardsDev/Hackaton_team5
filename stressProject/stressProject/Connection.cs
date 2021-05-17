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

        public string filename;
        public string connectionStr;
        public Button b1, b2;

        private void Connection_Click(object sender, EventArgs e)
        {
            connectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""" + filename + @""";Integrated Security=True;Connect Timeout=30";
            Properties.Settings.Default["Conecction"] = connectionStr;
            Properties.Settings.Default.Save();
            if (Way.Text.Length > 0)
            {
                //b1.Visible = true;
                //b2.Visible = true;
                MessageBox.Show("Connection Successfull");
                //Close();

                TournamentCreation tournamentCreation = new TournamentCreation();
                //var adminPanel = new AdminPanel();
                tournamentCreation.ShowDialog();
            }
            else MessageBox.Show("Select DB to connect please");
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
