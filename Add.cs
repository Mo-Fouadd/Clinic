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
    public partial class Add : Form
    {
        HomeScreen home;
        Patient patient;
        public Add(HomeScreen home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Enquiry_Click(object sender, EventArgs e)
        {
            patient = new Patient();
            patient.EntityId = Convert.ToInt32(Entity.Text);
            patient.HomeNumber = Convert.ToInt64(Telephone.Text);
            patient.PhoneNumber = Convert.ToInt64(Mobile.Text);
            patient.Age = Convert.ToInt32(Age.Text);
            patient.Height = Convert.ToDouble(Height.Text);
            patient.Weight = Convert.ToDouble(Weight.Text);
            patient.Name = _Name.Text;
            patient.JobNo = Convert.ToInt32(Occupation.Text);
            Visit visit = new Visit(home, patient);
            Loader.InsertToPatientTable(_Name.Text, Convert.ToInt32(Age.Text), Convert.ToInt32(Entity.Text), Convert.ToInt64(Mobile.Text), Convert.ToInt64(Telephone.Text), Convert.ToDouble(Height.Text), Convert.ToDouble(Weight.Text), Convert.ToInt32(Occupation.Text));
            visit.Show();
            this.Close();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void Entity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
