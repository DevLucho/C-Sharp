using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Eje4
{
    class Suma
    {
        private int numero { get; set; } // Almacena un numero digitado
        private int resultado { get; set; } // Almacena el resultado de la suma
        private int[] numeros = new int[15]; // Almacena todos los numeros digitados
        private int contador = 1; // Contador para conocer la posicion del array en el bucle foreach
        public Suma()
        {
            this.numero = 0;
            this.resultado = 0;
        }
        public void operacion()
        {
            for (int i = 0; i < 15; i++) // Repite el codigo dentro de for 15 veces
            {
                Console.WriteLine($"\nIngresa el digito #{i + 1}");
                // try - catch en caso de no ingresar numeros enteros
                try
                {
                    // Bucle do - while, repite el codigo hasta que el numero digitado se encuentre entre 51 - 499
                    do
                    {
                        this.numero = Int32.Parse(Console.ReadLine());
                        this.validar(this.numero); // Valida el numero para mostrar un mensaje un mensaje de error.
                    } while (this.numero < 51 || this.numero > 499);
                    this.numeros[i] = this.numero; // Agrega el numero al array de numeros
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            this.sumar(); // Suma todos los numeros del array
            this.mostrarResultado(); // Muestra el total de la suma
            Console.ReadKey();
        }
        // Suma los numeros a la variable resultado
        public void sumar()
        {
            this.resultado = this.numeros.Sum();
        }
        // Imprime los numeros digitados y el total de la suma
        public void mostrarResultado()
        {
            Console.WriteLine("\n\nA contiuación los números digitados y el total de su suma:\n");
            foreach (int i in this.numeros) // Recorre el array de los numeros digitados
            {
                if (this.contador == this.numeros.Length) // Si es la ultima posicion del array
                {
                    Console.Write(i + $" = {this.resultado}");
                }
                else // Si no es la ultima posicion del array 
                {
                    Console.Write(i + "+");
                }
                this.contador++;
            }
        }
        // Valida para mostrar un mensaje de retroalimentacion
        public void validar(int numero)
        {
            if (numero <= 50 || numero >= 500)
            {
                Console.WriteLine("ATENCIÓN: Ingresa un número entero mayor a 50 y menor a 500");
            }
        }
    }
}
