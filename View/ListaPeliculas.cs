using Peliculas.Repository;
using Peliculas.Singleton;
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
        }

        private void CargarListaPeliculas() => DataGridPeliculas.DataSource = PeliculaRepo.GetAllPeliculas();

        private void DataSelectionChanged()
        {
            PeliculaSingleton pelicula = PeliculaSingleton.GetInstance();
            pelicula.CargarDatos(Convert.ToInt32(DataGridPeliculas.CurrentRow.Cells["ID"].Value),
                                DataGridPeliculas.CurrentRow.Cells["Titulo"].Value.ToString(),
                                DataGridPeliculas.CurrentRow.Cells["FechaEstreno"].Value.ToString(),
                                DataGridPeliculas.CurrentRow.Cells["Director"].Value.ToString(),
                                Convert.ToDecimal(DataGridPeliculas.CurrentRow.Cells["Recaudacion"].Value)
                                );
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            CargarListaPeliculas();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            DataSelectionChanged();
        }
    }
}
