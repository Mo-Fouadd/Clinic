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
    public partial class Visit : Form
    {

        HomeScreen home;
        Patient patient;
        public Visit(HomeScreen home, Patient patient)
        {
            InitializeComponent();
            this.home = home;
            this.patient = patient;
            Entity.Text = Convert.ToString(patient.EntityId);
            Telephone.Text = Convert.ToString(patient.HomeNumber);
            Mobile.Text = Convert.ToString(patient.PhoneNumber);
            Age.Text = Convert.ToString(patient.Age);
            Height.Text = Convert.ToString(patient.Height);
            Weight.Text = Convert.ToString(patient.Weight);
            Number.Text = Convert.ToString(patient.Id);
            _Name.Text = Convert.ToString(patient.Name);
            Occupation.Text = Convert.ToString(patient.JobNo);
            Visits.Text = Convert.ToString(patient.NoOfVisits);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void Visit_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
