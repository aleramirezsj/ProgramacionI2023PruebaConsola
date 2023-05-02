using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsola.Class
{
    class Persona
    {
        private string? nombre = "";
        private string apellido = "Ramirez";
        private int edad = 0;
        private int diasDeVida = 0;

        public void PedirEdadYCalcularDiasDeVida()
        {
            Console.Write("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            diasDeVida = edad * 365;
            Console.WriteLine($"sus días de vida aproximados son:{diasDeVida}");
        }
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
        public void PedirNombreYSaludar()
        {
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " " + apellido + ", como te va?");
            Console.WriteLine($"Hola {nombre} {apellido}, como te va?");
        }


    }
}
