using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApplication
{
    public abstract class Account
    {
        public string user;
        public string name;
        public string password;

        public Account (string user, string password, string name)        {
            this.user = user;
            this.password = password;
            this.name = name;
        }

    }
}
