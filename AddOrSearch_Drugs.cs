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
    public partial class AddOrSearch_Drugs : Form
    {
        HomeScreen home;
        public AddOrSearch_Drugs(HomeScreen home)
        {
            InitializeComponent();
            this.home = home;
        }


        private void PotionAddition_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrugAdd drug_add = new DrugAdd(home);
            drug_add.Show();
            this.Close();
            home.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DrugSearch drugSearch = new DrugSearch(home);
            drugSearch.Show();
            this.Close();
            home.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
