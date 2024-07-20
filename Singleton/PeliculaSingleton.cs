using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas.Singleton
{
    public class PeliculaSingleton
    {
        private static PeliculaSingleton? _instance;
        private static readonly object _lock = new();

        public int? Id { get; set; }
        public string? Titulo { get; set; }
        public string? FechaEstreno { get; set; }
        public string? Director { get; set; }

        public string? Recaudacion { get; set; }

        private PeliculaSingleton() { }

        public static PeliculaSingleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new PeliculaSingleton();
                }
            }
            return _instance;
        }

        public string VerDatos()
        {
            return $"ID: {Id}, Titulo: {Titulo}, Fecha de Estreno: {FechaEstreno}, Director: {Director}, Recaudacion: {Recaudacion}";
        }

        public void CargarDatos(int v1, string? v2, string? v3, string? v4, string? v5)
        {
            Id = v1;
            Titulo = v2;
            FechaEstreno = v3;
            Director = v4;
            Recaudacion = v5;
        }
    }
}
