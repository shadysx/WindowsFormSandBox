using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DTO;

namespace DAL
{
    public static class DAL_PRODUCT
    {
        public static List<PRODUCT> SelectAll()
        {
            List<PRODUCT> retVal = null;

            using (var connexion = CON_MANAGER.Connection)
                ////= SQL directe
                try
                {
                    retVal = connexion.Query<PRODUCT>("select * from PRODUCT").ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            return retVal;
        }
    }
}
