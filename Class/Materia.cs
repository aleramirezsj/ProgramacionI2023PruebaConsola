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
        //constructor que no recibe parámetros
        public Materia()
        {
            
        }
        //constructor
        public Materia(string nombre, TipoMateriaEnum tipo, Docente docente)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Docente = docente;
        }

        public Materia(string nombre, TipoMateriaEnum tipo)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
        }

        public void DefinirDocente(Docente docente)
        { 
            this.Docente = docente; 
        }
        public override string ToString()
        {
            return $"Materia: {this.Nombre} Tipo:{this.Tipo} {Environment.NewLine} {this.Docente.ToString()}";
        }
    }
}
