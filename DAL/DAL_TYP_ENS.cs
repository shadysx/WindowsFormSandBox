using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DTO;

namespace DAL
{
    public static class DAL_TYP_ENS
    {
        public static List<TYP_ENS> SelectAll()
        {
            List<TYP_ENS> retVal = null;


            using (var connexion = CON_MANAGER.Connection)
                try
                {
                    retVal = connexion.Query<TYP_ENS>("sp_typ_ens_select_all", CommandType.StoredProcedure).ToList();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            return retVal;
        }
    }
}

