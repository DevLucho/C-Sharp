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
 * Ejercicio 22 - Paso 3
 * Diseñe una solución básica con POO que permita resolver: 
 * de un listado de 10 números enteros negativos ingresados por teclado, 
 * se requiere la potencia a la 5 de cada uno de ellos.
 *
 */
namespace Eje22
{
    class Program
    {
        static void Main(string[] args)
        {
            Potencia potencia = new Potencia();
            potencia.pedirNumeros();
            potencia.MostrarPotencia();
            Console.ReadKey();
        }
    }
}
