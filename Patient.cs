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
        int entityid;
        string entityname;
        public int EntityId { get { return entityid; } set { entityid = value; } }
        public string EntityName { get { return entityname; } set { entityname = value; } }
        double weight;
        public double Height { get { return height; } set { height = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
        long phoneNumber;
        public long PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        long homeNumber;
        public long HomeNumber { get { return homeNumber; } set { homeNumber = value; } }
        int noOfVisits = 0;
        public int NoOfVisits { get { return noOfVisits; } set { noOfVisits = value; } }
        double height = 0;

        public Patient() { }


    }
}