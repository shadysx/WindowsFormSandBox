using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Insert test
            DTO.SEC sec = new DTO.SEC();
            sec.SEC_DES = "Insert test 2";
            sec.SEC_CDE = "9856 34 S33 D2";
            sec.SEC_CDE_DOM = "123";
            sec.SEC_FK_TYP_ENS = 3;
            BL.BL_SEC.Insert(sec);

        }
    }
}
