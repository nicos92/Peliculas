using Peliculas.Model;
using Peliculas.Repository;
using Peliculas.Singleton;
using Peliculas.Utils;
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
    public partial class ActualizarPelicula : UserControl
    {
        public ActualizarPelicula()
        {
            InitializeComponent();
            CargarCampos();
        }

        private void CargarCampos()
        {
            PeliculaSingleton pelicula = PeliculaSingleton.GetInstance();
            TxtIdActualizar.Text = pelicula.Id.ToString();
            TxtTituloActualizar.Text = pelicula.Titulo;
            TxtFechaEstrenoActualizar.Text = pelicula.FechaEstreno;
            TxtDirectorActualizar.Text = pelicula.Director;
            TxtRecaudacionActualizar.Value = Convert.ToDecimal(pelicula.Recaudacion);
        }

        private void BtnActualizarActualizar_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("¿Seguro quiere Actualizar?", "ACTUALIZACION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resul == DialogResult.Yes)
            {
                Pelicula pelicula1 = new()
                {
                    Id = Convert.ToInt32(TxtIdActualizar.Text),
                    Titulo = TxtTituloActualizar.Text,
                    FechaEstreno = TxtFechaEstrenoActualizar.Text,
                    Director = TxtDirectorActualizar.Text,
                    Recaudacion = Convert.ToDecimal(TxtRecaudacionActualizar.Value)
                };

                int result = PeliculaRepo.ActualizarPelicula(pelicula1);

                if (result == 0)
                {
                    MessageBox.Show("No se realizo la Actualizacion");
                }
                else
                {
                    MessageBox.Show("Actualizacion correcta");

                }
                UtilVistas.MostrarVistas(new ListaPeliculas(), Panel1Actualizar);
            }
        }

    }
}
