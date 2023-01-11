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
    public partial class Joke : Form
    {
        Login login;
        HomeScreen home;
        SecretaryScreen secretary1;
        public Joke(HomeScreen home,Login login,SecretaryScreen secretary1)
        {
            InitializeComponent();
            this.home = home;
            this.login = login;
            this.secretary1 = secretary1;
        }

        private void Joke_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            home.Show();
            login.Hide();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secretary1.Show();
            login.Hide();
            this.Close();
        }
    }
}
