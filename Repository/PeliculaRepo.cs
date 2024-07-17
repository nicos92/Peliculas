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
                string insert = $"insert into pelicula values('{pelicula.Titulo}', '{pelicula.FechaEstreno}', '{pelicula.Director}', '{pelicula.Recaudacion})";
            MessageBox.Show($"insert: {insert}");
                SqlCommand cmd = new(insert, connection);
                return cmd.ExecuteNonQuery();

        }
        /*
        public static List<Pelicula> GetAllPeliculas()
        {
            string all = "select * from pelicula";

        }
        */
    }
}
