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
 * Ejercicio 4:
 * Diseñe una solución básica con POO que permita resolver: 
 * la suma de 15 números enteros superiores a 50 e inferiores a 500. 
 */
namespace Eje4
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma suma = new Suma();
            Console.WriteLine("  ------------------ Sumar 15 digitós enteros -------------------");
            Console.WriteLine("  --------------------------------------------------------------");
            Console.WriteLine("  Ingresa números 15 enteros superiores a 50 e inferiores a 500.");
            Console.WriteLine("  --------------------------------------------------------------");
            suma.operacion();
        }
    }
}
