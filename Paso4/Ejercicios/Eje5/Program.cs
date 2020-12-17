using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Estudiante: Luis David Huertas Redondo
 * Grupo: 17
 * Programa: Ingenieria de sistemas
 * Codigo fuente: Autoria propia
 * 
 * Ejercicio 5
 * Desarrolle una solución básica de programación que pida por teclado
 * tres (3) notas de un estudiante, se debe validar mediante un método
 * que la nota esté entre 0 y 5 por tanto en caso de que se ingresen otros
 * valores dar un mensaje que diga valor no valido.
 * Debe tener en cuenta que la nota puede ser un valor real, ejemplo 2.5
 * una vez obtenidas las tres (3) notas se debe calcular el promedio de
 * estas e imprima por pantalla alguno de los siguientes mensajes:
 * • Si el promedio es >=4.6 mostrar "Excelente"
 * • Si el promedio es >=4.0 y =<4.5 mostrar "Muy bueno"
 * • Si el promedio es >=3.5 y =<3.9 mostrar "Bueno"
 * • Si el promedio es >=3.0 y =<3.4 mostrar "Satisfactorio"
 * • Si el promedio es <3 mostrar "Deficiente"
 */
namespace Eje5
{
    class Program
    {
        static void Main(string[] args)
        {
            Calificacion calificacion = new Calificacion();
            string op;
            Console.WriteLine("=================================== Calcular promedio de 3 notas ===================================\n");
            Console.WriteLine("Recuerda que la nota esté entre 0 y 5, si tu nota tiene decimales digitalos con comas, ejemplo: 4,5\n");
            do
            {
                calificacion.pedirNotas();
                calificacion.CalcularPromedio();
                calificacion.MostrarNotas();
                Console.WriteLine($"\nSu promedio es: {calificacion.Promedio.ToString().Substring(0,3)} por lo tanto es: {calificacion.Mensajes()}");
                Console.WriteLine("\nDeseas calcular otro promedio Si/No?\n");
                op = Console.ReadLine();
            } while (op.Equals("Si") || op.Equals("si"));
        }
    }
}
