
namespace stressProject
{
    partial class StatisticForm
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
            this.logOutBtn = new System.Windows.Forms.Button();
            this.dataGridViewPlayerStats = new System.Windows.Forms.DataGridView();
            this.dataGridViewTournamentStats = new System.Windows.Forms.DataGridView();
            this.playersLabel = new System.Windows.Forms.Label();
            this.tournamentsLabel = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayerStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTournamentStats)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(702, 12);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(86, 30);
            this.logOutBtn.TabIndex = 0;
            this.logOutBtn.Text = "Log out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPlayerStats
            // 
            this.dataGridViewPlayerStats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewPlayerStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayerStats.Location = new System.Drawing.Point(45, 146);
            this.dataGridViewPlayerStats.Name = "dataGridViewPlayerStats";
            this.dataGridViewPlayerStats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewPlayerStats.RowTemplate.Height = 25;
            this.dataGridViewPlayerStats.Size = new System.Drawing.Size(719, 118);
            this.dataGridViewPlayerStats.TabIndex = 1;
            // 
            // dataGridViewTournamentStats
            // 
            this.dataGridViewTournamentStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTournamentStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewTournamentStats.Location = new System.Drawing.Point(45, 320);
            this.dataGridViewTournamentStats.Name = "dataGridViewTournamentStats";
            this.dataGridViewTournamentStats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewTournamentStats.RowTemplate.Height = 25;
            this.dataGridViewTournamentStats.Size = new System.Drawing.Size(719, 113);
            this.dataGridViewTournamentStats.TabIndex = 2;
            // 
            // playersLabel
            // 
            this.playersLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.playersLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playersLabel.Location = new System.Drawing.Point(45, 93);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(719, 50);
            this.playersLabel.TabIndex = 3;
            this.playersLabel.Text = "Players";
            this.playersLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tournamentsLabel
            // 
            this.tournamentsLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tournamentsLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tournamentsLabel.Location = new System.Drawing.Point(45, 267);
            this.tournamentsLabel.Name = "tournamentsLabel";
            this.tournamentsLabel.Size = new System.Drawing.Size(719, 50);
            this.tournamentsLabel.TabIndex = 4;
            this.tournamentsLabel.Text = "Tournaments";
            this.tournamentsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tournamentsLabel);
            this.Controls.Add(this.playersLabel);
            this.Controls.Add(this.dataGridViewTournamentStats);
            this.Controls.Add(this.dataGridViewPlayerStats);
            this.Controls.Add(this.logOutBtn);
            this.Name = "StatisticForm";
            this.Text = "StatisticForm";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayerStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTournamentStats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.DataGridView dataGridViewPlayerStats;
        private System.Windows.Forms.DataGridView dataGridViewTournamentStats;
        private System.Windows.Forms.Label playersLabel;
        private System.Windows.Forms.Label tournamentsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}