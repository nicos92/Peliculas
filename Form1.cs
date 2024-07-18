using Peliculas.Model;
using Peliculas.Singleton;
using Peliculas.Utils;
using Peliculas.View;
using System.Data.SqlClient;

namespace Peliculas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private static void ConexionBD()
        {
            try
            {
                DatabaseConnection dbconn = DatabaseConnection.Instance;


                dbconn.Open();
                    MessageBox.Show("Conexion exitosa con Base de Datos");
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

        }


        private void BtnVerTodas_Click(object sender, EventArgs e)
        {
            ListaPeliculas listaPeliculas = new();
            UtilVistas.MostrarVistas(listaPeliculas, PanelVistas);
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            IngresarPelicula ingresarPelicula = new();
            UtilVistas.MostrarVistas(ingresarPelicula, PanelVistas);
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicio inicio = new();
            UtilVistas.MostrarVistas(inicio, PanelVistas);
            ConexionBD();

        }


    }
}
