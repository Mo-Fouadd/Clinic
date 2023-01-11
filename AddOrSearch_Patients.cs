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
    public partial class AddOrSearch_Patients : Form
    {
        HomeScreen home;
        public AddOrSearch_Patients(HomeScreen home)
        {
            InitializeComponent();
            this.home = home;
        }
        private void AddOrSearch_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add add = new Add(home);
            add.Show();
            this.Close();
            home.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Search search = new Search(home);
            search.Show();
            this.Close();
            home.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
