using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TYP_ENS
    {
        public int TYP_ENS_ID { get; set; }
        public string TYP_ENS_DES { get; set; }

        public List<SEC> TYP_ENS_SECS;
    }
}
