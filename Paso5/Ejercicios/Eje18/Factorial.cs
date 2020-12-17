using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Eje18
{
    class Factorial
    {
        BigInteger factorial;

        public void CalcularFactorial(int num)
        {
            this.factorial = 1;
            for (int i = num; i >= 1; this.factorial *= i--) ;
        }

        public void MostrarFactorial()
        {
            Console.WriteLine("======== Factorial de los primeros 50 números enteros positivos ========\n");
            for (int i = 0; i < 50; i++)
            {
                CalcularFactorial(i + 1);
                Console.WriteLine($"{i + 1}! = {this.factorial}");
            }
        }

    }
}
