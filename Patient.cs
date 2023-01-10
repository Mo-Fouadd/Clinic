using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApplication
{
    public class Patient
    {

        int id = 0;
        public int Id { get { return id; } set { id = value; } }
        string name = "";
        public string Name { get { return name; } set { name = value; } }
        int age = 0;
        public int Age { get { return age; } set { age = value; } }
        int jobNo = 0;
        public int JobNo { get { return jobNo; } set { jobNo = value; } }
        int authorityNo = 0;
        public int AuthorityNo { get { return authorityNo; } set { authorityNo = value; } }
        double longPatient = 0;
        public double LongPatient { get { return longPatient; } set { longPatient = value; } }
        double weight = 0;
        public double Weight { get { return weight; } set { weight = value; } }
        long phoneNumber = 0;
        public long PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        long homeNumber = 0;
        public long HomeNumber { get { return homeNumber; } set { homeNumber = value; } }
        int noOfVisits = 0;
        public int NoOfVisits { get { return noOfVisits; } set { noOfVisits = value; } }
        double height = 0;
        public double Height { get { return height; } set { height = value; } }

        public Patient() { }


    }
}