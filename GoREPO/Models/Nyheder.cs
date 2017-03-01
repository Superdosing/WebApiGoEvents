using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoREPO.Factories;

namespace GoREPO.Models
{
    public class Nyheder
    {
        public int ID { get; set; }
        public string Overskrift { get; set; }
        public string Tekst { get; set; }
        public DateTime Dato { get; set; }
        public string Billed { get; set; }

       

     
    }
}
