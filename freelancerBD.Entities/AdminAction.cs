using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancerBD.Entities
{   [Table("AdminAction")]
    public class AdminAction
    {   [Key]
        public int id { get; set; }
        public int adminID { get; set; }
        public string ActionType { get; set; }
        public DateTime Date { get; set; }


    }
}
