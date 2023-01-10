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

namespace ClinicApplication
{
    public partial class Are_You_Sure : Form
    {
        Login exit;
        public Are_You_Sure(Login Exiting)
        {
            InitializeComponent();
            exit = Exiting;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exit.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Are_You_Sure_Load(object sender, EventArgs e)
        {

        }
    }
}
