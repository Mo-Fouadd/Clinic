using ClinicApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Tagarob : Form
    {
        public Tagarob()
        {
            InitializeComponent();
            dataGridView1.DataSource = Loader.LoadUserTable();
            dataGridView2.DataSource = Loader.LoadDrugsTable();
        }

        private void Tagarob_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'formBBDataSet.patientsD' table. You can move, or remove it, as needed.
            this.patientsDTableAdapter.Fill(this.formBBDataSet.patientsD);

        }
        //static string sql = "Data Source =DESKTOP-IV5FD4B\\SQLEXPRESS; Initial Catalog =FormBB; Integrated Security =True ";
        //static public SqlConnection con = new SqlConnection(sql);

        static string sql = "Data Source =DESKTOP-IV5FD4B'\'SQLEXPRESS; Initial Catalog =FormBB; Integrated Security =True ";
        static public SqlConnection cona = new SqlConnection(sql);
        // public Form2 x = new Form2();
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        //private void button2_Click(object sender, EventArgs e)
        //{

        //    dataGridView1.DataSource = Loader.LoadUserTable(textBox2.Text);
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void load_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Loader.LoadUserTable();
        }

        //private void richTextBox1_TextChanged(object sender, EventArgs e)
        //{

        // }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // listBox1.Items.Add(dataGridView1.CurrentCell.Value.ToString());
        }

        

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //int i = 5
        private void button1_Click_1(object sender, EventArgs e)
        {

            //INSERT INTO patients112 (id ,Name)
            //VALUES(99999, 'momo');
            cona.Open();
            DataTable dt = new DataTable();
            string query = "INSERT INTO  * patients112 (id ,Name) VALUES(998999, 'momo');";
            SqlCommand cmd = new SqlCommand(query, cona);
            load_Click(sender, e);
            cona.Close();
            //dataGridView1.Rows.Add(999999+ ++i,"momo ",1,2,3,4,5,6,7,8,9);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //e.Cancel=false;
        }
    }
}
