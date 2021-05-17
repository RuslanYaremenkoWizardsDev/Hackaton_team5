using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace stressProject
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        string constr;

        enum Role { Failed, Admin, User }
        static Role GetRole(string login, string password, string constr)
        {
            Role role = Role.Admin;
            var conn = new SqlConnection(constr);
            conn.Open();
            string sql = "SELECT RoleName FROM[Players] WHERE Login=@Login AND Password=@Password";
            using (var myCommand = new SqlCommand(sql, conn))
            {
                myCommand.Parameters.AddWithValue("@Login", login);
                myCommand.Parameters.AddWithValue("@Password", password);

                using (var dataReader = myCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        switch ((string)dataReader["RoleName"])
                        {
                            case "User": role = Role.User; break;
                            case "Admin": role = Role.Admin; break;
                        }
                    }
                }
            }
            return role;
        }

        void login()
        {
            Role role = GetRole(loginTextBox.Text, maskedTextBox1.Text, constr);
            if (role == Role.Failed)
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            else
            {
                if (role == Role.Admin)
                {
                    MessageBox.Show("Welcome our Admin");

                    AdminPanel form = new AdminPanel();
                    form.Close();

                    TournamentCreation form2 = new TournamentCreation();

                }
                else if (role == Role.User)
                {
                    MessageBox.Show("O, you just a User");

                    AdminPanel form = new AdminPanel();
                    form.Close();

                    TournamentCreation form2 = new TournamentCreation();

                    form2.Show();
                }
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            constr = Properties.Settings.Default.Conecction;

            GetRole(loginTextBox.Text, maskedTextBox1.Text, constr);
            login();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.UseSystemPasswordChar = !(checkBox1.Checked == true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }
    }
}
