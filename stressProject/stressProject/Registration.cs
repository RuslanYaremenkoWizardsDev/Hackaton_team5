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
    public partial class Registration : Form
    {
        public Registration(int activeTab = 0, string Id = null)
        {
            InitializeComponent();
            this.activeTab = activeTab;
            this.Id = Id;
        }

        private int activeTab = 0;
        private string Id = null;

        string constr = Properties.Settings.Default.Conecction;
        SqlConnection cnn;

        DataSet ds = new DataSet();
        BindingSource bd1 = new BindingSource();
        SqlDataAdapter daPerson;
        SqlCommandBuilder bdPerson;

        SqlDataAdapter daUser;
        SqlCommandBuilder bdUser;
        BindingSource bd2 = new BindingSource();
        DataTable taUser = new DataTable();

        public void Loading()
        {
            dataGridUser.DataSource = null;
            dataGridUser.Rows.Clear();

            constr = Properties.Settings.Default.Conecction;
            SqlConnection cnn = new SqlConnection(constr);
            cnn.Open();

            DataTable dt2 = new DataTable();
            daUser = new SqlDataAdapter("SELECT * FROM Players", cnn);
            bdUser = new SqlCommandBuilder(daUser);
            daUser.Fill(dt2);

            bd2.DataSource = dt2;
            dataGridUser.DataSource = bd2;

            dataGridUser.Columns[0].Visible = false;
        }

        public void update()
        {
            cnn = new SqlConnection(constr);
            cnn.Open();

            DataTable dt1 = new DataTable();
            daPerson = new SqlDataAdapter("SELECT *FROM Players", cnn);
            bdPerson = new SqlCommandBuilder(daPerson);
            daPerson.Fill(dt1);
            bd1.DataSource = dt1;
        }

        private void activateTab()
        {
            if (activeTab < 1 || activeTab > 8)
                return;

            //tabControl1.SelectedTab = tabControl1.TabPages["tabPage" + activeTab];
        }

         private void RegistrationFunction() 
        {
            try
            {
                string sql;
                int x = 0;
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
            
                sql = "Select * FROM Players WHERE Login=@Login and Password=@Password";

                using (SqlCommand myCommand = new SqlCommand(sql, conn))
                {
                    myCommand.Parameters.AddWithValue("@Login", Login.Text);
                    myCommand.Parameters.AddWithValue("@Password", Password.Text);
                    myCommand.Parameters.AddWithValue("@Email", Email.Text);
                    myCommand.Parameters.AddWithValue("@RoleName", "User");

                    SqlDataReader reader = myCommand.ExecuteReader();

                    while (reader.Read()) x++; reader.Close();
                }
                if (x == 0)
                {
                    sql = "INSERT INTO Players(Login,Password,Email,RoleName)values" +
                        "(@Login,@Password,@Email,@RoleName)";
                    using (SqlCommand myCommand = new SqlCommand(sql, conn))
                    {
                        myCommand.Parameters.AddWithValue("@Login", Login.Text);
                        myCommand.Parameters.AddWithValue("@Password", Password.Text);
                        myCommand.Parameters.AddWithValue("@Email", Email.Text);
                        myCommand.Parameters.AddWithValue("@RoleName", "User");
                        myCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Insert");
                }
                else
                {
                    sql = "UPDATE Players SET Login=@Login, Password=@Password, Email=@Email WHERE ID=@ID";
                    using (SqlCommand myCommand = new SqlCommand(sql, conn))
                    {
                        myCommand.Parameters.AddWithValue("@ID", Id);
                        myCommand.Parameters.AddWithValue("@Login", Login.Text);
                        myCommand.Parameters.AddWithValue("@Password", Password.Text);
                        myCommand.Parameters.AddWithValue("@Email", Email.Text);
                        myCommand.Parameters.AddWithValue("@RoleName", "User");
                        myCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Update");
                }
                update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            update();
            activateTab();
            Loading();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = !(checkBox1.Checked == true);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Confirm.UseSystemPasswordChar = !(checkBox2.Checked == true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            string sql;
            sql = "Select * FROM Players WHERE Login=@Login and Password=@Password";
            SqlCommand myCommand = new SqlCommand(sql, conn);

            if (Password.Text == Confirm.Text)
            {
                if (Login.Text != "" || Password.Text != "" || Email.Text != "")
                {
                    //if (Password.Text != dataGridUser.CurrentRow.Cells[2].Value.ToString()) 
                    //{
                        RegistrationFunction();
                    //}
                }
                else 
                {
                    MessageBox.Show("Fill in the fiel");
                }
            }
            else 
            {
                MessageBox.Show("Sorry but no matches");
            }
        }

        private void User_Click(object sender, EventArgs e)
        {
            this.Width = 581;
            this.Height = 660;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Width = 470;
            this.Height = 260;
        }
    }
}
