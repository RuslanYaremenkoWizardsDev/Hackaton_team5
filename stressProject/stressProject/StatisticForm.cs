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
        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;


        public StatisticForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                DataTable playerStatsTab = new DataTable();
                sqlDataAdapter = new SqlDataAdapter("SELECT  Players.Login, PlayerStats.GamesCount, PlayerStats.WinsCount, PlayerStats.DrawsCount, PlayerStats.LosesCount, PlayerStats.CupWinsCount FROM PlayerStats INNER JOIN Players ON PlayerStats.PlayerID = Players.ID", sqlConnection);
                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.Fill(playerStatsTab);
                dataGridViewPlayerStats.DataSource = playerStatsTab;

                DataTable tournamentStatsTab = new DataTable();
                sqlDataAdapter = new SqlDataAdapter("SELECT NumberOfTournaments, ActiveTournaments, FinishedTournaments, NotStartedTournaments FROM  TournamentStats", sqlConnection);
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
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Наташа\source\repos\NewRepo\Hackaton_team5\stressProject\stressProject\Sport.mdf;Integrated Security=True;Connect Timeout=30");
            sqlConnection.Open();

            LoadData();
        }
    }
}
