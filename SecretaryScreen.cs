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
    public partial class SecretaryScreen : Form
    {
        Login login;
        public SecretaryScreen(Login login)
        {
            InitializeComponent();
            this.login = login;
            
        }

        private void PatientVisit_Click(object sender, EventArgs e)
        {
                Add add = new Add(this);
                add.Show();
                this.Hide();
        }

        private void SecretaryScreen_Load(object sender, EventArgs e)
        {

        }

        private void PatientJobs_Click(object sender, EventArgs e)
        {
            JobOccupationcs jobOccupationcs = new JobOccupationcs(this);
            jobOccupationcs.Show();
        }

        private void PatientEntity_Click(object sender, EventArgs e)
        {
            PatientEntity patientEntity = new PatientEntity(this);
            patientEntity.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Are_You_Sure are_You_Sure = new Are_You_Sure(login);
            are_You_Sure.Show();
        }
    }
}
