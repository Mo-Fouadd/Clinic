namespace ClinicApplication
{
    partial class SecretaryScreen
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
            this.PatientEntity = new System.Windows.Forms.Button();
            this.PatientJobs = new System.Windows.Forms.Button();
            this.PatientVisit = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PatientEntity
            // 
            this.PatientEntity.BackColor = System.Drawing.Color.Orange;
            this.PatientEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientEntity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PatientEntity.Location = new System.Drawing.Point(827, 813);
            this.PatientEntity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PatientEntity.Name = "PatientEntity";
            this.PatientEntity.Size = new System.Drawing.Size(1048, 127);
            this.PatientEntity.TabIndex = 6;
            this.PatientEntity.Text = "Register Patient Entity";
            this.PatientEntity.UseVisualStyleBackColor = false;
            this.PatientEntity.Click += new System.EventHandler(this.PatientEntity_Click);
            // 
            // PatientJobs
            // 
            this.PatientJobs.BackColor = System.Drawing.Color.Orange;
            this.PatientJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientJobs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PatientJobs.Location = new System.Drawing.Point(827, 625);
            this.PatientJobs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PatientJobs.Name = "PatientJobs";
            this.PatientJobs.Size = new System.Drawing.Size(1048, 127);
            this.PatientJobs.TabIndex = 5;
            this.PatientJobs.Text = "Register Patient Jobs";
            this.PatientJobs.UseVisualStyleBackColor = false;
            this.PatientJobs.Click += new System.EventHandler(this.PatientJobs_Click);
            // 
            // PatientVisit
            // 
            this.PatientVisit.BackColor = System.Drawing.Color.Orange;
            this.PatientVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientVisit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PatientVisit.Location = new System.Drawing.Point(827, 416);
            this.PatientVisit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PatientVisit.Name = "PatientVisit";
            this.PatientVisit.Size = new System.Drawing.Size(1048, 134);
            this.PatientVisit.TabIndex = 4;
            this.PatientVisit.Text = "Register Patient Visit";
            this.PatientVisit.UseVisualStyleBackColor = false;
            this.PatientVisit.Click += new System.EventHandler(this.PatientVisit_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Orange;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Exit.Location = new System.Drawing.Point(827, 1002);
            this.Exit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(1048, 127);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(1070, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 98);
            this.label1.TabIndex = 8;
            this.label1.Text = "Secretary Screen";
            // 
            // SecretaryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2564, 1559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PatientEntity);
            this.Controls.Add(this.PatientJobs);
            this.Controls.Add(this.PatientVisit);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SecretaryScreen";
            this.Text = "SecretaryScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SecretaryScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PatientEntity;
        private System.Windows.Forms.Button PatientJobs;
        private System.Windows.Forms.Button PatientVisit;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
    }
}