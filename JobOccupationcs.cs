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
    public partial class JobOccupationcs : Form
    {
        Form home;
        public JobOccupationcs(HomeScreen home)
        {
            InitializeComponent();
            this.home = home;
            dataGridView1.DataSource = Loader.LoadJobTable();
        }

        public JobOccupationcs(SecretaryScreen home)
        {
            InitializeComponent();
            this.home = home;
            dataGridView1.DataSource = Loader.LoadJobTable();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            if (home is HomeScreen)
            {
                HomeScreen home1 = home as HomeScreen;
                home1.Show();
                this.Close();
            }
            else if (home is SecretaryScreen)
            {
                SecretaryScreen home2 = home as SecretaryScreen;
                home2.Show();
                this.Close();
            }
        }

        private void JobOccupationcs_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Loader.LoadJobTable(Doses1.Text);

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Loader.InsertToJobTable(Doses1.Text);
            dataGridView1.DataSource = Loader.LoadJobTable();

        }
    }
}
