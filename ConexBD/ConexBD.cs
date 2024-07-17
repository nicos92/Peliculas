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
        private const string DATABASE = "peliculas"; // NOMBRE DE LA BASE DE DATOS
        private const string DATASOURCE = "e"; // "nicos\\SQLEXPRESS"; 
        private const string INTEGRATED_SECURITY = "SSPI"; //  se utilizan las credenciales de la cuenta de Windows actual para la autenticación.
        private const string PERSIST_SECURITY_INFO = "false";
        /*
         * La configuración PERSIST_SECURITY_INFO  como verdadero o falso solo tendrá efecto si menciona el nombre de usuario y la contraseña en la cadena de conexión. Si menciona el nombre de usuario y la contraseña en la cadena de conexión y la configura Persist Security Infocomo falsetal, no se podrán extraer las credenciales, pero si la configura Persist Security Infocomo verdadero al proporcionar las credenciales en la cadena de conexión, Windows recordará las credenciales y se podrán extraer mediante programación.
         * */

        /**
         * METODO PARA OBTENER LA CONEXION CON LA BASE DE DATOS
         */
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
