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
            #region pruebas de objetos instituto
            /*
            //creamos Docentes
            Docente mauri = new Docente("Mauri Mendoza", "Independencia 3520", 3498455223);
            Docente georgi = new Docente("Georgina Brusa", "9 de julio 2222", 3498555555);

            Console.WriteLine(mauri.ToString());

            #region prueba de objetos instituto
            //[Clase] [nombre_objeto]= new [Clase]();
            //var [nombre_objeto]= new [Clase]();
            Materia mate=new Materia("Matemática I",TipoMateriaEnum.Anual);
            Materia mate2 = new Materia("Matemática II", TipoMateriaEnum.Anual,georgi);
            var copiaMate2 = mate2;
            copiaMate2.Nombre="Matemática Financiera";
            //comparamos objetos con el metodo Equals
            //bool sonIguales =mate2.Equals(copiaMate2);
            //var hash1=mate2.GetHashCode();
            //var hash2= copiaMate2.GetHashCode();
            //var hash3=mate.GetHashCode();
            Console.WriteLine(mate.ToString());
            Console.WriteLine(mate2.ToString());

            //creamos Carreras
            Carrera desarrollo = new Carrera("Técnico Superior en Desarrollo de Software",3,TipoCarreraEnum.Tecnicatura);
            Carrera profNivelInicial = new Carrera("Profesorado de Nivel Inicial", 4, TipoCarreraEnum.Profesorado);
            Console.WriteLine(desarrollo.ToString());
            Console.WriteLine(profNivelInicial.ToString());
            */



            #endregion
            Docente ale = new Docente("Alejandro Ramirez", "Bv Roque Saenz Peña", 3498447106);
            Materia programacion1 = new Materia();
            programacion1.Nombre = "Programación I";
            programacion1.Tipo = TipoMateriaEnum.Anual;
            programacion1.DefinirDocente(ale);
            Materia programacion2=new Materia("Programación II",TipoMateriaEnum.Anual);
            programacion2.DefinirDocente(ale);
            //Console.WriteLine(programacion1.ToString());
            //Console.WriteLine(programacion2);
            //creamos Carreras
            Carrera desarrollo = new Carrera("Técnico Superior en Desarrollo de Software", 3, TipoCarreraEnum.Tecnicatura);
            desarrollo.AgregarMateria(programacion1);
            desarrollo.AgregarMateria(programacion2);
            desarrollo.AgregarDocente(ale);
            ale.AgregarMateria(programacion1);
            ale.AgregarMateria(programacion2);
            Console.Write(desarrollo.ToString());
            Console.WriteLine("****************************");
            Console.WriteLine(ale.ToString());
            Consola.EscribirLinea("Probando Escribir con nuestra clase en la consola");
            Consola.EscribirLinea(2023);
            Consola.EscribirLinea(DateTime.Now);
            Consola.EscribirLinea(Materia.instancias);

            ProbamosElOperadorTernario();
            ProbamosElOperadorTernario2();

        }

        private static void ProbamosElOperadorTernario2()
        {
            //probamos el operador ternario usando operaciones matemáticas condicionales, simulamos la situación de descuento "mes aniversario" que tiene 10% de descuento para compras mayor a $10000 y 5% para el resto
            Consola.Escribir("Ingrese el total de compra:");
            float importe = Consola.LeerNumeroDecimal();
            float importeFinal = importe > 10000 ? importe * 0.9f : importe * 0.95f;
            Consola.EscribirLinea("El importe final es: " + importeFinal);

        }

        private static void ProbamosElOperadorTernario()
        {
            //probamos el operador ternario usando asignaciones condicionales, simulamos la situación de la entrada a la montaña rusa.
            Consola.Escribir("Ingrese su altura en centimetros:");
            int altura = Consola.LeerNumeroEntero();
            string control = altura > 120 ? "Autorizado" : "No autorizado";
            Consola.EscribirLinea(control);
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