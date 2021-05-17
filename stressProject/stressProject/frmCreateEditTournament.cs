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
    public partial class frmCreateEditTournament : Form
    {
        public DataSet _dsMain;
        public SqlDataAdapter _daMain;
        public SqlConnection _cnMain;

        public frmCreateEditTournament(SqlConnection sqlConnectionHackathon, SqlDataAdapter sqlDataAdapter, DataSet DataSetTournaments)
        {
            _cnMain = sqlConnectionHackathon;
            _daMain = sqlDataAdapter;
            _dsMain = DataSetTournaments;
            InitializeComponent();
        }

        private void frmCreateEditTournament_Load(object sender, EventArgs e)
        {
            dateTimePickerStartDate.CustomFormat = "yyyy/MM/dd hh:mm";
            dateTimePickerLastRegDate.CustomFormat = "yyyy/MM/dd hh:mm";
            comboBoxMode.SelectedIndex = 0;
            comboBoxState.SelectedIndex = 1;
            comboBoxLevel.SelectedIndex = 1;
            comboBoxParticipants.SelectedIndex = 3;
            comboBoxScenario.SelectedIndex = 2;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _daMain.InsertCommand.Parameters["@Name"].Value = txtName.Text;
            _daMain.InsertCommand.Parameters["@Description"].Value = txtDescription.Text;
            _daMain.InsertCommand.Parameters["@Mode"].Value = comboBoxMode.Text;
            _daMain.InsertCommand.Parameters["@Place"].Value = txtPlace.Text;
            _daMain.InsertCommand.Parameters["@StartDate"].Value = Convert.ToDateTime(dateTimePickerStartDate.Text);
            _daMain.InsertCommand.Parameters["@LastRegistrationDate"].Value = Convert.ToDateTime(dateTimePickerLastRegDate.Text);
            _daMain.InsertCommand.Parameters["@LevelOfTournament"].Value = comboBoxLevel.Text;
            _daMain.InsertCommand.Parameters["@NumberOfParticipants"].Value = comboBoxParticipants.Text;
            _daMain.InsertCommand.Parameters["@ScenarioForTournament"].Value = comboBoxScenario.Text;
            _daMain.InsertCommand.Parameters["@State"].Value = comboBoxState.Text;
            _cnMain.Open();
            _daMain.InsertCommand.ExecuteNonQuery();
            _cnMain.Close();
            _dsMain.Clear();
            _daMain.Fill(_dsMain);
        }
    }
}
