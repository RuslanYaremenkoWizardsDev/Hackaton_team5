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

        //private bool newRowAdding = false;

        private void UpdateDataBase()
        {
            sqlConnection = new SqlConnection(_connect);
            sqlConnection.Open();

            DataTable dataTable = new DataTable();

            sqlDataAdapter = new SqlDataAdapter("SELECT *FROM Tournaments", sqlConnection);
            sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
        }

        private void TournamentCreation_Load(object sender, EventArgs e)
        {
            UpdateDataBase();
            dateTimePickerStartDate.CustomFormat = "yyyy/MM/dd hh:mm";
            dateTimePickerLastRegistrationDay.CustomFormat = "yyyy/MM/dd hh:mm";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string name = textBoxName.Text;
                string description = textBoxDescription.Text;
                string place = textBoxPlace.Text;
                string mode = comboBoxMode.Text;
                DateTime startDate = Convert.ToDateTime(dateTimePickerStartDate.Text);
                DateTime lastDate = Convert.ToDateTime(dateTimePickerLastRegistrationDay.Text);
                string levelOfTournament = comboBoxLevel.Text;
                string numberOfParticipants = comboBoxCountPlayers.Text;
                string scenarioForTournament = comboBoxScenario.Text;

                int x = 0;
                string sql;

                SqlConnection connection = new SqlConnection(_connect);
                connection.Open();
                sql = "SELECT * FROM Tournaments WHERE Name = @Name";

                using (SqlCommand myCommand = new SqlCommand(sql, connection))
                {
                    myCommand.Parameters.AddWithValue("@Name", name);

                    SqlDataReader sqlDataReader = myCommand.ExecuteReader();
                    while (sqlDataReader.Read()) x++; sqlDataReader.Close();
                }

                if (x == 0)
                {
                    sql = "INSERT INTO Tournaments(Name,Description,Mode,Place,StarDate,LastRegistrationDate,LevelOfTournament,NumberOfParticipants,ScenarioForTournament)values" +
                        "(@Name,@Description,@Mode,@Place,@StarDate,@LastRegistrationDate,@LevelOfTournament,@NumberOfParticipants,@ScenarioForTournament)";

                    using (SqlCommand myCommand = new SqlCommand(sql, connection))
                    {
                        myCommand.Parameters.AddWithValue("@Name", name);
                        myCommand.Parameters.AddWithValue("@Description", description);
                        myCommand.Parameters.AddWithValue("@Mode", mode);
                        myCommand.Parameters.AddWithValue("@Place", place);
                        myCommand.Parameters.AddWithValue("@StartDate", dateTimePickerStartDate.Value);
                        myCommand.Parameters.AddWithValue("@LastRegistrationDate", dateTimePickerLastRegistrationDay.Value);
                        myCommand.Parameters.AddWithValue("@LevelOfTournament", levelOfTournament);
                        myCommand.Parameters.AddWithValue("@NumberOfParticipants", numberOfParticipants);
                        myCommand.Parameters.AddWithValue("@ScenarioForTournament", scenarioForTournament);
                        myCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Added");
                }

                UpdateDataBase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong");
            }
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
