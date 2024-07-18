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
    public partial class ListaPeliculas : UserControl
    {
        public ListaPeliculas()
        {
            InitializeComponent();
            CargarListaPeliculas();
            BtnEnable();

        }

        private void CargarListaPeliculas()
        {
            DataGridPeliculas.DataSource = PeliculaRepo.GetAllPeliculas();
        }

        private void DataSelectionChanged()
        {
            if (DataGridPeliculas.CurrentRow != null)
            {


                PeliculaSingleton pelicula = PeliculaSingleton.GetInstance();
                pelicula.CargarDatos(Convert.ToInt32(DataGridPeliculas.CurrentRow.Cells["ID"].Value),
                                    DataGridPeliculas.CurrentRow.Cells["Titulo"].Value.ToString(),
                                    DataGridPeliculas.CurrentRow.Cells["FechaEstreno"].Value.ToString(),
                                    DataGridPeliculas.CurrentRow.Cells["Director"].Value.ToString(),
                                    Convert.ToDecimal(DataGridPeliculas.CurrentRow.Cells["Recaudacion"].Value)
                                    );
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            CargarListaPeliculas();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("¿Seguro quiere eliminar?", "ELIMINACION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resul == DialogResult.Yes)
            {

                int result = PeliculaRepo.EliminarPelicula(DataGridPeliculas.CurrentRow.Cells["ID"].Value.ToString() ?? "0");
                if (result != 0)
                {
                    MessageBox.Show("Eliminacion Correcta");
                    CargarListaPeliculas();
                }
                else
                {
                    MessageBox.Show("No se pudo Eliminar");

                }

            }


        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            DataSelectionChanged();
            ActualizarPelicula actualizar = new();
            UtilVistas.MostrarVistas(actualizar, PanelPeliculas);


        }



        private void BtnEnable()
        {
            if (DataGridPeliculas.RowCount.ToString() != "0")
            {
                BtnActualizar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
            else
            {
                BtnActualizar.Enabled = false;
                BtnEliminar.Enabled = false;
            }
        }



        private void DataGridPeliculas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            BtnEnable();
        }

        private void DataGridPeliculas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            BtnEnable();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataGridPeliculas.DataSource = PeliculaRepo.FindPeliculas(TxtBuscar.Text);
        }
    }
}
