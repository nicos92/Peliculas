
using Peliculas.Model;
using Peliculas.Singleton;
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
                MessageBox.Show("Error en base de datos: \n" + e.Message);
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show("Error en base de datos: \n" + e.Message);

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
                        FechaEstreno = reader.GetDateTime(2).ToString(),
                        Director = reader.GetString(3),
                        Recaudacion = reader.GetDecimal(4)
                    };

                    peliculas.Add(pelicula1);
                }
                dbconn.Close();

            }
            catch (SqlException e)
            {
                MessageBox.Show("Error en base de datos: \n" + e.Message);
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show("Error en base de datos: \n" + e.Message);

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
                MessageBox.Show("Error en base de datos: \n" + e.Message);
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show("Error en base de datos: \n" + e.Message);

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
                MessageBox.Show("Error en base de datos: \n" + e.Message);
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show("Error en base de datos: \n" + e.Message);

            }

            return result;
        }
    }
}