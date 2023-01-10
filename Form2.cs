using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicApplication
{
    public partial class Form2 : Form
    {
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public Form2(DataGridViewRow a)
        {
            InitializeComponent();
            Patient p = Loader.toPatient(a);
            textBox1.Text=p.Name;
            ////textBox1.Text = Loader.allPatients[0].Name.ToString();
            //textBox2.Text = a.Cells[1].Value.ToString();
            //label1.Text= a.Cells[2].Value.ToString();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        //public Patient[] patientss;
        //public Patient[] loadDatabase()
        //{

        //    return patientss;
        //}


    }

}
