using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClinicApplication
{
    public partial class Login : Form
    {
        HomeScreen home;
        public Login()
        {
            InitializeComponent();
        }
        static string sql = "Data Source =DESKTOP-09565VK\\SQLEXPRESS; Initial Catalog =Clinic; Integrated Security =True ";
        SqlConnection con = new SqlConnection(sql);

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SecretaryScreen secretary1 = new SecretaryScreen(this);
            HomeScreen home = new HomeScreen(this);
            Joke joke = new Joke(home,this,secretary1);
            joke.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreen home = new HomeScreen(this);
            string username, password;

            username = usernameText.Text;
            password = passwordText.Text;

            try
            {
                string querry = "SELECT * FROM Login WHERE username = '"+usernameText.Text+"' AND password = '"+passwordText.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if(dtable.Rows.Count > 0)
                {
                    username = usernameText.Text;
                    password = passwordText.Text;

                    home.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    usernameText.Clear();
                    passwordText.Clear();

                    usernameText.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Invalid Credintials");
            }
            finally
            {
                con.Close();
            }
           

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
