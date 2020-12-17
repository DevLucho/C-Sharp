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
 * Ejercicio 9:
 * Diseñe una solución básica con POO que permita resolver: 
 * que indique cuál es el mayor de cuatro números enteros. 
 * Al número mayor obtener su raíz cuadrada.
 */
namespace Eje9
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacion operacion = new Operacion();
            Console.WriteLine("  ----------------------------------------------------------------------------------");
            Console.WriteLine("  Ingresa 4 números enteros. Calcularemos la raíz cuadrada del número mayor");
            Console.WriteLine("  ----------------------------------------------------------------------------------");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"\nIngrese valor número {i + 1}:");
                try
                {
                    operacion.numeros[i] = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                };
            }
            operacion.calculaNumMayor();
            operacion.calculaRaizCuadrada(operacion.numMayor);
            Console.WriteLine($"\nEl numero mayor es: {operacion.numMayor}\nRaiz cuadrada de {operacion.numMayor} es: {operacion.raiz}");
            Console.ReadKey();
        }
    }
}
