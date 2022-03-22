using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
    public static class BL_TYP_ENS
    {
        public static List<DTO.TYP_ENS> SelectAll()
        {
            return DAL.DAL_TYP_ENS.SelectAll();
        }
    }
}
