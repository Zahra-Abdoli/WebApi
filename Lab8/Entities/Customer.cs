﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab8.Entities
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        [Required] 
        public string Name { get; set; }
        [Required] 
        public string LastName { get; set; }
        [Required] 
        public string Email { get; set; }

    }
}
