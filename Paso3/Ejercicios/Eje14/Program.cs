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
 * Ejercicio 14:
 * Diseñe una solución básica con POO que permita resolver: 
 * si la suma de dos valores es positiva, negativa o cero. Si es positiva, calcular 
 * el cuadrado de la suma, pero si es negativo calcular su valor absoluto.
 */
namespace Eje14
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacion operacion = new Operacion();
            String opcion = "";
            Console.WriteLine("  ------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("  Ingresa dos numeros. Si la suma de estos es negativa obtendras su v. absoluto y si es positivo su valor al cuadrado");
            Console.WriteLine("  ------------------------------------------------------------------------------------------------------------------");
            do
            {
                try
                {
                    Console.WriteLine("\nIngresa primer número: ");
                    operacion.num1 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa segundo número: ");
                    operacion.num2 = Double.Parse(Console.ReadLine());
                    Console.WriteLine($"\nLa suma de {operacion.num1}+{operacion.num2} = {operacion.sumar()}");
                    Console.WriteLine(operacion.calcularValor());
                    Console.WriteLine("\nDeseas comprobar otra suma? Si / No\n");
                    opcion = Console.ReadLine();
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
               
            } while (opcion.Equals("Si") || opcion.Equals("si"));
        }
    }
}
