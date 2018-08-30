using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancerBD.Entities
{
    public class FreelancerAccount
    {
        public int id { get; set; }
        public double currentAMount { get; set; }
        public double withdrawAmount { get; set; }
        public double earnedAmount { get; set; }
    }
}
