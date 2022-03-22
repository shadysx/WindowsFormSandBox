using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class BL_SEC
    {
        //Select
        public static List<DTO.SEC> SelectAll()
        {
            return DAL.DAL_SEC.SelectAll(); 
        }

        public static int Insert(DTO.SEC sec)
        {
            return DAL.DAL_SEC.Insert(sec);
        }
    }
}
