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
        Form home;
        Patient patient;
        public Add(HomeScreen home)
        {
            InitializeComponent();
            this.home = home;
        }
        public Add(SecretaryScreen home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Enquiry_Click(object sender, EventArgs e)
        {
            if (home is HomeScreen)
            {
                HomeScreen home1= (HomeScreen)home;
                patient = new Patient();
                patient.EntityId = Convert.ToInt32(Entity.Text);
                patient.HomeNumber = Convert.ToInt64(Telephone.Text);
                patient.PhoneNumber = Convert.ToInt64(Mobile.Text);
                patient.Age = Convert.ToInt32(Age.Text);
                patient.Height = Convert.ToDouble(Height.Text);
                patient.Weight = Convert.ToDouble(Weight.Text);
                patient.Name = _Name.Text;
                patient.JobNo = Convert.ToInt32(Occupation.Text);
                Visit visit = new Visit(home1, patient);
                Loader.InsertToPatientTable(_Name.Text, Convert.ToInt32(Age.Text), Convert.ToInt32(Entity.Text), Convert.ToInt64(Mobile.Text), Convert.ToInt64(Telephone.Text), Convert.ToDouble(Height.Text), Convert.ToDouble(Weight.Text), Convert.ToInt32(Occupation.Text));
                visit.Show();
                this.Close();


                if (home is SecretaryScreen)
                {
                    SecretaryScreen home2 = (SecretaryScreen)home;
                    patient = new Patient();
                    patient.EntityId = Convert.ToInt32(Entity.Text);
                    patient.HomeNumber = Convert.ToInt64(Telephone.Text);
                    patient.PhoneNumber = Convert.ToInt64(Mobile.Text);
                    patient.Age = Convert.ToInt32(Age.Text);
                    patient.Height = Convert.ToDouble(Height.Text);
                    patient.Weight = Convert.ToDouble(Weight.Text);
                    patient.Name = _Name.Text;
                    patient.JobNo = Convert.ToInt32(Occupation.Text);
                    Loader.InsertToPatientTable(_Name.Text, Convert.ToInt32(Age.Text), Convert.ToInt32(Entity.Text), Convert.ToInt64(Mobile.Text), Convert.ToInt64(Telephone.Text), Convert.ToDouble(Height.Text), Convert.ToDouble(Weight.Text), Convert.ToInt32(Occupation.Text));

                }
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (home is HomeScreen)
            {
                HomeScreen home1 = (HomeScreen)home;
                home1.Show();
                this.Close();
            }
            else if(home is SecretaryScreen)
            {
                SecretaryScreen home2= (SecretaryScreen)home;
                home2.Show();
                this.Close();
            }
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void Entity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
