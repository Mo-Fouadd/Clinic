using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApplication
{
    public class Entity
    {
        int Id;
        public int id { get; set; }


        public string Name; 

        public string name{ get; set; }

        double Discount;
        public double discount
        {
            get; set;
        }

        public Entity() { }

    }
}
