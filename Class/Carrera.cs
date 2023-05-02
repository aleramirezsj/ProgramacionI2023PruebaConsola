using PruebaConsola.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsola.Class
{
    public class Carrera
    {
        public string Nombre { get; set; }
        public int Años { get; set; }
        public TipoCarreraEnum  Tipo { get; set; }

        public Carrera(string nombre, int años, TipoCarreraEnum tipo)
        {
            this.Nombre = nombre;
            this.Años = años;
            this.Tipo = tipo;
        }

        public override string ToString()
        {
            return $"Carrera: {this.Nombre} Duración: {this.Años} años Tipo:{this.Tipo}";
        }
    }
}
