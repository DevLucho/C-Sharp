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
 * Ejercicio 11:
 * Desarrolle una solución básica de programación que al ingresar el 
 * número de total créditos académicos de un determinado programa
 * de ingeniería, calcule el porcentaje de créditos aprobados de un
 * estudiante e indique según las siguientes condiciones:
 * • Si el porcentaje obtenido es >=75% mostrar con las opciones de grado para ello
 * • Si el porcentaje es >=90% y =<100% mostrar con las opciones de grado del 75% y 90%
 * • Si el promedio es <75% indicar que aún no puede optar por una opción de grado
 * 
 */
namespace Eje11
{
    class Program
    {
        static void Main(string[] args)
        {
            OpcionGrado opcionGrado = new OpcionGrado();
            Console.WriteLine("====== Calcular porcentaje de creditos aprobados. ======");
            opcionGrado.MostrarCarreras();
            opcionGrado.PedirDatos();
            opcionGrado.CalcularPorcentaje(opcionGrado.NumCreditos, opcionGrado.OpCarrera);
            opcionGrado.MostrarOpciones();
            Console.ReadKey();
        }
    }
}
