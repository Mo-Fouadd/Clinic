namespace ClinicApplication
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientVisit
            // 
            this.PatientVisit.BackColor = System.Drawing.Color.Red;
            this.PatientVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientVisit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PatientVisit.Location = new System.Drawing.Point(1060, 253);
            this.PatientVisit.Margin = new System.Windows.Forms.Padding(4);
            this.PatientVisit.Name = "PatientVisit";
            this.PatientVisit.Size = new System.Drawing.Size(449, 86);
            this.PatientVisit.TabIndex = 0;
            this.PatientVisit.Text = "Register Patient Visit";
            this.PatientVisit.UseVisualStyleBackColor = false;
            this.PatientVisit.Click += new System.EventHandler(this.PatientVisit_Click);
            // 
            // NewDoses
            // 
            this.NewDoses.BackColor = System.Drawing.Color.Red;
            this.NewDoses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDoses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewDoses.Location = new System.Drawing.Point(532, 253);
            this.NewDoses.Margin = new System.Windows.Forms.Padding(4);
            this.NewDoses.Name = "NewDoses";
            this.NewDoses.Size = new System.Drawing.Size(449, 86);
            this.NewDoses.TabIndex = 1;
            this.NewDoses.Text = "Register New Doses";
            this.NewDoses.UseVisualStyleBackColor = false;
            this.NewDoses.Click += new System.EventHandler(this.NewDoses_Click);
            // 
            // PatientJobs
            // 
            this.PatientJobs.BackColor = System.Drawing.Color.Red;
            this.PatientJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientJobs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PatientJobs.Location = new System.Drawing.Point(663, 379);
            this.PatientJobs.Margin = new System.Windows.Forms.Padding(4);
            this.PatientJobs.Name = "PatientJobs";
            this.PatientJobs.Size = new System.Drawing.Size(699, 81);
            this.PatientJobs.TabIndex = 2;
            this.PatientJobs.Text = "Register Patient Jobs";
            this.PatientJobs.UseVisualStyleBackColor = false;
            this.PatientJobs.Click += new System.EventHandler(this.PatientJobs_Click);
            // 
            // PatientEntity
            // 
            this.PatientEntity.BackColor = System.Drawing.Color.Red;
            this.PatientEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientEntity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PatientEntity.Location = new System.Drawing.Point(663, 499);
            this.PatientEntity.Margin = new System.Windows.Forms.Padding(4);
            this.PatientEntity.Name = "PatientEntity";
            this.PatientEntity.Size = new System.Drawing.Size(699, 81);
            this.PatientEntity.TabIndex = 3;
            this.PatientEntity.Text = "Register Patient Entity";
            this.PatientEntity.UseVisualStyleBackColor = false;
            this.PatientEntity.Click += new System.EventHandler(this.PatientEntity_Click);
            // 
            // NewMedicine
            // 
            this.NewMedicine.BackColor = System.Drawing.Color.Red;
            this.NewMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewMedicine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewMedicine.Location = new System.Drawing.Point(663, 606);
            this.NewMedicine.Margin = new System.Windows.Forms.Padding(4);
            this.NewMedicine.Name = "NewMedicine";
            this.NewMedicine.Size = new System.Drawing.Size(699, 81);
            this.NewMedicine.TabIndex = 4;
            this.NewMedicine.Text = "Add New Medicine";
            this.NewMedicine.UseVisualStyleBackColor = false;
            this.NewMedicine.Click += new System.EventHandler(this.NewMedicine_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(663, 715);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(699, 81);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(583, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 108);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dr Fouad ElNaggar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClinicApplication.Properties.Resources.IMG_20210913_WA0051;
            this.pictureBox1.Location = new System.Drawing.Point(1253, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewMedicine);
            this.Controls.Add(this.PatientEntity);
            this.Controls.Add(this.PatientJobs);
            this.Controls.Add(this.NewDoses);
            this.Controls.Add(this.PatientVisit);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

