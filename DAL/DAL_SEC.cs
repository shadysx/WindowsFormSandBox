using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace DAL
{
    public class DAL_SEC
    {
        //Select
        public static List<DTO.SEC> SelectAll()
        {
            List<DTO.SEC> retVal = null;

            using (var connexion = CON_MANAGER.Connection)
                ////= SQL directe
                //try
                //{
                //    retVal = connexion.Query<SEC>("select * from SEC order by SEC_DES").ToList();
                //}
                //catch(Exception ex)
                //{
                //    throw ex;
                //}
                //= Procédure stockée
                try
                {
                    retVal = connexion.Query<DTO.SEC>("sp_sec_select_all", CommandType.StoredProcedure).ToList();
                    Console.WriteLine(retVal);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            return retVal;

            
        }

        public static int Insert(DTO.SEC sec)
        {
            int retVal;

            using (var connection = CON_MANAGER.Connection)
                try
                {
                    retVal = connection.Query<int>("INSERT INTO SEC (SEC_DES,  SEC_CDE,  SEC_CDE_DOM,  SEC_FK_TYP_ENS)  " +
                                                   "       VALUES   (@SEC_DES, @SEC_CDE, @SEC_CDE_DOM, @SEC_FK_TYP_ENS); " +
                                                   "SELECT CAST(SCOPE_IDENTITY() AS INT)",
                                                   sec).Single();
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            return retVal;
        }
    }


}
