namespace stressProject
{
    partial class frmCreateEditTournament
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLastRegDate = new System.Windows.Forms.DateTimePicker();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblRegDate = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.comboBoxParticipants = new System.Windows.Forms.ComboBox();
            this.lblParticipants = new System.Windows.Forms.Label();
            this.lblScenario = new System.Windows.Forms.Label();
            this.comboBoxScenario = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            //this.dataSetTournaments = new stressProject.DataSetTournaments();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapterAddTournament = new System.Data.SqlClient.SqlDataAdapter();
            //((System.ComponentModel.ISupportInitialize)(this.dataSetTournaments)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(99, 38);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(149, 73);
            this.txtDescription.TabIndex = 1;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(99, 170);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerStartDate.TabIndex = 4;
            // 
            // dateTimePickerLastRegDate
            // 
            this.dateTimePickerLastRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerLastRegDate.Location = new System.Drawing.Point(99, 196);
            this.dateTimePickerLastRegDate.Name = "dateTimePickerLastRegDate";
            this.dateTimePickerLastRegDate.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerLastRegDate.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(23, 41);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(23, 147);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(34, 13);
            this.lblPlace.TabIndex = 5;
            this.lblPlace.Text = "Place";
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "In progress",
            "Registration",
            "Finished"});
            this.comboBoxState.Location = new System.Drawing.Point(99, 222);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(149, 21);
            this.comboBoxState.TabIndex = 8;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(99, 144);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(149, 20);
            this.txtPlace.TabIndex = 9;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(25, 225);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "State";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Cup",
            "Tournament"});
            this.comboBoxMode.Location = new System.Drawing.Point(99, 117);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(149, 21);
            this.comboBoxMode.TabIndex = 10;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(24, 120);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(34, 13);
            this.lblMode.TabIndex = 5;
            this.lblMode.Text = "Mode";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(23, 176);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(52, 13);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "StartDate";
            // 
            // lblRegDate
            // 
            this.lblRegDate.AutoSize = true;
            this.lblRegDate.Location = new System.Drawing.Point(23, 202);
            this.lblRegDate.Name = "lblRegDate";
            this.lblRegDate.Size = new System.Drawing.Size(70, 13);
            this.lblRegDate.TabIndex = 5;
            this.lblRegDate.Text = "LastRegDate";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(26, 252);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 13);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "Level";
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "Advanced",
            "Middle",
            "Begginer"});
            this.comboBoxLevel.Location = new System.Drawing.Point(99, 249);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(149, 21);
            this.comboBoxLevel.TabIndex = 8;
            // 
            // comboBoxParticipants
            // 
            this.comboBoxParticipants.FormattingEnabled = true;
            this.comboBoxParticipants.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "32",
            "64",
            "128"});
            this.comboBoxParticipants.Location = new System.Drawing.Point(99, 276);
            this.comboBoxParticipants.Name = "comboBoxParticipants";
            this.comboBoxParticipants.Size = new System.Drawing.Size(149, 21);
            this.comboBoxParticipants.TabIndex = 8;
            // 
            // lblParticipants
            // 
            this.lblParticipants.AutoSize = true;
            this.lblParticipants.Location = new System.Drawing.Point(26, 279);
            this.lblParticipants.Name = "lblParticipants";
            this.lblParticipants.Size = new System.Drawing.Size(62, 13);
            this.lblParticipants.TabIndex = 5;
            this.lblParticipants.Text = "Participants";
            // 
            // lblScenario
            // 
            this.lblScenario.AutoSize = true;
            this.lblScenario.Location = new System.Drawing.Point(26, 303);
            this.lblScenario.Name = "lblScenario";
            this.lblScenario.Size = new System.Drawing.Size(49, 13);
            this.lblScenario.TabIndex = 5;
            this.lblScenario.Text = "Scenario";
            // 
            // comboBoxScenario
            // 
            this.comboBoxScenario.FormattingEnabled = true;
            this.comboBoxScenario.Items.AddRange(new object[] {
            "one-match",
            "two-match",
            "three-match"});
            this.comboBoxScenario.Location = new System.Drawing.Point(99, 303);
            this.comboBoxScenario.Name = "comboBoxScenario";
            this.comboBoxScenario.Size = new System.Drawing.Size(149, 21);
            this.comboBoxScenario.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(64, 353);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(145, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataSetTournaments
            // 
            //this.dataSetTournaments.DataSetName = "DataSetTournaments";
            //this.dataSetTournaments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDataAdapterAddTournament
            // 
            this.sqlDataAdapterAddTournament.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapterAddTournament.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapterAddTournament.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapterAddTournament.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // frmCreateEditTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 388);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.comboBoxScenario);
            this.Controls.Add(this.comboBoxParticipants);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.lblScenario);
            this.Controls.Add(this.lblParticipants);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblRegDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dateTimePickerLastRegDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Name = "frmCreateEditTournament";
            this.Text = "frmCreateEditTournament";
            this.Load += new System.EventHandler(this.frmCreateEditTournament_Load);
            //((System.ComponentModel.ISupportInitialize)(this.dataSetTournaments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastRegDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblRegDate;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.ComboBox comboBoxParticipants;
        private System.Windows.Forms.Label lblParticipants;
        private System.Windows.Forms.Label lblScenario;
        private System.Windows.Forms.ComboBox comboBoxScenario;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
       // private DataSetTournaments dataSetTournaments;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapterAddTournament;
    }
}