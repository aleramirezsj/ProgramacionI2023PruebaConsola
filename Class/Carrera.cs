using PruebaConsola.Enums;
using System;
using System.Collections;
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
        private List<Materia> materias = new List<Materia>();
        private List<Docente> docentes = new List<Docente>();


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
            string retorno= $"Carrera: {this.Nombre} Duración: {this.Años} años Tipo:{this.Tipo} {Environment.NewLine}";
            retorno += $"Materias:{Environment.NewLine}";
            foreach (var materia in materias)
            {
                retorno += materia.ToString()+Environment.NewLine ;
            }
            retorno += $"Docentes:{Environment.NewLine}";
            foreach (var docente in docentes)
            {
                retorno += docente.Nombre + Environment.NewLine;
            }
            return retorno;
        }

        public void AgregarMateria(Materia materia)
        {
            materias.Add(materia);
        }
        public void AgregarDocente(Docente docente)
        {
            docentes.Add(docente);
        }
    }
}
