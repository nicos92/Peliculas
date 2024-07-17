using Peliculas.ConexBD;
using Peliculas.Model;
using Peliculas.Singleton;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
            /*
            using SqlConnection connection = ConexBD.ConexBD.GetConnection();
            if (connection != null)
            {
                string insert = $"insert into pelicula values('{pelicula.Titulo}', '{pelicula.FechaEstreno}', '{pelicula.Director}', '{pelicula.Recaudacion}')";
                MessageBox.Show(insert);
                SqlCommand cmd = new(insert, connection);
                return cmd.ExecuteNonQuery();
            }

            return 0;
            */
            int result = 0;
            using (var connection = DatabaseConnection.Instance.Connection)
            {
                if (connection != null)
                {
                    connection.Open();
                    string insert = $"insert into pelicula values('{pelicula.Titulo}', '{pelicula.FechaEstreno}', '{pelicula.Director}', '{pelicula.Recaudacion}')";
                    MessageBox.Show(insert);
                    SqlCommand cmd = new(insert, connection);
                    result = cmd.ExecuteNonQuery();
                    connection.Close();
                }
                // Ejecuta consultas o operaciones con la base de datos
            }
            return result;
        }

        public static List<Pelicula> GetAllPeliculas()
        {
            List<Pelicula> peliculas = [];

            string all = "select * from pelicula";
            using SqlConnection connection = ConexBD.ConexBD.GetConnection();
            if (connection != null)
            {
                SqlCommand cmd = new(all, connection);
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
                connection.Close();

            }

            return peliculas;

        }

        public static int ActualizarPelicula(Pelicula pelicula)
        {

            using SqlConnection connection = ConexBD.ConexBD.GetConnection();
            if (connection != null)
            {
                string actualizar = $"update pelicula set pelicula= '{pelicula.Titulo}', fecha_estreno='{pelicula.FechaEstreno}', director='{pelicula.Director}', recaudacion={pelicula.Recaudacion} where id={pelicula.Id};";

                MessageBox.Show("actualizar: " + actualizar);
                SqlCommand sqlCommand = new(actualizar, connection);
                return sqlCommand.ExecuteNonQuery();
            }
            return 0;

        }

        public static int EliminarPelicula(string id)
        {
            using SqlConnection sqlConnection = ConexBD.ConexBD.GetConnection();
            if (sqlConnection != null)
            {
                string eliminar = $"delete from pelicula where Id = {id};";
                SqlCommand sqlCommand = new(eliminar, sqlConnection);
                return sqlCommand.ExecuteNonQuery();
            }

            return 0;
        }
    }
}