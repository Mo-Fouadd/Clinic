namespace WindowsFormsApp3
{
    partial class DrugSearch
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
            this.Confirm = new System.Windows.Forms.Button();
            this.Finder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Search2 = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(772, 776);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(116, 40);
            this.Confirm.TabIndex = 11;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            // 
            // Finder
            // 
            this.Finder.Location = new System.Drawing.Point(1563, 909);
            this.Finder.Name = "Finder";
            this.Finder.Size = new System.Drawing.Size(116, 40);
            this.Finder.TabIndex = 10;
            this.Finder.Text = "Find";
            this.Finder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 911);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1272, 630);
            this.dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back To Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search2
            // 
            this.Search2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search2.Location = new System.Drawing.Point(489, 911);
            this.Search2.Name = "Search2";
            this.Search2.Size = new System.Drawing.Size(1013, 30);
            this.Search2.TabIndex = 6;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(1386, 776);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(116, 40);
            this.Update.TabIndex = 12;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // DrugSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Finder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Search2);
            this.Name = "DrugSearch";
            this.Text = "DrugSearch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Finder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Search2;
        private System.Windows.Forms.Button Update;
    }
}