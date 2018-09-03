using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancerBD.Entities
{
    [Table("User")]
    public class User
    {
        
        public int id { get; set; }
        [Required(ErrorMessage = "Insert Username")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Insert Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
