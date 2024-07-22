using Peliculas.Model;
using Peliculas.Repository;
using Peliculas.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peliculas.View
{
    public partial class IngresarPelicula : UserControl
    {
        public IngresarPelicula()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {
            TxtTitulo.Clear();
            TxtFechaEstreno.ResetText();
            TxtDirector.Clear();
            TxtRecaudacionIng.Clear();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = Utils.Utils.CartelConfirmWarn("¿Seguro quiere ingresar?", "Ingreso");
            if (dialogResult == DialogResult.Yes)
            {
                Pelicula pelicula1 = new()
                {
                    Titulo = TxtTitulo.Text,
                    FechaEstreno = TxtFechaEstreno.Text,
                    Director = TxtDirector.Text,
                    Recaudacion = TxtRecaudacionIng.Text
                };
                int result = PeliculaRepo.InsertPelicula(pelicula1);

                if (result == 0)
                {
                    Utils.Utils.CartelError("No se realizo el Ingreso", "Ingreso Incorrecto");
                }
                else
                {
                    Utils.Utils.CartelConfirmInfo( "EL Ingreso se Realizo Correctamente", "Ingreso Correcto");
                    ResetForm();
                }
                TxtTitulo.Focus();
            }
        }

        public void BtnEnable()
        {
            bool bEnabled = Utils.Utils.ValidarInt(TxtRecaudacionIng, TxtErrorRecaudacion);
            BtnGuardar.Enabled = (TxtDirector.Text.Length > 0 && TxtRecaudacionIng.Text.Length > 0 && TxtTitulo.Text.Length > 0 && !bEnabled);
        }


        private void TxtRecaudacionIng_TextChanged(object sender, EventArgs e)
        {
            BtnEnable();
        }

        private void TxtDirector_TextChanged(object sender, EventArgs e)
        {
            BtnEnable();
        }

        private void TxtTitulo_TextChanged(object sender, EventArgs e)
        {
            BtnEnable();
        }

        private void IngresarPelicula_Load(object sender, EventArgs e)
        {
            TxtTitulo.Focus();
            TxtFechaEstreno.MaxDate = DateTime.Now; 
            TxtFechaEstreno.Value    = DateTime.Today;
        }
    }
}
