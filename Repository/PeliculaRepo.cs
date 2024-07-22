
using Npgsql;
using Peliculas.Model;
using Peliculas.Singleton;
using Peliculas.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas.Repository
{
    public static class PeliculaRepo
    {
        public static int InsertPelicula(Pelicula pelicula)
        {
            int result = 0;
             
            try
            {
                string insert = $"insert into pelicula values('{pelicula.Titulo}', '{pelicula.FechaEstreno}', '{pelicula.Director}', '{pelicula.Recaudacion}')";

                using NpgsqlCommand cmd = new(insert, BDPostgre.Instance.GetConnection);
                result = cmd.ExecuteNonQuery();
                BDPostgre.Instance.CloseConnection();


            }
            catch (NpgsqlException e)
            {
                BDPostgre.Instance.CloseConnection();
                Utils.Utils.CartelError("Error en base de datos SQL EXCEPTION", e.Message);
            }
            catch (InvalidOperationException e)
            {
                BDPostgre.Instance.CloseConnection();
                Utils.Utils.CartelError("Error en base de datos INVALID OPERATION", e.Message);
            }
            return result;
        }

        public static List<Pelicula> GetAllPeliculas()
        {
            List<Pelicula> peliculas = [];

            try
            {
                string all = "select * from pelicula";
                BDPostgre bDPostgre = BDPostgre.Instance;
                using NpgsqlCommand npgsqlCommand = new(all, bDPostgre.GetConnection);
                using NpgsqlDataReader reader = npgsqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Pelicula pelicula1 = new()
                    {
                        Titulo = reader.GetString(0),
                        FechaEstreno = reader.GetDateTime(1).ToString("yyyy-MM-dd"),
                        Director = reader.GetString(2),
                        Recaudacion = reader.GetDecimal(3).ToString(),
                        Id = reader.GetInt64(4)
                    };

                    peliculas.Add(pelicula1);
                }
               bDPostgre.CloseConnection();

            }
            catch (NpgsqlException e)
            {
                BDPostgre.Instance.CloseConnection();
                Utils.Utils.CartelError(e.Message, "Error en base de datos SQL EXCEPTION");
            }
            catch (InvalidOperationException e)
            {
                BDPostgre.Instance.CloseConnection();
                Utils.Utils.CartelError("Error en base de datos INVALID OPERATION", e.Message);
            }
            return peliculas;

        }

        public static int ActualizarPelicula(Pelicula pelicula)
        {
            int result = 0;
            try
            {
                

                string actualizar = $"update pelicula set titulo='{pelicula.Titulo}', fecha_estreno='{pelicula.FechaEstreno}', director='{pelicula.Director}', recaudacion={pelicula.Recaudacion} where idpelicula={pelicula.Id};";

                using NpgsqlCommand sqlCommand = new(actualizar, BDPostgre.Instance.GetConnection);
                result = sqlCommand.ExecuteNonQuery();
                BDPostgre.Instance.CloseConnection();


            }
            catch (NpgsqlException e)
            {
                BDPostgre.Instance.CloseConnection();

                Utils.Utils.CartelError("Error en base de datos SQL EXCEPTION", e.Message);
            }
            catch (InvalidOperationException e)
            {
                BDPostgre.Instance.CloseConnection();
                Utils.Utils.CartelError("Error en base de datos INVALID OPERATION", e.Message);


            }
            return result;

        }

        public static int EliminarPelicula(string id)
        {
            int result = 0;
            try
            {
                
                string eliminar = $"delete from pelicula where idpelicula = {id};";
                using NpgsqlCommand sqlCommand = new(eliminar, BDPostgre.Instance.GetConnection);
                result = sqlCommand.ExecuteNonQuery();
                BDPostgre.Instance.CloseConnection();

            }
            catch (NpgsqlException e)
            {
                BDPostgre.Instance.CloseConnection();

                Utils.Utils.CartelError("Error en base de datos SQL EXCEPTION", e.Message);
            }
            catch (InvalidOperationException e)
            {
                BDPostgre.Instance.CloseConnection();

                Utils.Utils.CartelError("Error en base de datos INVALID OPERATION", e.Message);


            }

            return result;
        }

        internal static List<Pelicula> FindPeliculas(string pelicula)
        {
            List<Pelicula> peliculas = [];
            try
            {


                string Find = $"select * from pelicula where titulo like '%{pelicula}%'";

                BDPostgre bDPostgre = BDPostgre.Instance;
                using NpgsqlCommand npgsqlCommand = new(Find, bDPostgre.GetConnection);
                using NpgsqlDataReader reader = npgsqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Pelicula pelicula1 = new()
                    {
                        Id = reader.GetInt32(4),
                        Titulo = reader.GetString(0),
                        FechaEstreno = reader.GetDateTime(1).ToString("yyyy-MM-dd"),
                        Director = reader.GetString(2),
                        Recaudacion = reader.GetDecimal(3).ToString()
                    };

                    peliculas.Add(pelicula1);
                }
                bDPostgre.CloseConnection();

            }
            catch (NpgsqlException e)
            {
                BDPostgre.Instance.CloseConnection();

                Utils.Utils.CartelError("Error en base de datos SQL EXCEPTION", e.Message);
            }
            catch (InvalidOperationException e)
            {
                BDPostgre.Instance.CloseConnection();

                Utils.Utils.CartelError("Error en base de datos INVALID OPERATION", e.Message);


            }

            return peliculas;

        }
    }
}