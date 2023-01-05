using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApplication
{
    internal abstract class Account
    {
        string user;
        string name;
        string password;

        public Account (string user, string password, string name)        {
            this.user = user;
            this.password = password;
            this.name = name;
        }

    }
}
