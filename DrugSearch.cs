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
    public partial class DrugSearch : Form
    {
        HomeScreen home;
        public DrugSearch(HomeScreen home)
        {
            this.home = home;
            InitializeComponent();
            dataGridView1.DataSource = Loader.LoadDrugsTable();
        }

        private void DrugSearch_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void Finder_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Loader.LoadDrugsTable(Searchbar.Text);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Loader.InsertToDrugTable(Searchbar.Text);
            dataGridView1.DataSource = Loader.LoadDrugsTable();
        }
    }
}
