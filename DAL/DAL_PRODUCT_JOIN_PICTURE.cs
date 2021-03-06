using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace DAL
{
    public class DAL_PRODUCT_JOIN_PICTURE
    {
        //Select
        public static List<DTO.PRODUCT_JOIN_PICTURE> SelectAll()
        {
            List<DTO.PRODUCT_JOIN_PICTURE> retVal = null;

            using (var connexion = CON_MANAGER.Connection)
                ////= SQL directe
                try
                {
                    retVal = connexion.Query<DTO.PRODUCT_JOIN_PICTURE>("select * from PRODUCT inner join PICTURE on PRODUCT.ID_PRODUCT = PICTURE.ID_PRODUCT").ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            //= Procédure stockée
            /*                try
                            {
                                retVal = connexion.Query<DTO.SEC>("sp_sec_select_all", CommandType.StoredProcedure).ToList();
                                Console.WriteLine(retVal);
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }*/
            return retVal;
        }

        //Select all uniques PRODUCT_TYPES
        public static List<DTO.PRODUCT_JOIN_PICTURE> SelectAllUniqueProductTypes()
        {
            List<DTO.PRODUCT_JOIN_PICTURE> retVal = null;

            using (var connexion = CON_MANAGER.Connection)
                ////= SQL directe
                try
                {
                    retVal = connexion.Query<DTO.PRODUCT_JOIN_PICTURE>("select distinct PRODUCT_TYPE from PRODUCT").ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            //= Procédure stockée
            /*                try
                            {
                                retVal = connexion.Query<DTO.SEC>("sp_sec_select_all", CommandType.StoredProcedure).ToList();
                                Console.WriteLine(retVal);
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }*/
            return retVal;
        }

        //Select by name
        //Select
        public static List<DTO.PRODUCT_JOIN_PICTURE> SelectByName(string name)
        {
            List<DTO.PRODUCT_JOIN_PICTURE> retVal = null;

            using (var connexion = CON_MANAGER.Connection)
                ////= SQL directe
                try
                {
                    retVal = connexion.Query<DTO.PRODUCT_JOIN_PICTURE>($"select * from PRODUCT inner join PICTURE on PRODUCT.ID_PRODUCT = PICTURE.ID_PRODUCT where PRODUCT_NAME like'%{name}%'").ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            //= Procédure stockée
            /*                try
                            {
                                retVal = connexion.Query<DTO.SEC>("sp_sec_select_all", CommandType.StoredProcedure).ToList();
                                Console.WriteLine(retVal);
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }*/
            return retVal;


        }

        public static List<DTO.PRODUCT_JOIN_PICTURE> SelectByType(string type)
        {
            List<DTO.PRODUCT_JOIN_PICTURE> retVal = null;

            using (var connexion = CON_MANAGER.Connection)
                ////= SQL directe
                try
                {
                    retVal = connexion.Query<DTO.PRODUCT_JOIN_PICTURE>($"select * from PRODUCT inner join PICTURE on PRODUCT.ID_PRODUCT = PICTURE.ID_PRODUCT where PRODUCT_TYPE = '{type}'").ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            //= Procédure stockée
            /*                try
                            {
                                retVal = connexion.Query<DTO.SEC>("sp_sec_select_all", CommandType.StoredProcedure).ToList();
                                Console.WriteLine(retVal);
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }*/
            return retVal;


        }

        /*        public static int Insert(DTO.SEC sec)
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
            */
    }


}
