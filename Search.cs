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
    }
}
