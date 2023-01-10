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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox1.Text = " eg:  NaggarFo24@xxxxx.com";
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = " eg: xxxxxxxx";
            textBox2.ForeColor = Color.Gray;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Joke joke = new Joke();
            joke.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreen home = new HomeScreen(this);
            home.Show();
            this.Hide();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
