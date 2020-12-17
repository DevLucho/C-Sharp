using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje22
{
    class Potencia
    {
        int numero;
        int[] numeros;

        public Potencia()
        {
            this.numeros = new int[10];
        }

        public void pedirNumeros()
        {
            for (int i = 0; i < 10; i++)
            {
                bool error; // validar formato correcto de numero
                Console.WriteLine($"Ingresa el num #{i + 1}");
                do
                {
                    error = false;
                    try
                    {
                        this.numero = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        error = true;
                        Console.Write(ex.Message);
                    }
                    if (this.numero >= 0 || error) Console.WriteLine(" Solo se permiten números enteros negativos");
                } while (Validar(this.numero) || error);
                this.numeros[i] = this.numero;
            }
        }

        public bool Validar(int num)
        {
            bool error = true;
            if (num < 0) error = false;
            return error;
        }

        public double CalcularPotencia(int num)
        {
            return Math.Pow(num, 5);
        }

        public void MostrarPotencia()
        {
            for (int i = 0; i < this.numeros.Length; i++)
            {
                Console.WriteLine($"Entero #{i + 1} digitado: {this.numeros[i]} - potencia a la 5 es: {CalcularPotencia(this.numeros[i])}");
            }
        }

    }
}
