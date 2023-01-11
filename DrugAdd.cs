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
    public partial class DrugAdd : Form
    {
        HomeScreen home;
        public DrugAdd(HomeScreen home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void DrugAdd_Load(object sender, EventArgs e)
        {

        }


        private void MainMenu_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }
    }
}
