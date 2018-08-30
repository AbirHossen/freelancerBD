using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancerBD.Entities
{
    public class Job
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int clientID { get; set; }
        public int freelancerID { get; set; }
        public double MaxBid { get; set; }
        public double AgreedBid { get; set; }
        public string JobDescription { get; set; }
        public string JobRequirement { get; set; }
        public string Status { get; set; }
        public DateTime PostingDate { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime DueDate { get; set; }
        public string EstimatedHours { get; set; }
        public string JobType { get; set; }
    }
}
