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
    public partial class Add : Form
    {
        HomeScreen home;
        public Add(HomeScreen home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Enquiry_Click(object sender, EventArgs e)
        {
            Visit visit = new Visit(home);
            visit.Show();
            this.Close();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}
