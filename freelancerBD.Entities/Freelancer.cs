using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancerBD.Entities
{
    public class Freelancer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public double Reviews { get; set; }
        public string Skills { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Address { get; set; }
        public string Region { get; set; }
        public string PhoneNumber { get; set; }
        public string Education { get; set; }
    }
}
