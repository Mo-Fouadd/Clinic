using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApplication
{
    public partial class Search : Form
    {
        HomeScreen home;
        Patient patient;
        
        public Search(HomeScreen home)
        {
            InitializeComponent();
            this.home = home;
           
        }

        private void Search_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Loader.LoadUserTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Visit visit = new Visit(home, patient);
            visit.Show();
            this.Close();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            patient = Loader.toPatient(dataGridView1.CurrentRow);
        }

        private void Finder_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Loader.LoadUserTable(Search2.Text);
        }
    }
}
