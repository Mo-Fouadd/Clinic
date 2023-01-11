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
            this.PatientEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientEntity.Location = new System.Drawing.Point(682, 503);
            this.PatientEntity.Margin = new System.Windows.Forms.Padding(4);
            this.PatientEntity.Name = "PatientEntity";
            this.PatientEntity.Size = new System.Drawing.Size(699, 81);
            this.PatientEntity.TabIndex = 6;
            this.PatientEntity.Text = "Register Patient Entity";
            this.PatientEntity.UseVisualStyleBackColor = true;
            this.PatientEntity.Click += new System.EventHandler(this.PatientEntity_Click);
            // 
            // PatientJobs
            // 
            this.PatientJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientJobs.Location = new System.Drawing.Point(682, 383);
            this.PatientJobs.Margin = new System.Windows.Forms.Padding(4);
            this.PatientJobs.Name = "PatientJobs";
            this.PatientJobs.Size = new System.Drawing.Size(699, 81);
            this.PatientJobs.TabIndex = 5;
            this.PatientJobs.Text = "Register Patient Jobs";
            this.PatientJobs.UseVisualStyleBackColor = true;
            this.PatientJobs.Click += new System.EventHandler(this.PatientJobs_Click);
            // 
            // PatientVisit
            // 
            this.PatientVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientVisit.Location = new System.Drawing.Point(682, 249);
            this.PatientVisit.Margin = new System.Windows.Forms.Padding(4);
            this.PatientVisit.Name = "PatientVisit";
            this.PatientVisit.Size = new System.Drawing.Size(699, 86);
            this.PatientVisit.TabIndex = 4;
            this.PatientVisit.Text = "Register Patient Visit";
            this.PatientVisit.UseVisualStyleBackColor = true;
            this.PatientVisit.Click += new System.EventHandler(this.PatientVisit_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(682, 624);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(699, 81);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(844, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 61);
            this.label1.TabIndex = 8;
            this.label1.Text = "Secretary Screen";
            // 
            // SecretaryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PatientEntity);
            this.Controls.Add(this.PatientJobs);
            this.Controls.Add(this.PatientVisit);
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