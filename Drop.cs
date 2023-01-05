using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApplicationv
{
    internal class Drop
    {
       readonly int DropId;
        string DropDescription;

        public Drop(int id, string des)
        {
            DropId = id;
            DropDescription = des;
        }
    }
}
