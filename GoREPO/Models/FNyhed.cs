﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoREPO.Models
{
   public class FNyhed
    {
        public int ID { get; set; }
        public string Overskrift { get; set; }
        public string Tekst { get; set; }
        public DateTime Dato { get; set; }
        
    }
}
