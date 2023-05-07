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

        int id;
        public int Id { get { return id; }  set { } }
        string name = "";
        public string Name { get { return name; }  set { } }
        int age = 0;
        public int Age { get { return age; }  set { } }
        int jobNo;
        public int JobNo { get { return jobNo; } set { if(value > 0) jobNo = value; } }
        Entity entity = new Entity();
        public int EntityId { get { return entity.id; }  set {  } }
        public string EntityName { get { return entity.name; } set {if(value != null) entity.name = value; } }
        double weight;
        double height;
        public double Height { get { return height; } set { height = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
        long phoneNumber;
        public long PhoneNumber { get { return phoneNumber; } set {if(value > 0) phoneNumber = value; } }
        long homeNumber;
        public long HomeNumber { get { return homeNumber; } set { if(value > 0)homeNumber = value; } }
        int noOfVisits = 0;
        public int NoOfVisits { get { return noOfVisits; }  set { } }

        public Patient() { }


    }
}