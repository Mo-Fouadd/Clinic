using ClinicApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class JobOccupationcs : Form
    {
        HomeScreen home;
        public JobOccupationcs(HomeScreen home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }
    }
}
