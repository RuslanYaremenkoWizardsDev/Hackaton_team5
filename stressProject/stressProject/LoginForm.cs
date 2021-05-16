using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Twilio.TwiML.Voice;
using Microsoft.ReportingServices.Diagnostics.Internal;

namespace stressProject
{
    public partial class LoginForm : Form
    {
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
                    LoginForm form = new LoginForm();
                    form.Close();
                    LoginForm form2 = new LoginForm();
                    //form2.Access(1);
                    form2.ShowDialog();
                }
                else if (role == Role.User)
                {
                    /*TabControl.TabPageCollection[3].Parent=null;
                        TabControl.TabPages[3].Parent = null;*/
                    MessageBox.Show("O, you just a User");

                    LoginForm form = new LoginForm();
                    form.Close();

                    LoginForm form2 = new LoginForm();

                    //form2.Access(2);
                    form2.ShowDialog();
                }
            }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            constr = Properties.Settings.Default.Conecction;

            GetRole(loginTextBox.Text, maskedTextBox1.Text, constr);
            login();
        }
    }
}
