namespace ClinicApplication
{
    partial class AddOrSearch_Drugs
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
            this.Back = new System.Windows.Forms.Button();
            this.Searchh = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(177, 300);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(357, 81);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button3_Click);
            // 
            // Searchh
            // 
            this.Searchh.Location = new System.Drawing.Point(177, 183);
            this.Searchh.Name = "Searchh";
            this.Searchh.Size = new System.Drawing.Size(357, 81);
            this.Searchh.TabIndex = 4;
            this.Searchh.Text = "Search";
            this.Searchh.UseVisualStyleBackColor = true;
            this.Searchh.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(177, 68);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(357, 81);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddOrSearch_Drugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 447);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Searchh);
            this.Controls.Add(this.Add);
            this.Name = "AddOrSearch_Drugs";
            this.Text = "Add Or Search for Drugs";
            this.Load += new System.EventHandler(this.PotionAddition_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Searchh;
        private System.Windows.Forms.Button Add;
    }
}