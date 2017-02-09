using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoREPO.Models
{
   public class Bruger
    {
       public int ID { get; set; }
       public string Brugernavn { get; set; }
       public string Adgangskode { get; set; }
       public string Email { get; set; }
       public int Lvl { get; set; }
    }
}
