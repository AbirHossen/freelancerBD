using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancerBD.Entities
{
    public class Bidder
    {
        public int id { get; set; }
        public int jobID { get; set; }
        public int bidderID { get; set; }
        public double bidAmount{ get; set; }
        public DateTime date { get; set; }

    }
}
