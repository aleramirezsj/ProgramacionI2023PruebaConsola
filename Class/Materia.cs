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
        private Docente Docente { get; set; }

        public static int instancias;
        //constructor que no recibe parámetros
        public Materia()
        {
            instancias++;
        }
        //constructor
        public Materia(string nombre, TipoMateriaEnum tipo, Docente docente)
        {
            instancias++;
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Docente = docente;
        }

        public Materia(string nombre, TipoMateriaEnum tipo)
        {
            instancias++;
            this.Nombre = nombre;
            this.Tipo = tipo;
        }

        public void DefinirDocente(Docente docente)
        { 
            this.Docente = docente; 
        }
        public override string ToString()
        {
            return $"Materia: {this.Nombre} Tipo:{this.Tipo} {Environment.NewLine} Docente:{this.Docente.Nombre}";
        }
    }
}
