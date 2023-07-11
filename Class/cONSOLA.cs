using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsola.Class
{
    public class Consola
    {
        public static void EscribirLinea(string texto)
        {
            Console.WriteLine(texto);
        }
        public static void EscribirLinea(int numero)
        {
            Console.WriteLine(numero);
        }
        public static void EscribirLinea(DateTime fechaHora)
        {
            Console.WriteLine(fechaHora);
        }

        public static void Escribir(string texto)
        {
            Console.Write(texto);
        }

        public static int LeerNumeroEntero()
        {
            return int.Parse(Console.ReadLine());
            //return Convert.ToInt32(Console.ReadLine());
        }

        public static float LeerNumeroDecimal()
        {
            return float.Parse(Console.ReadLine());
        }
    }
}
