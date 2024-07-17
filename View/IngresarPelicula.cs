using Peliculas.Model;
using Peliculas.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peliculas.View
{
    public partial class ingresarPelicula : UserControl
    {
        public ingresarPelicula()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            Pelicula pelicula1 = new()
            {
                Titulo = TxtTitulo.Text,
                FechaEstreno = TxtFechaEstreno.Text,
                Director = TxtDirector.Text,
                Recaudacion = Convert.ToDecimal(TxtRecaudacion.Text)
            };

            MessageBox.Show($"{pelicula1.Titulo} {pelicula1.Recaudacion} {pelicula1.Director} {pelicula1.FechaEstreno} {pelicula1.Id}");

            int result = PeliculaRepo.InsertPelicula(pelicula1);
            if (result == 0) {
                MessageBox.Show("No se realizo el ingreso");

            }
            else
            {
                MessageBox.Show("Ingreso correcto");

            }

        }
    }
}
