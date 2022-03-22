using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class CON_MANAGER
    {
        public static IDbConnection Connection
        {
            get
            {
                return new SqlConnection(@"Data Source=shady.ddns.net;Initial Catalog=Etape2;Persist Security Info=True;User ID=sa;Password=this=Password**");
            }
        }
    }
}
