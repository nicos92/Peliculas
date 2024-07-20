using Peliculas.Model;
using Peliculas.Repository;
using Peliculas.Singleton;
using Peliculas.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            TxtRecaudacionVer.Text = pelicula.Recaudacion;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult resul = Utils.Utils.CartelConfirmWarn("¿Seguro quiere Actualizar?", "Actualizacion");
            if (resul == DialogResult.Yes)
            {
                Pelicula pelicula1 = new()
                {
                    Id = Convert.ToInt32(TxtIdVer.Text),
                    Titulo = TxtTituloVer.Text,
                    FechaEstreno = TxtFechaEstrenoVer.Text,
                    Director = TxtDirectorVer.Text,
                    Recaudacion = TxtRecaudacionVer.Text
                };

                int result = PeliculaRepo.ActualizarPelicula(pelicula1);

                if (result == 0)
                {
                    Utils.Utils.CartelConfirmInfo("No se realizo la Actualizacion", "Actualizacion");
                }
                else
                {
                    Utils.Utils.CartelConfirmInfo("Actualizacion correcta", "Actualizacion");
                }
                MiPanelVistas.MostrarVistas(new ListaPeliculas());
            }
        }

        public void BtnEnable()
        {
            bool bEnabled = Utils.Utils.ValidarInt(TxtRecaudacionVer, TxtErrorRecaudacionVer);
            BtnActualizar.Enabled = (TxtDirectorVer.Text.Length > 0 && TxtRecaudacionVer.Text.Length > 0 && TxtTituloVer.Text.Length > 0 && !bEnabled);
        }

        private void TxtRecaudacionVer_TextChanged_1(object sender, EventArgs e)
        {
            BtnEnable();
        }

        private void TxtDirectorVer_TextChanged(object sender, EventArgs e)
        {
            BtnEnable();
        }

        private void TxtTituloVer_TextChanged(object sender, EventArgs e)
        {
            BtnEnable();
        }

        private void BtnEliminarVer_Click(object sender, EventArgs e)
        {
            DialogResult resul = Utils.Utils.CartelConfirmWarn("¿Seguro quiere eliminar?", "Wliminacion");
            if (resul == DialogResult.Yes)
            {
                int result = PeliculaRepo.EliminarPelicula(TxtIdVer.Text ?? "0");
                if (result != 0)
                {
                    Utils.Utils.CartelConfirmInfo("Eliminacion Correcta", "Eliminacion");
                    MiPanelVistas.MostrarVistas(new Inicio());
                }
                else
                {
                    Utils.Utils.CartelConfirmInfo("No se pudo Eliminar", "Elliminacion");
                }
            }
        }
    }
}
