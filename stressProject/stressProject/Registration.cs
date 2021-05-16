﻿using System;
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
        public Registration(int activeTab = 0, string shopId = null)
        {
            InitializeComponent();
            this.activeTab = activeTab;
            this.shopId = shopId;
        }

        string constr = Properties.Settings.Default.Conecction;
        SqlConnection cnn;

        DataSet ds = new DataSet();
        BindingSource bd1 = new BindingSource();
        SqlDataAdapter daPerson;
        SqlCommandBuilder bdPerson;

        private int activeTab = 0;
        private string shopId = null;

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

        private void Registration_Load(object sender, EventArgs e)
        {
            update();
            activateTab();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = !(checkBox1.Checked == true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                string sql;
                int x = 0;
                sql = "Select * FROM Players WHERE Login=@Login and Password=@Password";

                using (SqlCommand myCommand = new SqlCommand(sql, conn))
                {
                    myCommand.Parameters.AddWithValue("@Login", Login.Text);
                    myCommand.Parameters.AddWithValue("@Password", Password.Text);
                    SqlDataReader reader = myCommand.ExecuteReader();
                    while (reader.Read()) x++; reader.Close();
                }
                if (x == 0)
                {
                    sql = "INSERT INTO Shops(Shop,Shop_location,Director,Shop_phone)values" +
                        "(@Shop,@Shop_location,@Director,@Shop_phone)";
                    using (SqlCommand myCommand = new SqlCommand(sql, conn))
                    {
                        myCommand.Parameters.AddWithValue("@Shop", Login.Text);
                        myCommand.Parameters.AddWithValue("@Shop_location", Password.Text);
                        myCommand.Parameters.AddWithValue("@Director", textBox3.Text);
                        myCommand.Parameters.AddWithValue("@Shop_phone", Password.Text);
                        myCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Insert");
                }
                else
                {
                    sql = "UPDATE Shops SET Location=@Location, Director=@Director, Shop_phone=@Shop_phone WHERE Id_Shop=@Id_Shop";
                    using (SqlCommand myCommand = new SqlCommand(sql, conn))
                    {
                        myCommand.Parameters.AddWithValue("@Id_Shop", shopId);
                        myCommand.Parameters.AddWithValue("@Location", Password.Text);
                        myCommand.Parameters.AddWithValue("@Director", Password.Text);
                        myCommand.Parameters.AddWithValue("@Shop_phone", Password.Text);
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
    }
}
