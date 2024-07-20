using System;
using System.Data.SqlClient;

namespace Peliculas.Singleton;
public class DatabaseConnection
{
    private static DatabaseConnection? _instance;
    private static readonly object _lock = new();
    private readonly SqlConnection _connection;
    private const string DATABASE = "peliculas"; // NOMBRE DE LA BASE DE DATOS
    private const string DATASOURCE = "nicos\\SQLEXPRESS";
    private const string INTEGRATED_SECURITY = "SSPI"; //  se utilizan las credenciales de la cuenta de Windows actual para la autenticación.
    private const string PERSIST_SECURITY_INFO = "false";

    private DatabaseConnection()
    {
        _connection = new SqlConnection($"Data Source={DATASOURCE};Initial Catalog={DATABASE}; Integrated Security={INTEGRATED_SECURITY}; Persist Security Info={PERSIST_SECURITY_INFO}");
    }

    public static DatabaseConnection Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new DatabaseConnection();
                }
            }
            return _instance;
        }
    }

    public SqlConnection Connection
    {
        get { return _connection; }
    }

    public void Open()
    {
        if (_instance != null)
            _connection.Open();
    }

    public void Close()
    {
        if (_instance != null)
            _connection.Close();
    }
}