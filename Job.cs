using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApplication
{
    internal class Job
    {
        string JobName;
        int JobId;

        public Job(string name, int id)
        {
            JobName = name;
            JobId = id;
        }
    }
}
