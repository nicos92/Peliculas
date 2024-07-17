using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas.Model
{
    public class Pelicula()
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Director {  get; set; }
        public string? FechaEstreno { get; set; }
        public decimal? Recaudacion { get; set; }

        public Pelicula(string titulo, string director, string fechaEstreno, decimal recaudacion) :this()
        {
            this.Titulo = titulo;
            this.Director = director;
            this.FechaEstreno = fechaEstreno;
            this.Recaudacion = recaudacion;
        }

        public void VerDatos()
        {
            MessageBox.Show($"{Titulo} {FechaEstreno} {Director}  {  Recaudacion}");
        }
       
    }
}
