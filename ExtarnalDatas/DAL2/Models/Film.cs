﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL2.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public int AnneeSortie { get; set; }
        public string Genre { get; set; }
    }
}
