﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freelancerBD.Entities
{
    [Table("Admin")]
    public class Admin
    {   
        public int id { get; set; }
        
        public string Name { get; set; }
       
        public string Password { get; set; }
      
        public string Email { get; set; }
        
        public DateTime DOB { get; set; }
        public DateTime JoiningDate { get; set; }
    }
}
