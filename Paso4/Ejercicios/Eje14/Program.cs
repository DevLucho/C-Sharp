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
 * Ejercicio 14
 * Desarrollar una solución básica de programación 
 * que a través del uso de método se calcule el IMC de una
 * persona y que con base en el resultado obtenido se clasifique a esa persona
 * 
 */
namespace Eje14
{
    class Program
    {
        static void Main(string[] args)
        {
            MasaCorporal masaCorporal = new MasaCorporal();
            Console.WriteLine("========= Calcular IMC =========");
            masaCorporal.PedirDatos();
            masaCorporal.CalcularImc();
            masaCorporal.Clasificar();
            Console.WriteLine($"\nSu IMC es: {masaCorporal.Imc} por lo tanto su composición corporal es: {masaCorporal.ComposicionCorporal}");
            Console.ReadKey();
        }
    }
}
