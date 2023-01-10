using System;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace ClinicApplication
{

    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }


        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrSearch addOrsearch = new AddOrSearch(this);
            addOrsearch.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Are_You_Sure frm= new Are_You_Sure(this);
            frm.Show();
        }

        private void HomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Are_You_Sure frm = new Are_You_Sure(this);
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PatientJobs patientjobs = new PatientJobs(this);
            patientjobs.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PatientEntity patientEntity = new PatientEntity(this);
            patientEntity.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PotionAddition potionAddition = new PotionAddition(this);
            potionAddition.Show();
            this.Hide();
        }
    }
}
