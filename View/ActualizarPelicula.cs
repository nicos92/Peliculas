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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
            pelicula.VerDatos();
            TxtIdActualizar.Text = pelicula.Id.ToString();
            TxtTituloActualizar.Text = pelicula.Titulo;
            TxtFechaEstrenoActualizar.Value = Convert.ToDateTime(pelicula.FechaEstreno);
            TxtDirectorActualizar.Text = pelicula.Director;
            TxtRecaudacionAct.Text = pelicula.Recaudacion;
        }

        private void BtnActualizarActualizar_Click(object sender, EventArgs e)
        {
            DialogResult resul = Utils.Utils.CartelConfirmWarn("¿Seguro quiere Actualizar?", "Actualizacion");
            if (resul == DialogResult.Yes)
            {
                Pelicula pelicula1 = new()
                {
                    Id = Convert.ToInt32(TxtIdActualizar.Text),
                    Titulo = TxtTituloActualizar.Text,
                    FechaEstreno = TxtFechaEstrenoActualizar.Text,
                    Director = TxtDirectorActualizar.Text,
                    Recaudacion = TxtRecaudacionAct.Text
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

        public void BtnEnabled()
        {
            bool bEnabled = Utils.Utils.ValidarInt(TxtRecaudacionAct, TxtErrorRecaudacionAct);
            BtnActualizarActualizar.Enabled = (TxtDirectorActualizar.Text.Length > 0 && TxtTituloActualizar.Text.Length > 0 && TxtRecaudacionAct.Text.Length > 0 && !bEnabled);
        }

        private void TxtRecaudacionAct_TextChanged(object sender, EventArgs e)
        {
            BtnEnabled();
        }

        private void TxtDirectorActualizar_TextChanged(object sender, EventArgs e)
        {
            BtnEnabled();
        }

        private void TxtTituloActualizar_TextChanged(object sender, EventArgs e)
        {
            BtnEnabled();
        }
    }
}
