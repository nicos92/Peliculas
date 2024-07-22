using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Peliculas.Singleton
{
    public class BDPostgre
    {
        private static BDPostgre? _instance;
        private static readonly object _lock = new();
        private readonly NpgsqlConnection _connection;
       

        private const string Host = "LocalHost";
        private const string Username = "postgres";
        private const string Password = "340480_Nss";
        private const string Database = "peliculas";

        private const string connString = $"Host={Host};Username={Username};Password={Password};Database={Database}; MaxPoolSize=200;";

        private BDPostgre() {
            _connection = new NpgsqlConnection(connString);
        }

        public static BDPostgre Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        _instance ??= new BDPostgre();
                    }
                }
                return _instance;
            }
        }

        public NpgsqlConnection GetConnection
        {
            get
            {
                if (_connection.State != System.Data.ConnectionState.Open)
                    _connection.Open();

                return _connection;
            }
        }

        public void CloseConnection()
        {
            if(_connection.State != System.Data.ConnectionState.Closed)
                _connection.Close();
        }

       

    }
}
