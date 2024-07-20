
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
                DatabaseConnection dbconn = DatabaseConnection.Instance;
                
                
                dbconn.Open();
                string insert = $"insert into pelicula values('{pelicula.Titulo}', '{pelicula.FechaEstreno}', '{pelicula.Director}', '{pelicula.Recaudacion}')";

                SqlCommand cmd = new(insert, dbconn.Connection);
                result = cmd.ExecuteNonQuery();
                dbconn.Close();   

            }
            catch (SqlException e)
            {
                DatabaseConnection.Instance.Close();
                Utils.Utils.CartelError("Error en base de datos SQL EXCEPTION", e.Message);
            }
            catch (InvalidOperationException e)
            {
                DatabaseConnection.Instance.Close();
                Utils.Utils.CartelError("Error en base de datos INVALID OPERATION", e.Message);


            }



            return result;
        }

        public static List<Pelicula> GetAllPeliculas()
        {
            List<Pelicula> peliculas = [];

            try
            {
                DatabaseConnection dbconn = DatabaseConnection.Instance;


                dbconn.Open();

                string all = "select * from pelicula";
                SqlCommand cmd = new(all, dbconn.Connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Pelicula pelicula1 = new()
                    {
                        Id = reader.GetInt32(0),
                        Titulo = reader.GetString(1),
                        FechaEstreno = reader.GetDateTime(2).ToString("yyyy-MM-dd"),
                        Director = reader.GetString(3),
                        Recaudacion = reader.GetDecimal(4).ToString()
                    };

                    peliculas.Add(pelicula1);
                }
                dbconn.Close();

            }
            catch (SqlException e)
            {
                DatabaseConnection.Instance.Close();
                Utils.Utils.CartelError("Error en base de datos SQL EXCEPTION", e.Message);
            }
            catch (InvalidOperationException e)
            {
                DatabaseConnection.Instance.Close();
                Utils.Utils.CartelError("Error en base de datos INVALID OPERATION", e.Message);


            }
            return peliculas;

        }

        public static int ActualizarPelicula(Pelicula pelicula)
        {
            int result = 0;
            try
            {
                DatabaseConnection dbconn = DatabaseConnection.Instance;


                dbconn.Open();

                string actualizar = $"update pelicula set titulo='{pelicula.Titulo}', fecha_estreno='{pelicula.FechaEstreno}', director='{pelicula.Director}', recaudacion={pelicula.Recaudacion} where id={pelicula.Id};";

                SqlCommand sqlCommand = new(actualizar, dbconn.Connection);
                result = sqlCommand.ExecuteNonQuery();
                dbconn.Close();

            }
            catch (SqlException e)
            {
                DatabaseConnection.Instance.Close();
                Utils.Utils.CartelError("Error en base de datos SQL EXCEPTION", e.Message);
            }
            catch (InvalidOperationException e)
            {
                DatabaseConnection.Instance.Close();
                Utils.Utils.CartelError("Error en base de datos INVALID OPERATION", e.Message);


            }
            return result;

        }

        public static int EliminarPelicula(string id)
        {
            int result = 0;
            try
            {
                DatabaseConnection dbconn = DatabaseConnection.Instance;


                dbconn.Open();
                string eliminar = $"delete from pelicula where Id = {id};";
                SqlCommand sqlCommand = new(eliminar, dbconn.Connection);
                result = sqlCommand.ExecuteNonQuery();
                dbconn.Close();

            }
            catch (SqlException e)
            {
                DatabaseConnection.Instance.Close();
                Utils.Utils.CartelError("Error en base de datos SQL EXCEPTION", e.Message);
            }
            catch (InvalidOperationException e)
            {
                DatabaseConnection.Instance.Close();
                Utils.Utils.CartelError("Error en base de datos INVALID OPERATION", e.Message);


            }

            return result;
        }

        internal static List<Pelicula> FindPeliculas(string pelicula)
        {
            List<Pelicula> peliculas = [];
            try
            {
                DatabaseConnection dbconn = DatabaseConnection.Instance;

                dbconn.Open();

                string Find = $"select * from pelicula where titulo like '%{pelicula}%'";
                SqlCommand cmd = new(Find, dbconn.Connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Pelicula pelicula1 = new()
                    {
                        Id = reader.GetInt32(0),
                        Titulo = reader.GetString(1),
                        FechaEstreno = reader.GetDateTime(2).ToString("yyyy-MM-dd"),
                        Director = reader.GetString(3),
                        Recaudacion = reader.GetDecimal(4).ToString()
                    };

                    peliculas.Add(pelicula1);
                }
                dbconn.Close();

            }
            catch (SqlException e)
            {
                DatabaseConnection.Instance.Close();
                Utils.Utils.CartelError("Error en base de datos SQL EXCEPTION", e.Message);
            }
            catch (InvalidOperationException e)
            {
                DatabaseConnection.Instance.Close();
                Utils.Utils.CartelError("Error en base de datos INVALID OPERATION", e.Message);


            }

            return peliculas;

        }
    }
}