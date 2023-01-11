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
    public partial class AddOrSearch : Form
    {
        HomeScreen home;
        public AddOrSearch(HomeScreen home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search search= new Search(home);
            search.Show();
            this.Close();
            home.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add add = new Add(home);
            add.Show();
            this.Close();
            home.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
