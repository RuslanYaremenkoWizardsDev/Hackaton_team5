
namespace stressProject
{
    partial class TournamentCreation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelNameOfTournament = new System.Windows.Forms.Label();
            this.labelTournamentDescription = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelLastRegistrationDate = new System.Windows.Forms.Label();
            this.dateTimePickerLastRegistrationDay = new System.Windows.Forms.DateTimePicker();
            this.labelLevelOfTornament = new System.Windows.Forms.Label();
            this.labelNumberOfParticipants = new System.Windows.Forms.Label();
            this.comboBoxCountPlayers = new System.Windows.Forms.ComboBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxScenario = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonTournamentsPage = new System.Windows.Forms.Button();
            this.buttonStatisticsPage = new System.Windows.Forms.Button();
            this.buttonLogOutFromTournamentCreation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(206, 250);
            this.textBoxPlace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(228, 27);
            this.textBoxPlace.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(206, 125);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(228, 27);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(206, 160);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(228, 27);
            this.textBoxDescription.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(587, 98);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(502, 716);
            this.dataGridView1.TabIndex = 1;
            // 
            // labelNameOfTournament
            // 
            this.labelNameOfTournament.AutoSize = true;
            this.labelNameOfTournament.BackColor = System.Drawing.Color.Transparent;
            this.labelNameOfTournament.Location = new System.Drawing.Point(30, 132);
            this.labelNameOfTournament.Name = "labelNameOfTournament";
            this.labelNameOfTournament.Size = new System.Drawing.Size(148, 20);
            this.labelNameOfTournament.TabIndex = 2;
            this.labelNameOfTournament.Text = "Name of tournament";
            // 
            // labelTournamentDescription
            // 
            this.labelTournamentDescription.AutoSize = true;
            this.labelTournamentDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelTournamentDescription.Location = new System.Drawing.Point(30, 167);
            this.labelTournamentDescription.Name = "labelTournamentDescription";
            this.labelTournamentDescription.Size = new System.Drawing.Size(166, 20);
            this.labelTournamentDescription.TabIndex = 3;
            this.labelTournamentDescription.Text = "Tournament description";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.BackColor = System.Drawing.Color.Transparent;
            this.labelMode.Location = new System.Drawing.Point(30, 213);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(48, 20);
            this.labelMode.TabIndex = 4;
            this.labelMode.Text = "Mode";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.BackColor = System.Drawing.Color.Transparent;
            this.labelPlace.Location = new System.Drawing.Point(30, 257);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(107, 20);
            this.labelPlace.TabIndex = 7;
            this.labelPlace.Text = "Name of place";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.BackColor = System.Drawing.Color.Transparent;
            this.labelStartDate.Location = new System.Drawing.Point(30, 306);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(74, 20);
            this.labelStartDate.TabIndex = 8;
            this.labelStartDate.Text = "Start date";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(206, 299);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(153, 27);
            this.dateTimePickerStartDate.TabIndex = 9;
            // 
            // labelLastRegistrationDate
            // 
            this.labelLastRegistrationDate.AutoSize = true;
            this.labelLastRegistrationDate.BackColor = System.Drawing.Color.Transparent;
            this.labelLastRegistrationDate.Location = new System.Drawing.Point(30, 348);
            this.labelLastRegistrationDate.Name = "labelLastRegistrationDate";
            this.labelLastRegistrationDate.Size = new System.Drawing.Size(149, 20);
            this.labelLastRegistrationDate.TabIndex = 8;
            this.labelLastRegistrationDate.Text = "Last registration date";
            // 
            // dateTimePickerLastRegistrationDay
            // 
            this.dateTimePickerLastRegistrationDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerLastRegistrationDay.Location = new System.Drawing.Point(206, 341);
            this.dateTimePickerLastRegistrationDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerLastRegistrationDay.Name = "dateTimePickerLastRegistrationDay";
            this.dateTimePickerLastRegistrationDay.Size = new System.Drawing.Size(153, 27);
            this.dateTimePickerLastRegistrationDay.TabIndex = 9;
            // 
            // labelLevelOfTornament
            // 
            this.labelLevelOfTornament.AutoSize = true;
            this.labelLevelOfTornament.BackColor = System.Drawing.Color.Transparent;
            this.labelLevelOfTornament.Location = new System.Drawing.Point(30, 393);
            this.labelLevelOfTornament.Name = "labelLevelOfTornament";
            this.labelLevelOfTornament.Size = new System.Drawing.Size(142, 20);
            this.labelLevelOfTornament.TabIndex = 10;
            this.labelLevelOfTornament.Text = "Level of tournament";
            // 
            // labelNumberOfParticipants
            // 
            this.labelNumberOfParticipants.AutoSize = true;
            this.labelNumberOfParticipants.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberOfParticipants.Location = new System.Drawing.Point(30, 438);
            this.labelNumberOfParticipants.Name = "labelNumberOfParticipants";
            this.labelNumberOfParticipants.Size = new System.Drawing.Size(163, 20);
            this.labelNumberOfParticipants.TabIndex = 13;
            this.labelNumberOfParticipants.Text = "Number of participants";
            // 
            // comboBoxCountPlayers
            // 
            this.comboBoxCountPlayers.FormattingEnabled = true;
            this.comboBoxCountPlayers.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "32",
            "64",
            "128"});
            this.comboBoxCountPlayers.Location = new System.Drawing.Point(208, 430);
            this.comboBoxCountPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCountPlayers.Name = "comboBoxCountPlayers";
            this.comboBoxCountPlayers.Size = new System.Drawing.Size(153, 28);
            this.comboBoxCountPlayers.TabIndex = 14;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Cup",
            "Championship"});
            this.comboBoxMode.Location = new System.Drawing.Point(206, 205);
            this.comboBoxMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(153, 28);
            this.comboBoxMode.TabIndex = 15;
            this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "Begginer",
            "Middle",
            "Advanced"});
            this.comboBoxLevel.Location = new System.Drawing.Point(206, 385);
            this.comboBoxLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(153, 28);
            this.comboBoxLevel.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(30, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Scenario for tournament";
            // 
            // comboBoxScenario
            // 
            this.comboBoxScenario.FormattingEnabled = true;
            this.comboBoxScenario.Items.AddRange(new object[] {
            "one-match confrotation",
            "two-match confrotation",
            "to three wins"});
            this.comboBoxScenario.Location = new System.Drawing.Point(206, 475);
            this.comboBoxScenario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxScenario.Name = "comboBoxScenario";
            this.comboBoxScenario.Size = new System.Drawing.Size(155, 28);
            this.comboBoxScenario.TabIndex = 18;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSave.Location = new System.Drawing.Point(206, 549);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(134, 31);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTournamentsPage
            // 
            this.buttonTournamentsPage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonTournamentsPage.Location = new System.Drawing.Point(30, 28);
            this.buttonTournamentsPage.Name = "buttonTournamentsPage";
            this.buttonTournamentsPage.Size = new System.Drawing.Size(229, 56);
            this.buttonTournamentsPage.TabIndex = 22;
            this.buttonTournamentsPage.Text = "Tournaments";
            this.buttonTournamentsPage.UseVisualStyleBackColor = false;
            this.buttonTournamentsPage.Click += new System.EventHandler(this.buttonTournamentsPage_Click);
            // 
            // buttonStatisticsPage
            // 
            this.buttonStatisticsPage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonStatisticsPage.Location = new System.Drawing.Point(312, 28);
            this.buttonStatisticsPage.Name = "buttonStatisticsPage";
            this.buttonStatisticsPage.Size = new System.Drawing.Size(229, 56);
            this.buttonStatisticsPage.TabIndex = 22;
            this.buttonStatisticsPage.Text = "Statistics";
            this.buttonStatisticsPage.UseVisualStyleBackColor = false;
            this.buttonStatisticsPage.Click += new System.EventHandler(this.buttonStatisticsPage_Click);
            // 
            // buttonLogOutFromTournamentCreation
            // 
            this.buttonLogOutFromTournamentCreation.Location = new System.Drawing.Point(991, 36);
            this.buttonLogOutFromTournamentCreation.Name = "buttonLogOutFromTournamentCreation";
            this.buttonLogOutFromTournamentCreation.Size = new System.Drawing.Size(98, 40);
            this.buttonLogOutFromTournamentCreation.TabIndex = 23;
            this.buttonLogOutFromTournamentCreation.Text = "LogOut";
            this.buttonLogOutFromTournamentCreation.UseVisualStyleBackColor = true;
            this.buttonLogOutFromTournamentCreation.Click += new System.EventHandler(this.buttonLogOutFromTournamentCreation_Click);
            // 
            // TournamentCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::stressProject.Properties.Resources.photo_2021_05_16_16_02_21;
            this.ClientSize = new System.Drawing.Size(1125, 1015);
            this.Controls.Add(this.buttonLogOutFromTournamentCreation);
            this.Controls.Add(this.buttonStatisticsPage);
            this.Controls.Add(this.buttonTournamentsPage);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxScenario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.comboBoxCountPlayers);
            this.Controls.Add(this.labelNumberOfParticipants);
            this.Controls.Add(this.labelLevelOfTornament);
            this.Controls.Add(this.dateTimePickerLastRegistrationDay);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.labelLastRegistrationDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.labelTournamentDescription);
            this.Controls.Add(this.labelNameOfTournament);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPlace);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TournamentCreation";
            this.Text = "TournamentCreation";
            this.Load += new System.EventHandler(this.TournamentCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelNameOfTournament;
        private System.Windows.Forms.Label labelTournamentDescription;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label labelLastRegistrationDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastRegistrationDay;
        private System.Windows.Forms.Label labelLevelOfTornament;
        private System.Windows.Forms.Label labelNumberOfParticipants;
        private System.Windows.Forms.ComboBox comboBoxCountPlayers;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxScenario;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonTournamentsPage;
        private System.Windows.Forms.Button buttonStatisticsPage;
        private System.Windows.Forms.Button buttonLogOutFromTournamentCreation;
    }
}