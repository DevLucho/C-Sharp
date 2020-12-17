using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Nombre estudiante: Luis David Huertas Redondo
 * Grupo 17
 * Programa: Ingenieria de Sistemas
 * Codigo fuente: Autoria propia
 * 
 * Ejercicio 3 
 * Una tienda de venta de celulares: se ofrece un descuento del 15% 
 * sobre el total de la compra y un cliente desea saber cuánto deberá
 * pagar finalmente por su compra.
*/

namespace EjerciciosUnad
{
    class Ejecucion
    {
        static void Main(string[] args)
        {
            Tienda t = new Tienda();
            try
            {
                Console.WriteLine("Estimado cliente ingrese el valor total de su compra:");
                t.setPrecioCompra(double.Parse(Console.ReadLine()));
                Console.WriteLine("\n----------------------------------------------------\n                  Detalle compra \n----------------------------------------------------\n");
                Console.WriteLine($"El precio de compra sin descuento es: ${t.darFormato(t.getPrecioCompra())} COP");
                Console.WriteLine($"Se descuenta el {t.getDesc()}% que corresponde a: ${t.darFormato(t.calculaDescuento(t.getPrecioCompra()))} COP");
                Console.WriteLine($"Por lo tanto el total a pagar es: ${t.darFormato(t.getPrecioFinal())} COP");
                Console.WriteLine("\n----------------------------------------------------\n");
                Console.ReadKey();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.ReadKey();
            }

        }
    }
}
