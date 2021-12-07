using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConexionDB
{
    public class ConecctionToSql
    {
        private readonly string connectionstring;
        public ConecctionToSql()
        {
            connectionstring = "server=DESKTOP-Q2Q169R; DataBase=bd_papeletas ; integrated security=true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionstring);
        }
    }
}
