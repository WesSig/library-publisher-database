using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubsFinalProject
{
    class clsJobs
    {

        public string JobID { get; set; }
        public string JobDesc { get; set; }
        public int MaxLvl { get; set; }
        public int MinLvl { get; set; }

        public clsJobs()
        {
            JobID = "";
            JobDesc = "";
            MaxLvl = 0;
            MinLvl = 0; 
        }

    }
}
