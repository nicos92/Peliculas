using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas.ConexBD
{
    public class ConexBD
    {
        private const string DATABASE = "peliculas";
        private const string DATASOURCE = "nicos\\SQLEXPRESS";
        private const string INTEGRATED_SECURITY = "SSPI";
        private const string PERSIST_SECURITY_INFO = "false";
        public static SqlConnection? GetConnection()
        {
            try
            {

                SqlConnection conn = new()
                {
                    ConnectionString = $" Initial Catalog={DATABASE}; Data Source={DATASOURCE}; Integrated Security={INTEGRATED_SECURITY}; Persist Security Info={PERSIST_SECURITY_INFO};"
                };
                conn.Open();
                return conn;
            }
            catch (SqlException)
            {
            }
            return null;
        }
    }
}
