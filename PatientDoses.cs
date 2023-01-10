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
    public partial class PatientDoses : Form
    {
        HomeScreen home;
        public PatientDoses(HomeScreen home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void PatientJobs_Load(object sender, EventArgs e)
        {

        }
    }
}
