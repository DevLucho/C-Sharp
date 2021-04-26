using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MetodosOrdenamiento
{
    /*
     * Autor: Luis David Huertas Redondo.
     */
    class Program
    {

        static void Main(string[] args)
        {
            string metodoUsado = "";
            int op = 0;
            int[] numeros = new int[10];

            Console.WriteLine("Digite 10 numeros.");
            for (int i = 0; i < 10; i++)
            {
                bool error;
                do
                {
                    error = false;
                    try
                    {
                        Console.WriteLine($"Digite el numero {i + 1}");
                        numeros[i] = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        error = true;
                        Console.WriteLine(ex.Message + ". Digita solo números enteros.");
                    }
                } while (error);
            }

            string ordenOriginal = String.Join(", ", numeros);

            Console.WriteLine("\nDigite el número (1-4) del metodo de ordenamiento a usar:");
            Console.WriteLine("1. Metodo Burbuja\n2. Metodo Shell\n3. Metodo de Inserción\n4. Metodo de Selección");
            do
            {
                bool error;
                do
                {
                    error = false;
                    try
                    {
                        op = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        error = true;
                        Console.WriteLine(ex.Message + ". Digita solo números enteros ( 1-4 ).");
                    }
                } while (error);

                if (op == 1)
                    metodoUsado = Metodos.MetodoBurbuja(numeros);
                else if (op == 2)
                    metodoUsado = Metodos.MetodoShell(numeros);
                else if (op == 3)
                    metodoUsado = Metodos.MetodoInsercion(numeros);
                else if (op == 4)
                    metodoUsado = Metodos.MetodoSeleccion(numeros);
                else
                    Console.WriteLine("Atención. Digite uno de los números especificados en el menú entre 1-4");

            } while (op < 1 || op > 4);

            string ordenModificado = String.Join(", ", numeros);

            Console.WriteLine("\n" + Metodos.GenerarTxt(ordenOriginal, ordenModificado, metodoUsado));

            Console.ReadKey();
        }
    }
}
