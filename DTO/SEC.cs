using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SEC
    {
        public int SEC_ID { get; set; }
        public string SEC_DES { get; set; }
        public string SEC_CDE { get; set; }
        public string SEC_CDE_DOM { get; set; }
        public int? SEC_FK_TYP_ENS { get; set; }
    }
}
