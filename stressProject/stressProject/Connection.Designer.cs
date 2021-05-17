
namespace stressProject
{
    partial class Connection
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
            this.Way = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Way
            // 
            this.Way.Location = new System.Drawing.Point(13, 13);
            this.Way.Name = "Way";
            this.Way.Size = new System.Drawing.Size(393, 87);
            this.Way.TabIndex = 0;
            this.Way.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Path setting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PathSetting_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Connection";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Connection_Click);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 228);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Way);
            this.Name = "Connection";
            this.Text = "Connection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Way;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}