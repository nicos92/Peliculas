using Peliculas.Model;
using Peliculas.Utils;
using Peliculas.View;

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
            using var conn = ConexBD.ConexBD.GetConnection();
            if (conn != null)
            {
                MessageBox.Show("Conexion exitosa con Base de Datos");
                conn.Close();
            }
            else
            {
                MessageBox.Show("No hay conexion con la Base de Datos");
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

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicio inicio = new ();
            UtilVistas.MostrarVistas(inicio, PanelVistas);
            ConexionBD();

        }

       
    }
}
