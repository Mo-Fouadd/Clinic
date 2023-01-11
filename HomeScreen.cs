using System;
using System.Windows.Forms;

namespace ClinicApplication
{

    public partial class HomeScreen : Form
    {
        Login login;
        public HomeScreen(Login login)
        {
            InitializeComponent();
            this.login = login;
        }


        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Are_You_Sure frm= new Are_You_Sure(login);
            frm.Show();
        }

        private void PatientVisit_Click(object sender, EventArgs e)
        {
            AddOrSearch_Patients addOrsearch = new AddOrSearch_Patients(this);
            addOrsearch.Show();
        }

        private void NewDoses_Click(object sender, EventArgs e)
        {
            PatientDoses patientjobs = new PatientDoses(this);
            patientjobs.Show();
            this.Hide();
        }

        private void PatientJobs_Click(object sender, EventArgs e)
        {
            JobOccupationcs job = new JobOccupationcs(this);
            job.Show();
            this.Hide();
        }

        private void PatientEntity_Click(object sender, EventArgs e)
        {
            PatientEntity patientEntity = new PatientEntity(this);
            patientEntity.Show();
            this.Hide();
        }

        private void NewMedicine_Click(object sender, EventArgs e)
        {
            AddOrSearch_Drugs AoS = new AddOrSearch_Drugs(this);
            AoS.Show();
        }
    }
}
