using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsola.Class
{
    public class Docente
    {
        public string Nombre { get; set; }
        public string Dirección { get; set; }
        public uint Teléfono { get; set; }

        public Docente(string nombre, string dirección, uint teléfono)
        {
            this.Nombre = nombre;
            this.Dirección = dirección;
            this.Teléfono = teléfono;
        }

        public override string ToString()
        {
            return $"Docente:{this.Nombre} Dirección:{this.Dirección} Teléfono:{this.Teléfono}";
        }

    }
}
