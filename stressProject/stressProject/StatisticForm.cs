using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace stressProject
{
    public partial class StatisticForm : Form
    {
        private SqlCommandBuilder sqlBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;

        string constr = Properties.Settings.Default.Conecction;
        SqlConnection cnn;

        public StatisticForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                DataTable playerStatsTab = new DataTable();
                sqlDataAdapter = new SqlDataAdapter("SELECT  Players.Login, PlayerStats.GamesCount, PlayerStats.WinsCount, PlayerStats.DrawsCount, PlayerStats.LosesCount, PlayerStats.CupWinsCount FROM PlayerStats INNER JOIN Players ON PlayerStats.PlayerID = Players.ID ORDER BY WinsCount DESC", cnn);
                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.Fill(playerStatsTab);
                dataGridViewPlayerStats.DataSource = playerStatsTab;

                DataTable tournamentStatsTab = new DataTable();
                sqlDataAdapter = new SqlDataAdapter("SELECT NumberOfTournaments, ActiveTournaments, FinishedTournaments, NotStartedTournaments FROM  TournamentStats", cnn);
                sqlDataAdapter.Fill(tournamentStatsTab);
                dataGridViewTournamentStats.DataSource = tournamentStatsTab;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void StatisticForm_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(constr);
            cnn.Open();

            LoadData();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Form login = new AdminPanel();

            login.ShowDialog();
        }

        private void tournamentsBtn_Click(object sender, EventArgs e)
        {
            Form tournament = new frmTournaments();

            tournament.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form createTournament = new TournamentCreation();

            createTournament.ShowDialog();
        }
    }
}
