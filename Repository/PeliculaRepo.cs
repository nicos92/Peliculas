using Peliculas.ConexBD;
using Peliculas.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas.Repository
{
    public class PeliculaRepo
    {
        public static int InsertPelicula(Pelicula pelicula)
        {

            using SqlConnection connection = ConexBD.ConexBD.GetConnection();
            if (connection != null)
            {
                string insert = $"insert into pelicula values('{pelicula.Titulo}', '{pelicula.FechaEstreno}', '{pelicula.Director}', '{pelicula.Recaudacion}')";
                SqlCommand cmd = new(insert, connection);
                return cmd.ExecuteNonQuery();
            }

            return 0;
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

    }
}
