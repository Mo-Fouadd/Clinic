using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApplication
{
    public class Doctor : Account
    {
        string DoctorName = "";
        public Doctor(string user, string password, string name) : base(user, password, name)
        {

        }

        public static bool operator ==(Doctor a, Doctor b)
        {
            
            if (a.DoctorName != b.DoctorName) return false;
            else if (a.user != b.user) return false;
            else if(a.password!= b.password) return false;
            return true;
        }
        public static bool operator !=(Doctor a, Doctor b)
        {

            if (a.DoctorName != b.DoctorName) return true;
            if (a.user != b.user) return true;
            if (a.password != b.password) return true;
            return false;
        }
        

    }
}