using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancerBD.Entities
{
    public class SystemTransactionHistory
    {
        public int id { get; set; }
        public int jobID { get; set; }
        public double bidAmount { get; set; }
        public int clientID { get; set; }
        public int freelancerID { get; set; }
        public double systemAmount { get; set; }
        public double transferAmount { get; set; }

    }
}
