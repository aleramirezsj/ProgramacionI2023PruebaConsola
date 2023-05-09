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
        //declaración de las propiedades
        public string Nombre { get; set; }
        public int Años { get; set; }
        public TipoCarreraEnum  Tipo { get; set; }

        //constructor
        public Carrera(string nombre, int años, TipoCarreraEnum tipo)
        {
            //guardamos el valor de los parámetros en las propiedades
            this.Nombre = nombre;
            this.Años = años;
            this.Tipo = tipo;
        }

        //sobreescribiendo el método ToString()
        public override string ToString()
        {
            return $"Carrera: {this.Nombre} Duración: {this.Años} años Tipo:{this.Tipo}";
        }
    }
}
