using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicApplication
{
    public partial class Form1 : Form
    {
        static string sql = "Data Source =DESKTOP-IV5FD4B'\'SQLEXPRESS; Initial Catalog =FormBB; Integrated Security =True ";
        static public SqlConnection cona = new SqlConnection(sql);
        // public Form2 x = new Form2();
        public Form1()
        {
            //System.Threading.Thread.Sleep(4000);
            //x.ShowDialog();
            //dataGridView1= new DataGridView();
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = Loader.LoadUserTable();
            dataGridView2.DataSource = Loader.LoadDrugsTable();
            //txtTID.text = dataGridView1;
           // txtid.Text
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

             dataGridView1.DataSource = Loader.LoadUserTable(textBox2.Text) ;
        }

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

        private void button3_Click(object sender, EventArgs e)
        {
             Form2 x = new Form2( dataGridView1.CurrentRow );
             x.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            //Form3 form3 = new Form3();
            //form3.Show();
        }
    }
}
