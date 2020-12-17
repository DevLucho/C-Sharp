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
 * Ejercicio 18 - Paso 3
 * Diseñe una solución básica con POO que permita resolver: 
 * Del listado de 50 primeros números enteros positivos 
 * se requiere conocer la factorial de cada uno de ellos.
 * 
 */
namespace Eje18
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();
            factorial.MostrarFactorial();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
