using System;
using PruebaConsola.Class;
using PruebaConsola.Enums;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            #region primera prueba de objetos
            /*Persona fabrizio = new Persona();   
            ColocarTitulo();
            fabrizio.PedirNombreYSaludar();
            fabrizio.PedirEdadYCalcularDiasDeVida();
            fabrizio.ChequearMayoriaEdad();
            fabrizio.ImprimeLineas();*/
            #endregion

            #region prueba de objetos instituto
            //[Clase] [nombre_objeto]= new [Clase]();
            //var [nombre_objeto]= new [Clase]();
            Materia mate=new Materia("Matemática I",TipoMateriaEnum.Anual);
            Materia mate2 = new Materia("Matemática II", TipoMateriaEnum.Anual);
            var copiaMate2 = mate2;
            copiaMate2.Nombre="Matemática Financiera";
            //comparamos objetos con el metodo Equals
            //bool sonIguales =mate2.Equals(copiaMate2);
            //var hash1=mate2.GetHashCode();
            //var hash2= copiaMate2.GetHashCode();
            //var hash3=mate.GetHashCode();
            Console.WriteLine(mate.ToString());
            Console.WriteLine(mate2.ToString());


            #endregion
        }

        static void ColocarTitulo()
        {
            #region título
            Console.WriteLine("Primera prueba en C# - PROYECTO DE CONSOLA");
            Console.WriteLine("******************************************");
            #endregion
        }

        

       
    }
}








/*




Console.ReadLine();
*/