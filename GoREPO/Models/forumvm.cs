using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoREPO.Models
{
   public class forumvm
    {
        public List<Forumliste> Forumliste { get; set; }
        public List<FDiskussion> Diskussions { get; set; }
        public List<FNyhed> Nyheder { get; set; }
    }
}
