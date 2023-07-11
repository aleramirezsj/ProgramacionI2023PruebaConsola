using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsola.Class
{
    public class Docente
    {
        //definición de propiedades
        public string Nombre { get; set; }
        public string Dirección { get; set; }
        public uint Teléfono { get; set; }
        private List<Materia> materias = new List<Materia>();

        //constructor que recibe parámetros
        public Docente(string nombre, string dirección, uint teléfono)
        {
            this.Nombre = nombre;
            this.Dirección = dirección;
            this.Teléfono = teléfono;
        }

        public override string ToString()
        {
            string retorno= $"Docente:{this.Nombre} Dirección:{this.Dirección} Teléfono:{this.Teléfono} {Environment.NewLine}";
            retorno += "Materias que dicta:"+Environment.NewLine;
            foreach (var materia in this.materias)
            {
                retorno += materia.Nombre + Environment.NewLine;
            }
            return retorno;
        }

        public void AgregarMateria(Materia materia)
        {
            materias.Add(materia);
        }

    }
}
