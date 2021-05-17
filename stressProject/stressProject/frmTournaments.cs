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
    public partial class frmTournaments : Form
    {

        string _connect = Properties.Settings.Default.Conecction;

        private SqlConnection sqlConnectionHackathon = null;
        private SqlCommandBuilder sqlBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSetTournaments = null;
        BindingSource bindingSource = new BindingSource();

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

        private void UpdateDataBase()
        {
            sqlConnectionHackathon = new SqlConnection(_connect);
            sqlConnectionHackathon.Open();

            DataTable dataTable = new DataTable();

            sqlDataAdapter = new SqlDataAdapter("SELECT *FROM Tournaments", sqlConnectionHackathon);
            sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
        }


        DateTime defaultFromDateFilter = Convert.ToDateTime("01/01/1753");
        DateTime defaultToDateFilter = DateTime.Now.AddYears(1);
        public frmTournaments()
        {
            InitializeComponent();
        }

        private void frmTournaments_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(_connect);
            conn.Open();
            string sql;
            int x = 0;
            sql = "SELECT * FROM Tournaments WHERE(State LIKE @State) AND(StartDate >= @StartFrom) AND(StartDate <= @StartTo) AND(LastRegistrationDate >= @RegFrom) AND(LastRegistrationDate <= @RegTo)";

            using (SqlCommand myCommand = new SqlCommand(sql, conn))
            {
                //dataSetTournaments.Clear();
                myCommand.Parameters.AddWithValue("@State", "%%");
                myCommand.Parameters.AddWithValue("@StartFrom", defaultFromDateFilter);
                myCommand.Parameters.AddWithValue("@StartTo", defaultToDateFilter);
                myCommand.Parameters.AddWithValue("@RegFrom", defaultFromDateFilter);
                myCommand.Parameters.AddWithValue("@RegTo", defaultToDateFilter);
                //sqlDataAdapter.Fill(dataSetTournaments);
            }

            dataGridViewTournaments.DataSource = null;
            dataGridViewTournaments.Rows.Clear();

            constr = Properties.Settings.Default.Conecction;
            SqlConnection cnn = new SqlConnection(constr);
            cnn.Open();

            DataTable dt2 = new DataTable();
            daUser = new SqlDataAdapter("SELECT * FROM Tournaments", cnn);
            bdUser = new SqlCommandBuilder(daUser);
            daUser.Fill(dt2);

            bd2.DataSource = dt2;
            dataGridViewTournaments.DataSource = bd2;
        }

        private void btnCreateTournament_Click(object sender, EventArgs e)
        {
            Form tornamentCreation = new TournamentCreation();
            tornamentCreation.ShowDialog();
            //Form fremCreateTournament = new frmCreateEditTournament(sqlConnectionHackathon, sqlDataAdapter, dataSetTournaments);
            //fremCreateTournament.Text = "Create Tournament";
            //fremCreateTournament.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataSetTournaments.Clear();
            sqlDataAdapter.SelectCommand.Parameters["@State"].Value = "%%";
            sqlDataAdapter.SelectCommand.Parameters["@StartFrom"].Value = defaultFromDateFilter;
            sqlDataAdapter.SelectCommand.Parameters["@StartTo"].Value = defaultToDateFilter;
            sqlDataAdapter.SelectCommand.Parameters["@RegFrom"].Value = defaultFromDateFilter;
            sqlDataAdapter.SelectCommand.Parameters["@RegTo"].Value = defaultToDateFilter;
            sqlDataAdapter.Fill(dataSetTournaments);
            radioBtnState.Checked = false;
            radioBtnStartDate.Checked = false;
            radioBtnRegDate.Checked = false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dataSetTournaments.Clear();
            if (radioBtnState.Checked)
            {
                sqlDataAdapter.SelectCommand.Parameters["@State"].Value = "%" + comboBoxState.Text.Trim() + "%";
                sqlDataAdapter.SelectCommand.Parameters["@StartFrom"].Value = defaultFromDateFilter;
                sqlDataAdapter.SelectCommand.Parameters["@StartTo"].Value = defaultToDateFilter;
                sqlDataAdapter.SelectCommand.Parameters["@RegFrom"].Value = defaultFromDateFilter;
                sqlDataAdapter.SelectCommand.Parameters["@RegTo"].Value = defaultToDateFilter;
            }
            if (radioBtnStartDate.Checked)
            {
                sqlDataAdapter.SelectCommand.Parameters["@State"].Value = "%%";
                sqlDataAdapter.SelectCommand.Parameters["@StartFrom"].Value = Convert.ToDateTime(dateTimePickerFromStart.Value);
                sqlDataAdapter.SelectCommand.Parameters["@StartTo"].Value = Convert.ToDateTime(dateTimePickerToStart.Value);
                sqlDataAdapter.SelectCommand.Parameters["@RegFrom"].Value = defaultFromDateFilter;
                sqlDataAdapter.SelectCommand.Parameters["@RegTo"].Value = defaultToDateFilter;
            }
            if (radioBtnRegDate.Checked)
            {
                sqlDataAdapter.SelectCommand.Parameters["@State"].Value = "%%";
                sqlDataAdapter.SelectCommand.Parameters["@StartFrom"].Value = defaultFromDateFilter;
                sqlDataAdapter.SelectCommand.Parameters["@StartTo"].Value = defaultToDateFilter;
                sqlDataAdapter.SelectCommand.Parameters["@RegFrom"].Value = Convert.ToDateTime(dateTimePickerFromReg.Value);
                sqlDataAdapter.SelectCommand.Parameters["@RegTo"].Value = Convert.ToDateTime(dateTimePickerToReg.Value);
            }
            sqlDataAdapter.Fill(dataSetTournaments);
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            Form statisticForm = new StatisticForm();
            statisticForm.ShowDialog();
        }
    }
}
