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
        static string sql = "Data Source=DESKTOP-IV5FD4B\\SQLEXPRESS;Initial Catalog=FormBB;Integrated Security=True";
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
            string username, password;
            con.Open();
            username = usernameText.Text;
            password = passwordText.Text;

            try
            {
                //string querry = "SELECT * FROM Login WHERE username = '"+usernameText.Text+"' AND password = '"+passwordText.Text+"'";
                string querry = "SELECT * FROM Login ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                DataTable te = new DataTable();
                sda.Fill(te);
                Doctor dr = new Doctor(usernameText.Text, passwordText.Text, "dr");
                Secretary se = new Secretary(usernameText.Text, passwordText.Text, "sec");
                
                if (te.Rows.Count > 0 && Loader.d.user == dr.user && Loader.d.password== dr.password  )
                {
                    
                    username = usernameText.Text;
                    password = passwordText.Text;

                    HomeScreen home = new HomeScreen(this);
                    home.Show();
                    this.Hide();

                }
                 
                else if (te.Rows.Count > 0 && Loader.s.user == se.user && Loader.s.password == se.password)

                {

                    username = usernameText.Text;
                    password = passwordText.Text;

                    SecretaryScreen ss = new SecretaryScreen(this);
                    ss.Show();
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
