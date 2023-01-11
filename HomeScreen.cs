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

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrSearch addOrsearch = new AddOrSearch(this);
            addOrsearch.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientDoses patientjobs = new PatientDoses(this);
            patientjobs.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Are_You_Sure frm= new Are_You_Sure(login);
            frm.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PatientEntity patientEntity = new PatientEntity(this);
            patientEntity.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MedicineAddition potionAddition = new MedicineAddition(this);
            potionAddition.Show();
            this.Hide();
        }

    }
}
