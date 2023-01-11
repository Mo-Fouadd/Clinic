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
        Form home;
        public PatientEntity(HomeScreen home)
        {
            InitializeComponent();
            this.home = home;
        }
        public PatientEntity(SecretaryScreen home)
        {
            InitializeComponent();
            this.home = home;
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
    }
}
