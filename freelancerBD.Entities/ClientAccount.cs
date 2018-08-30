using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancerBD.Entities
{
    public class ClientAccount
    {
        public int id { get; set; }
        public double currentAmount { get; set; }
        public double spentAmount { get; set; }
        public double lastTransaction { get; set; }

    }
}
