using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApplication
{
    internal class Doctor : Account
    {
        string DoctorName;
        public Doctor(string user, string password, string name) : base(user, password, name)
        {
         
        }

    }
}
