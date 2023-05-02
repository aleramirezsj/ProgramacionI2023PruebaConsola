using PruebaConsola.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsola.Class
{
    public class Materia
    {
        public string Nombre { get; set; }
        public TipoMateriaEnum Tipo { get; set; }
        //constructor
        public Materia(string nombre, TipoMateriaEnum tipo)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
        }
        public override string ToString()
        {
            return $"Materia: {this.Nombre} Tipo:{this.Tipo}";
        }
    }
}
