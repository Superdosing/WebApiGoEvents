using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoREPO.Models
{
    public class Events
    {
        public int ID { get; set; }
        public string Overskrift { get; set; }
        public string Tekst { get; set; }
        public string Start { get; set; }
        public DateTime Dato { get; set; }
        public string Billed { get; set; }
        public string City { get; set; }
        public string Postnr { get; set; }
        public string Adresse { get; set; }
    }
}
