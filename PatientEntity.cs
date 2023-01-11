using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApplication
{
    public partial class PatientEntity : Form
    {
        HomeScreen home;
        public PatientEntity(HomeScreen home)
        {
            InitializeComponent();
            this.home = home;
            dataGridView1.DataSource = Loader.LoadEntityTable();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientEntity_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Loader.LoadEntityTable(PatientEntity1.Text);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Loader.InsertToEntityTable(PatientEntity1.Text);
            dataGridView1.DataSource = Loader.LoadEntityTable();
        }
    }
}
