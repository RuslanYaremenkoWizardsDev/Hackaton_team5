using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace stressProject
{
    public partial class TournamentCreation : Form
    {
        public TournamentCreation()
        {
            InitializeComponent();
        }

        string _connect = Properties.Settings.Default.Conecction;

        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;
        BindingSource bindingSource = new BindingSource();

        SqlDataAdapter daUser;
        SqlCommandBuilder bdUser;
        BindingSource bd2 = new BindingSource();
        DataTable taUser = new DataTable();

        //private bool newRowAdding = false;

        public void Loading()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            _connect = Properties.Settings.Default.Conecction;
            SqlConnection cnn = new SqlConnection(_connect);
            cnn.Open();

            DataTable dt2 = new DataTable();
            daUser = new SqlDataAdapter("SELECT * FROM Tournaments", cnn);
            bdUser = new SqlCommandBuilder(daUser);
            daUser.Fill(dt2);

            bd2.DataSource = dt2;
            dataGridView1.DataSource = bd2;

            dataGridView1.Columns[0].Visible = false;
        }
        private void TournamentCreation_Load(object sender, EventArgs e)
        {
            Loading();
            dateTimePickerStartDate.CustomFormat = "yyyy/MM/dd hh:mm";
            dateTimePickerLastRegistrationDay.CustomFormat = "yyyy/MM/dd hh:mm";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(_connect);
                conn.Open();
                string sql;
                int x = 0;
                sql = "Select * FROM Tournaments WHERE Name=@Name";
                using (SqlCommand myCommand = new SqlCommand(sql, conn))
                {
                    myCommand.Parameters.AddWithValue("@Name", textBoxName.Text);
                    myCommand.Parameters.AddWithValue("@Description", textBoxDescription.Text);
                    myCommand.Parameters.AddWithValue("@Mode", comboBoxMode.SelectedItem);
                    myCommand.Parameters.AddWithValue("@Place", textBoxPlace.Text);
                    myCommand.Parameters.AddWithValue("@StartDate", dateTimePickerStartDate.Value);
                    myCommand.Parameters.AddWithValue("@LastRegistrationDate", dateTimePickerLastRegistrationDay.Value);
                    myCommand.Parameters.AddWithValue("@LevelOfTournament", comboBoxLevel.SelectedItem);
                    myCommand.Parameters.AddWithValue("@NumberOfParticipants", comboBoxCountPlayers.SelectedItem);
                    myCommand.Parameters.AddWithValue("@ScenarioForTournament", comboBoxScenario.SelectedItem);
                    SqlDataReader reader = myCommand.ExecuteReader();
                    while (reader.Read()) x++; reader.Close();
                }
                if (x == 0)
                {
                    sql = "INSERT INTO Tournaments(Name,Description,Mode,Place,StartDate,LastRegistrationDate,LevelOfTournament,NumberOfParticipants,ScenarioForTournament)values" +
                        "(@Name,@Description,@Mode,@Place,@StartDate,@LastRegistrationDate,@LevelOfTournament,@NumberOfParticipants,@ScenarioForTournament)";
                    using (SqlCommand myCommand = new SqlCommand(sql, conn))
                    {
                        myCommand.Parameters.AddWithValue("@Name", textBoxName.Text);
                        myCommand.Parameters.AddWithValue("@Description", textBoxDescription.Text);
                        myCommand.Parameters.AddWithValue("@Mode", comboBoxMode.SelectedItem);
                        myCommand.Parameters.AddWithValue("@Place", textBoxPlace.Text);
                        myCommand.Parameters.AddWithValue("@StartDate", dateTimePickerStartDate.Value);
                        myCommand.Parameters.AddWithValue("@LastRegistrationDate", dateTimePickerLastRegistrationDay.Value);
                        myCommand.Parameters.AddWithValue("@LevelOfTournament", comboBoxLevel.SelectedItem);
                        myCommand.Parameters.AddWithValue("@NumberOfParticipants", comboBoxCountPlayers.SelectedItem);
                        myCommand.Parameters.AddWithValue("@ScenarioForTournament", comboBoxScenario.SelectedItem);
                        myCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Insert");
                }
                else
                {
                    sql = "UPDATE Products SET Name=@Name,Description=@Description,Mode=@Mode,Place=@Place," +
                        "StartDate=@StartDate,LastRegistrationDate=@LastRegistrationDate,LevelOfTournament=@LevelOfTournament,NumberOfParticipants=@NumberOfParticipants,ScenarioForTournament=@ScenarioForTournament WHERE Name=@Name";
                    using (SqlCommand myCommand = new SqlCommand(sql, conn))
                    {
                        myCommand.Parameters.AddWithValue("@Name", textBoxName.Text);
                        myCommand.Parameters.AddWithValue("@Description", textBoxDescription.Text);
                        myCommand.Parameters.AddWithValue("@Mode", comboBoxMode.SelectedItem);
                        myCommand.Parameters.AddWithValue("@Place", textBoxPlace.Text);
                        myCommand.Parameters.AddWithValue("@StartDate", dateTimePickerStartDate.Value);
                        myCommand.Parameters.AddWithValue("@LastRegistrationDate", dateTimePickerLastRegistrationDay.Value);
                        myCommand.Parameters.AddWithValue("@LevelOfTournament", comboBoxLevel.SelectedItem);
                        myCommand.Parameters.AddWithValue("@NumberOfParticipants", comboBoxCountPlayers.SelectedItem);
                        myCommand.Parameters.AddWithValue("@ScenarioForTournament", comboBoxScenario.SelectedItem);
                        myCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Update");
                }
                Loading();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
}

        private void buttonTournamentsPage_Click(object sender, EventArgs e)
        {

        }

        private void buttonStatisticsPage_Click(object sender, EventArgs e)
        {
            Form statistics = new StatisticForm();

            statistics.ShowDialog();
        }

        private void buttonLogOutFromTournamentCreation_Click(object sender, EventArgs e)
        {
            Form login = new AdminPanel();

            login.ShowDialog();
        }

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    //private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
    //{
    //    try
    //    {
    //        if (e.ColumnIndex == 4)
    //        {
    //            string task = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();

    //            if (task == "Delete")
    //            {
    //                if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    //                {
    //                    int rowIndex = e.RowIndex;
    //                    dataGridView2.Rows.RemoveAt(rowIndex);
    //                    dataSet.Tables["Players"].Rows[rowIndex].Delete();

    //                    sqlDataAdapter.Update(dataSet, "Players");
    //                }
    //            }
    //            else if (task == "Insert")
    //            {
    //                int rowIndex = dataGridView2.Rows.Count - 2;

    //                DataRow row = dataSet.Tables["Players"].NewRow();

    //                row["Login"] = dataGridView2.Rows[rowIndex].Cells["Login"].Value;
    //                row["Password"] = dataGridView2.Rows[rowIndex].Cells["Password"].Value;
    //                row["Email"] = dataGridView2.Rows[rowIndex].Cells["Email"].Value;
    //                row["RoleName"] = dataGridView2.Rows[rowIndex].Cells["RoleName"].Value;


    //                dataSet.Tables["Players"].Rows.Add(row);

    //                dataSet.Tables["Players"].Rows.RemoveAt(dataSet.Tables["Players"].Rows.Count - 1);

    //                dataGridView2.Rows.RemoveAt(dataGridView2.Rows.Count - 2);

    //                dataGridView2.Rows[e.RowIndex].Cells[6].Value = "Delete";

    //                sqlDataAdapter.Update(dataSet, "Players");
    //            }
    //            else if (task == "Update")
    //            {
    //                int r = e.RowIndex;

    //                dataSet.Tables["Players"].Rows[r]["Login"] = dataGridView2.Rows[r].Cells["Login"].Value;

    //                sqlDataAdapter.Update(dataSet, "Players");

    //                dataGridView2.Rows[e.RowIndex].Cells[6].Value = "Delete";
    //            }

    //            ReloadData();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //}

    //private void dataGridView2_UserAddedRow(object sender, DataGridViewRowEventArgs e)
    //{
    //    try
    //    {
    //        if (newRowAdding == false)
    //        {
    //            newRowAdding = true;

    //            int lastRow = dataGridView2.Rows.Count - 2;

    //            DataGridViewRow row = dataGridView2.Rows[lastRow];

    //            row.Cells["Delete"].Value = "Insert";
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //}

    //private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    //{
    //    try
    //    {
    //        if(newRowAdding == false)
    //        {
    //            int rowIndex = dataGridView2.SelectedCells[0].RowIndex;

    //            DataGridViewRow editingRow = dataGridView2.Rows[rowIndex];

    //            editingRow.Cells["Delete"].Value = "Update";
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //}

    //private void LoadData()
    //{
    //    try
    //    {
    //        sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Delete' AS [Delete] FROM Players", sqlConnection);
    //        sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

    //        sqlBuilder.GetInsertCommand();
    //        sqlBuilder.GetUpdateCommand();
    //        sqlBuilder.GetDeleteCommand();

    //        dataSet = new DataSet();

    //        sqlDataAdapter.Fill(dataSet, "Players");
    //        dataGridView2.DataSource = dataSet.Tables["Players"];

    //        for(int i = 0; i < dataGridView2.Rows.Count; i++)
    //        {
    //            DataGridViewButtonColumn buttonCell = new DataGridViewButtonColumn();
    //            buttonCell.HeaderText = "Buttons";
    //            dataGridView2.Columns.Add(buttonCell);
    //        }

    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //}

    //private void ReloadData()
    //{
    //    try
    //    {
    //        dataSet.Tables["Players"].Clear();

    //        sqlDataAdapter.Fill(dataSet, "Players");
    //        dataGridView2.DataSource = dataSet.Tables["Players"];
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //}
}
