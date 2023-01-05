using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class Drug
    {
        readonly int DrugId;
        string Drugname;

        public Drug(int id, string name)
        {
            DrugId = id;
            Drugname = name;
        }
    }
}
