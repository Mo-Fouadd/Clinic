﻿namespace ClinicApplication
{
    partial class HomeScreen
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
            this.PatientVisit = new System.Windows.Forms.Button();
            this.NewDoses = new System.Windows.Forms.Button();
            this.PatientJobs = new System.Windows.Forms.Button();
            this.PatientEntity = new System.Windows.Forms.Button();
            this.NewMedicine = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PatientVisit
            // 
            this.PatientVisit.Location = new System.Drawing.Point(1063, 371);
            this.PatientVisit.Name = "PatientVisit";
            this.PatientVisit.Size = new System.Drawing.Size(216, 37);
            this.PatientVisit.TabIndex = 0;
            this.PatientVisit.Text = "Register Patient Visit";
            this.PatientVisit.UseVisualStyleBackColor = true;
            this.PatientVisit.Click += new System.EventHandler(this.PatientVisit_Click);
            // 
            // NewDoses
            // 
            this.NewDoses.Location = new System.Drawing.Point(696, 371);
            this.NewDoses.Name = "NewDoses";
            this.NewDoses.Size = new System.Drawing.Size(235, 37);
            this.NewDoses.TabIndex = 1;
            this.NewDoses.Text = "Register New Doses";
            this.NewDoses.UseVisualStyleBackColor = true;
            this.NewDoses.Click += new System.EventHandler(this.NewDoses_Click);
            // 
            // PatientJobs
            // 
            this.PatientJobs.Location = new System.Drawing.Point(867, 429);
            this.PatientJobs.Name = "PatientJobs";
            this.PatientJobs.Size = new System.Drawing.Size(240, 36);
            this.PatientJobs.TabIndex = 2;
            this.PatientJobs.Text = "Register Patient Jobs";
            this.PatientJobs.UseVisualStyleBackColor = true;
            this.PatientJobs.Click += new System.EventHandler(this.PatientJobs_Click);
            // 
            // PatientEntity
            // 
            this.PatientEntity.Location = new System.Drawing.Point(867, 485);
            this.PatientEntity.Name = "PatientEntity";
            this.PatientEntity.Size = new System.Drawing.Size(240, 37);
            this.PatientEntity.TabIndex = 3;
            this.PatientEntity.Text = "Register Patient Entity";
            this.PatientEntity.UseVisualStyleBackColor = true;
            this.PatientEntity.Click += new System.EventHandler(this.PatientEntity_Click);
            // 
            // NewMedicine
            // 
            this.NewMedicine.Location = new System.Drawing.Point(867, 539);
            this.NewMedicine.Name = "NewMedicine";
            this.NewMedicine.Size = new System.Drawing.Size(240, 40);
            this.NewMedicine.TabIndex = 4;
            this.NewMedicine.Text = "Add New Medicine";
            this.NewMedicine.UseVisualStyleBackColor = true;
            this.NewMedicine.Click += new System.EventHandler(this.NewMedicine_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(867, 598);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(240, 40);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(632, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 88);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dr Fouad Mohamed ElNaggar Clinic";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewMedicine);
            this.Controls.Add(this.PatientEntity);
            this.Controls.Add(this.PatientJobs);
            this.Controls.Add(this.NewDoses);
            this.Controls.Add(this.PatientVisit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PatientVisit;
        private System.Windows.Forms.Button NewDoses;
        private System.Windows.Forms.Button PatientJobs;
        private System.Windows.Forms.Button PatientEntity;
        private System.Windows.Forms.Button NewMedicine;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
    }
}

