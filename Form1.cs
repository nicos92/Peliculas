using Peliculas.View;

namespace Peliculas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConexionBD();
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

        private void MostrarVistas(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelVistas.Controls.Clear();
            PanelVistas.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void BtnVerTodas_Click(object sender, EventArgs e)
        {
            ListaPeliculas listaPeliculas = new ();
            MostrarVistas(listaPeliculas);
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            ingresarPelicula ingresarPelicula = new ();
            MostrarVistas(ingresarPelicula);
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
