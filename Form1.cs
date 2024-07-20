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

        private void BtnVerTodas_Click(object sender, EventArgs e)
        {
            ListaPeliculas listaPeliculas = new();
            MiPanelVistas.MostrarVistas(listaPeliculas);
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            IngresarPelicula ingresarPelicula = new();
            MiPanelVistas.MostrarVistas(ingresarPelicula);
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicio inicio = new();
            MiPanelVistas.MostrarVistas(inicio);
            

        }


    }
}
