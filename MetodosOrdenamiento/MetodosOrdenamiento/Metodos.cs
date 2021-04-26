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
    public class Metodos
    {

        static public string MetodoBurbuja(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        int num = numeros[i]; // num mayor
                        // intercambio
                        numeros[i] = numeros[j]; // num menor
                        numeros[j] = num; // num mayor
                    }
                }
            }
            return "Burbuja";
        }

        static public string MetodoShell(int[] numeros)
        {
            int salto, aux, i;
            bool cambios;
            for (salto = numeros.Length / 2; salto != 0; salto /= 2)
            {
                cambios = true;
                while (cambios)
                {   // Mientras se intercambie algún elemento                                         
                    cambios = false;
                    for (i = salto; i < numeros.Length; i++)   // se da una pasada
                    {
                        if (numeros[i - salto] > numeros[i]) // si están desordenados
                        {
                            aux = numeros[i]; // se reordenan
                            numeros[i] = numeros[i - salto];
                            numeros[i - salto] = aux;
                            cambios = true;// se marca como cambio.                                   
                        }
                    }
                }
            }
            return "Shell";
        }

        static public string MetodoInsercion(int[] numeros)
        {
            int auxiliar;
            int j;
            for (int i = 0; i < numeros.Length; i++)
            {
                auxiliar = numeros[i];
                j = i - 1;
                while (j >= 0 && numeros[j] > auxiliar)
                {
                    numeros[j + 1] = numeros[j];
                    j--;
                }
                numeros[j + 1] = auxiliar;
            }
            return "Inserción Directa";
        }

        static public string MetodoSeleccion(int[] numeros)
        {
            int min; // numero menor
            int aux; // numero auxiliar

            for (int i = 0; i < numeros.Length; i++)
            {
                min = i;
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[j] < numeros[min]) // si se encuentra un numero menor
                    {
                        min = j; // almacena la posicion
                    }
                }
                // intercambia entre posiciones 
                aux = numeros[i];
                numeros[i] = numeros[min];
                numeros[min] = aux;
            }
            return "Selección";
        }

        static public string GenerarTxt(string ordenOriginal, string ordenModificado, string metodoUsado)
        {
            var directorioActual = Directory.GetCurrentDirectory(); // obtener directorio del proyecto
            var arr = directorioActual.Split('\\'); // separar por '\'
            string ruta = $@"{arr[0]}\{arr[1]}\{arr[2]}\Desktop\NumerosOrdenados.txt"; // ruta a guardar el archivo

            using (StreamWriter sw = File.CreateText(ruta))
            {
                sw.WriteLine("Números en el orden digitado:");
                sw.WriteLine(ordenOriginal);
                sw.WriteLine($"Números ordenados por el metodo de ordenamiento: {metodoUsado}");
                sw.WriteLine(ordenModificado);
            }

            return "REVISA TU ESCRITORIO. Se genero con exito el archivo: NumerosOrdenados.txt con los números ordenados.";
        }
    }
}
