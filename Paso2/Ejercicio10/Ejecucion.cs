using Ejercicio10;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosUnad
{
    /* 
     * Nombre estudiante: Luis David Huertas Redondo
     * Grupo 17
     * Programa: Ingenieria de Sistemas
     * Codigo fuente: Autoria propia
     * 
     * Ejercicio 10
     * La empresa de confecciones Coltejer: necesita calcular el valor total de la inversión a realizar, 
     * teniendo en cuenta que las telas tuvieron un incremento en su precio así:
     * Algodón: 10%
     * Lino: 15%
     * Franela: 20%
     * Crepé: 15%
     * La compra realizada presenta el siguiente detalle:
     * • Algodón: 5000 – Cantidad comprada: 5
     * • Lino: 4000 – Cantidad comprada: 4
     * • Franela: 6000 – Cantidad comprada: 5
     * • Crepé: 8000 – Cantidad comprada: 4
     */
    class Ejecucion
    {
        static void Main(string[] args)
        {
            Telas e = new Telas();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------\n\n                                              Empresa de confecciones Coltejer\n\n--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n La inversión a realizar presenta el siguiente detalle:");
            // Tela algodon
            Console.Write($"\n Precio tela Algodón sin aumento: ${e.darFormato(e.getPAlgodon())}");
            e.calcularPrecio("Algodón", 5);
            Console.Write($" | Precio final con aumento del {e.getIncremento()}%: ${e.darFormato(e.getPAlgodon())}");
            Console.Write($" | Cantidad comprada {e.getCantidad()}");
            // Tela lino
            Console.Write($"\n Precio tela Lino sin aumento: ${e.darFormato(e.getPLino())}");
            e.calcularPrecio("Lino", 4);
            Console.Write($" | Precio final con aumento del {e.getIncremento()}%: ${e.darFormato(e.getPLino())}");
            Console.Write($" | Cantidad comprada {e.getCantidad()}");
            // Tela franela
            Console.Write($"\n Precio tela Franela sin aumento: ${e.darFormato(e.getPFranela())}");
            e.calcularPrecio("Franela", 5);
            Console.Write($" | Precio final con aumento del {e.getIncremento()}%: ${e.darFormato(e.getPFranela())}");
            Console.Write($" | Cantidad comprada {e.getCantidad()}");
            // Tela crepe
            Console.Write($"\n Precio tela Crepé sin aumento: ${e.darFormato(e.getPCrepe())}");
            e.calcularPrecio("Crepé", 4);
            Console.Write($" |Precio final con aumento del {e.getIncremento()}%: ${e.darFormato(e.getPCrepe())}");
            Console.Write($" | Cantidad comprada {e.getCantidad()}\n");
            // Total
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine($" El precio total a invertir es: ${e.darFormato(e.getPTotal())}");
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------\n");

            Console.ReadKey();
        }
    }
}
