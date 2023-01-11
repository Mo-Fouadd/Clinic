﻿using ClinicApplication;
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
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomeScreen home = new HomeScreen(this);
            Joke joke = new Joke(home,this);
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
