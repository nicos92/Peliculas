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
    public partial class VerPelicula : UserControl
    {
        public VerPelicula()
        {
            InitializeComponent();
            CargarCampos();
        }

        private void CargarCampos()
        {
            PeliculaSingleton pelicula = PeliculaSingleton.GetInstance();
            TxtIdVer.Text = pelicula.Id.ToString();
            TxtTituloVer.Text = pelicula.Titulo;
            TxtFechaEstrenoVer.Text = pelicula.FechaEstreno;
            TxtDirectorVer.Text = pelicula.Director;
            TxtRecaudacionVer.Value = Convert.ToDecimal(pelicula.Recaudacion);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult resul = UtilVistas.CartelConfirmWarn("¿Seguro quiere Actualizar?", "Actualizacion");
            if (resul == DialogResult.Yes)
            {
                Pelicula pelicula1 = new()
                {
                    Id = Convert.ToInt32(TxtIdVer.Text),
                    Titulo = TxtTituloVer.Text,
                    FechaEstreno = TxtFechaEstrenoVer.Text,
                    Director = TxtDirectorVer.Text,
                    Recaudacion =  Convert.ToDecimal(TxtRecaudacionVer.Value.ToString().Replace(",","."))
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
                UtilVistas.MostrarVistas(new ListaPeliculas(), PanelVerPelicula);
            }
        }

        private void BtnEliminarVer_Click(object sender, EventArgs e)
        {

        }

       
    }
}
