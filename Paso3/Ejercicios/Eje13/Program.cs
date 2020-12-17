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
 * Ejercicio 13:
 * Diseñe una solución básica con POO que permita resolver: 
 * si un número es par o impar y obtener su valor al cuadrado y al cubo.
 */
namespace Eje13
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacion operacion = new Operacion();
            String opcion="";
            Console.WriteLine("  ----------------------------------------------------------------------------------");
            Console.WriteLine("  Ingresa un número. Calcularemos si es par o impar, su valor al cuadrado y al cubo");
            Console.WriteLine("  ----------------------------------------------------------------------------------");
            do
            {
                Console.WriteLine("\nIntroduce un número: ");
                operacion.numero = Double.Parse(Console.ReadLine());
                operacion.determinaParImpar();
                Console.WriteLine($"Valor al cuadrado: {operacion.numero}²= {operacion.calculaCuadrado()}");
                Console.WriteLine($"Valor al cubo: {operacion.numero}³ = {operacion.calculaCubo()}");
                Console.WriteLine("\nDeseas comprobar otro numero? Si / No\n");
                opcion = Console.ReadLine();
            } while (opcion.Equals("Si") || opcion.Equals("si"));
        }
    }
}
