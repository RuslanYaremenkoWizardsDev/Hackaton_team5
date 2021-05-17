namespace stressProject
{
    partial class frmTournaments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTournaments));
            this.dataGridViewTournaments = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastRegistrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelOfTournamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfParticipantsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scenarioForTournamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.linkLblLogout = new System.Windows.Forms.LinkLabel();
            this.radioBtnStartDate = new System.Windows.Forms.RadioButton();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.lblToRegDate = new System.Windows.Forms.Label();
            this.lblFromRegDate = new System.Windows.Forms.Label();
            this.lblToStartDate = new System.Windows.Forms.Label();
            this.lblFromStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerToReg = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerToStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromReg = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromStart = new System.Windows.Forms.DateTimePicker();
            this.radioBtnState = new System.Windows.Forms.RadioButton();
            this.radioBtnRegDate = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTournaments)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTournaments
            // 
            this.dataGridViewTournaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTournaments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.modeDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.lastRegistrationDateDataGridViewTextBoxColumn,
            this.levelOfTournamentDataGridViewTextBoxColumn,
            this.numberOfParticipantsDataGridViewTextBoxColumn,
            this.scenarioForTournamentDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.Actions});
            this.dataGridViewTournaments.DataMember = "Tournaments";
            this.dataGridViewTournaments.Location = new System.Drawing.Point(24, 200);
            this.dataGridViewTournaments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewTournaments.Name = "dataGridViewTournaments";
            this.dataGridViewTournaments.RowHeadersWidth = 51;
            this.dataGridViewTournaments.Size = new System.Drawing.Size(1415, 408);
            this.dataGridViewTournaments.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // modeDataGridViewTextBoxColumn
            // 
            this.modeDataGridViewTextBoxColumn.DataPropertyName = "Mode";
            this.modeDataGridViewTextBoxColumn.HeaderText = "Mode";
            this.modeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modeDataGridViewTextBoxColumn.Name = "modeDataGridViewTextBoxColumn";
            this.modeDataGridViewTextBoxColumn.Width = 125;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Place";
            this.placeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastRegistrationDateDataGridViewTextBoxColumn
            // 
            this.lastRegistrationDateDataGridViewTextBoxColumn.DataPropertyName = "LastRegistrationDate";
            this.lastRegistrationDateDataGridViewTextBoxColumn.HeaderText = "LastRegistrationDate";
            this.lastRegistrationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastRegistrationDateDataGridViewTextBoxColumn.Name = "lastRegistrationDateDataGridViewTextBoxColumn";
            this.lastRegistrationDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // levelOfTournamentDataGridViewTextBoxColumn
            // 
            this.levelOfTournamentDataGridViewTextBoxColumn.DataPropertyName = "LevelOfTournament";
            this.levelOfTournamentDataGridViewTextBoxColumn.HeaderText = "LevelOfTournament";
            this.levelOfTournamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.levelOfTournamentDataGridViewTextBoxColumn.Name = "levelOfTournamentDataGridViewTextBoxColumn";
            this.levelOfTournamentDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfParticipantsDataGridViewTextBoxColumn
            // 
            this.numberOfParticipantsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfParticipants";
            this.numberOfParticipantsDataGridViewTextBoxColumn.HeaderText = "NumberOfParticipants";
            this.numberOfParticipantsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfParticipantsDataGridViewTextBoxColumn.Name = "numberOfParticipantsDataGridViewTextBoxColumn";
            this.numberOfParticipantsDataGridViewTextBoxColumn.Width = 125;
            // 
            // scenarioForTournamentDataGridViewTextBoxColumn
            // 
            this.scenarioForTournamentDataGridViewTextBoxColumn.DataPropertyName = "ScenarioForTournament";
            this.scenarioForTournamentDataGridViewTextBoxColumn.HeaderText = "ScenarioForTournament";
            this.scenarioForTournamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scenarioForTournamentDataGridViewTextBoxColumn.Name = "scenarioForTournamentDataGridViewTextBoxColumn";
            this.scenarioForTournamentDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.Width = 125;
            // 
            // Actions
            // 
            this.Actions.HeaderText = "Actions";
            this.Actions.MinimumWidth = 6;
            this.Actions.Name = "Actions";
            this.Actions.Width = 125;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.CommandTimeout = 30;
            this.sqlSelectCommand1.Connection = null;
            this.sqlSelectCommand1.Notification = null;
            this.sqlSelectCommand1.Transaction = null;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.Location = new System.Drawing.Point(42, 14);
            this.btnCreateTournament.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(229, 56);
            this.btnCreateTournament.TabIndex = 1;
            this.btnCreateTournament.Text = "Create Tournaments";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            this.btnCreateTournament.Click += new System.EventHandler(this.btnCreateTournament_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(350, 14);
            this.btnStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(229, 56);
            this.btnStats.TabIndex = 1;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // linkLblLogout
            // 
            this.linkLblLogout.AutoSize = true;
            this.linkLblLogout.Location = new System.Drawing.Point(1260, 14);
            this.linkLblLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLblLogout.Name = "linkLblLogout";
            this.linkLblLogout.Size = new System.Drawing.Size(60, 20);
            this.linkLblLogout.TabIndex = 2;
            this.linkLblLogout.TabStop = true;
            this.linkLblLogout.Text = "Log out";
            this.linkLblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblLogout_LinkClicked);
            // 
            // radioBtnStartDate
            // 
            this.radioBtnStartDate.AutoSize = true;
            this.radioBtnStartDate.Location = new System.Drawing.Point(8, 42);
            this.radioBtnStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnStartDate.Name = "radioBtnStartDate";
            this.radioBtnStartDate.Size = new System.Drawing.Size(93, 24);
            this.radioBtnStartDate.TabIndex = 3;
            this.radioBtnStartDate.TabStop = true;
            this.radioBtnStartDate.Text = "StartDate";
            this.radioBtnStartDate.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSearch.Controls.Add(this.btnClear);
            this.groupBoxSearch.Controls.Add(this.btnFilter);
            this.groupBoxSearch.Controls.Add(this.comboBoxState);
            this.groupBoxSearch.Controls.Add(this.lblToRegDate);
            this.groupBoxSearch.Controls.Add(this.lblFromRegDate);
            this.groupBoxSearch.Controls.Add(this.lblToStartDate);
            this.groupBoxSearch.Controls.Add(this.lblFromStartDate);
            this.groupBoxSearch.Controls.Add(this.dateTimePickerToReg);
            this.groupBoxSearch.Controls.Add(this.dateTimePickerToStart);
            this.groupBoxSearch.Controls.Add(this.dateTimePickerFromReg);
            this.groupBoxSearch.Controls.Add(this.dateTimePickerFromStart);
            this.groupBoxSearch.Controls.Add(this.radioBtnState);
            this.groupBoxSearch.Controls.Add(this.radioBtnRegDate);
            this.groupBoxSearch.Controls.Add(this.radioBtnStartDate);
            this.groupBoxSearch.Location = new System.Drawing.Point(16, 63);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSearch.Size = new System.Drawing.Size(981, 128);
            this.groupBoxSearch.TabIndex = 4;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "FilterRecords";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(867, 77);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "ClearFilter";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(867, 32);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 35);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "In progress",
            "Registration",
            "Finished"});
            this.comboBoxState.Location = new System.Drawing.Point(697, 40);
            this.comboBoxState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(160, 28);
            this.comboBoxState.TabIndex = 7;
            // 
            // lblToRegDate
            // 
            this.lblToRegDate.AutoSize = true;
            this.lblToRegDate.Location = new System.Drawing.Point(413, 82);
            this.lblToRegDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToRegDate.Name = "lblToRegDate";
            this.lblToRegDate.Size = new System.Drawing.Size(25, 20);
            this.lblToRegDate.TabIndex = 6;
            this.lblToRegDate.Text = "To";
            // 
            // lblFromRegDate
            // 
            this.lblFromRegDate.AutoSize = true;
            this.lblFromRegDate.Location = new System.Drawing.Point(413, 32);
            this.lblFromRegDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromRegDate.Name = "lblFromRegDate";
            this.lblFromRegDate.Size = new System.Drawing.Size(43, 20);
            this.lblFromRegDate.TabIndex = 5;
            this.lblFromRegDate.Text = "From";
            // 
            // lblToStartDate
            // 
            this.lblToStartDate.AutoSize = true;
            this.lblToStartDate.Location = new System.Drawing.Point(113, 82);
            this.lblToStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToStartDate.Name = "lblToStartDate";
            this.lblToStartDate.Size = new System.Drawing.Size(25, 20);
            this.lblToStartDate.TabIndex = 6;
            this.lblToStartDate.Text = "To";
            // 
            // lblFromStartDate
            // 
            this.lblFromStartDate.AutoSize = true;
            this.lblFromStartDate.Location = new System.Drawing.Point(113, 32);
            this.lblFromStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFromStartDate.Name = "lblFromStartDate";
            this.lblFromStartDate.Size = new System.Drawing.Size(43, 20);
            this.lblFromStartDate.TabIndex = 5;
            this.lblFromStartDate.Text = "From";
            // 
            // dateTimePickerToReg
            // 
            this.dateTimePickerToReg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerToReg.Location = new System.Drawing.Point(461, 74);
            this.dateTimePickerToReg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerToReg.Name = "dateTimePickerToReg";
            this.dateTimePickerToReg.Size = new System.Drawing.Size(152, 27);
            this.dateTimePickerToReg.TabIndex = 5;
            // 
            // dateTimePickerToStart
            // 
            this.dateTimePickerToStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerToStart.Location = new System.Drawing.Point(161, 72);
            this.dateTimePickerToStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerToStart.Name = "dateTimePickerToStart";
            this.dateTimePickerToStart.Size = new System.Drawing.Size(152, 27);
            this.dateTimePickerToStart.TabIndex = 5;
            // 
            // dateTimePickerFromReg
            // 
            this.dateTimePickerFromReg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFromReg.Location = new System.Drawing.Point(461, 25);
            this.dateTimePickerFromReg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerFromReg.Name = "dateTimePickerFromReg";
            this.dateTimePickerFromReg.Size = new System.Drawing.Size(152, 27);
            this.dateTimePickerFromReg.TabIndex = 5;
            // 
            // dateTimePickerFromStart
            // 
            this.dateTimePickerFromStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFromStart.Location = new System.Drawing.Point(161, 23);
            this.dateTimePickerFromStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerFromStart.Name = "dateTimePickerFromStart";
            this.dateTimePickerFromStart.Size = new System.Drawing.Size(152, 27);
            this.dateTimePickerFromStart.TabIndex = 5;
            // 
            // radioBtnState
            // 
            this.radioBtnState.AutoSize = true;
            this.radioBtnState.Location = new System.Drawing.Point(623, 42);
            this.radioBtnState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnState.Name = "radioBtnState";
            this.radioBtnState.Size = new System.Drawing.Size(64, 24);
            this.radioBtnState.TabIndex = 3;
            this.radioBtnState.TabStop = true;
            this.radioBtnState.Text = "State";
            this.radioBtnState.UseVisualStyleBackColor = true;
            // 
            // radioBtnRegDate
            // 
            this.radioBtnRegDate.AutoSize = true;
            this.radioBtnRegDate.Location = new System.Drawing.Point(323, 42);
            this.radioBtnRegDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnRegDate.Name = "radioBtnRegDate";
            this.radioBtnRegDate.Size = new System.Drawing.Size(88, 24);
            this.radioBtnRegDate.TabIndex = 3;
            this.radioBtnRegDate.TabStop = true;
            this.radioBtnRegDate.Text = "RegDate";
            this.radioBtnRegDate.UseVisualStyleBackColor = true;
            // 
            // frmTournaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::stressProject.Properties.Resources.photo_2021_05_16_16_02_21;
            this.ClientSize = new System.Drawing.Size(1447, 652);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.linkLblLogout);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.dataGridViewTournaments);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTournaments";
            this.Text = "Tournaments";
            this.Load += new System.EventHandler(this.frmTournaments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTournaments)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTournaments;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Windows.Forms.Button btnCreateTournament;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.LinkLabel linkLblLogout;
        private System.Windows.Forms.RadioButton radioBtnStartDate;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label lblToRegDate;
        private System.Windows.Forms.Label lblFromRegDate;
        private System.Windows.Forms.Label lblToStartDate;
        private System.Windows.Forms.Label lblFromStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerToReg;
        private System.Windows.Forms.DateTimePicker dateTimePickerToStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromReg;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromStart;
        private System.Windows.Forms.RadioButton radioBtnState;
        private System.Windows.Forms.RadioButton radioBtnRegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastRegistrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelOfTournamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfParticipantsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scenarioForTournamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Actions;


    }
}

