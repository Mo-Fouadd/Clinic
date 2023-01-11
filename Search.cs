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
    public partial class Search : Form
    {
        HomeScreen home;
        public Search(HomeScreen home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void MainMenu_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Visit visit = new Visit(home);
            visit.Show();
            this.Close();
        }
    }
}
