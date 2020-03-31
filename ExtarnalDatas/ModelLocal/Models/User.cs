﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLocal.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public string Login { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public bool Active { get; set; }
    }
}
