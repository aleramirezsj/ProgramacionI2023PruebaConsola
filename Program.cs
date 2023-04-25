using System;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos un objeto, instanciamos la clase Persona
            Persona fabrizio = new Persona();   
            ColocarTitulo();
            PedirNombreYSaludar(fabrizio);
            fabrizio.PerdirNombreYSaludar();
            PedirEdadYCalcularDiasDeVida(fabrizio);
            fabrizio.ChequearMayoriaEdad();
            fabrizio.ImprimeLineas();
        }

        static void ColocarTitulo()
        {
            #region título
            Console.WriteLine("Primera prueba en C# - PROYECTO DE CONSOLA");
            Console.WriteLine("******************************************");
            #endregion
        }

        static void PedirNombreYSaludar(Persona persona)
        {
            Console.Write("Ingrese su nombre: ");
            persona.nombre = Console.ReadLine();
            Console.WriteLine("Hola " + persona.nombre + " " + persona.apellido + ", como te va?");
            Console.WriteLine($"Hola {persona.nombre} {persona.apellido}, como te va?");
        }

        static void PedirEdadYCalcularDiasDeVida(Persona persona)
        {
            Console.Write("Ingrese su edad: ");
            persona.edad = Convert.ToInt32(Console.ReadLine());
            persona.diasDeVida = persona.edad * 365;
            Console.WriteLine($"sus días de vida aproximados son:{persona.diasDeVida}");
        }
    }
    class Persona
    {
        public string? nombre = "";
        public string apellido = "Ramirez";
        private int edad = 0;
        public int diasDeVida = 0;

        public void ChequearMayoriaEdad()
        {
            if (diasDeVida > 6500)
            {
                Console.WriteLine("No se necesita autorización");
            }
            else
            {
                Console.WriteLine("Se necesita autorización de sus padres");
            }
        }
        public void ImprimeLineas()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Linea Nº{i + 1} {nombre}");
            }
        }


    }
}








/*




Console.ReadLine();
*/