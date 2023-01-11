namespace WindowsFormsApp3
{
    partial class DrugAdd
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
            this.AddNew = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNew
            // 
            this.AddNew.Location = new System.Drawing.Point(1241, 674);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(125, 56);
            this.AddNew.TabIndex = 14;
            this.AddNew.Text = "Add New";
            this.AddNew.UseVisualStyleBackColor = true;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(971, 674);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(135, 56);
            this.Confirm.TabIndex = 13;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Drug Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Drug ID :";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(621, 561);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(847, 30);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(621, 424);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(847, 30);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(980, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Drugs";
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(678, 674);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(176, 56);
            this.MainMenu.TabIndex = 15;
            this.MainMenu.Text = "Back To Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // DrugAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.AddNew);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "DrugAdd";
            this.Text = "DrugMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DrugAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainMenu;
    }
}