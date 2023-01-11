using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApplication
{
    public class Drug
    {
        int DrugId;
        public int drugid
        {
            set { DrugId = value; }
            get { return DrugId; }
        }
        string Drugname;
        public string drugname
        {
            set { Drugname = value; }
            get { return Drugname; }
        }

        public Drug()
        {
        }
        public virtual void GetDrugType()
        {

        }
    }
}