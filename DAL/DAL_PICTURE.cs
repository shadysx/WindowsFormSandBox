using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DTO;

namespace DAL
{
    public static class DAL_PICTURE
    {
        public static List<PICTURE> SelectAll()
        {
            List<PICTURE> retVal = null;

            using (var connexion = CON_MANAGER.Connection)
                ////= SQL directe
                try
                {
                    retVal = connexion.Query<PICTURE>("select * from PICTURE").ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            return retVal;
        }
    }
}