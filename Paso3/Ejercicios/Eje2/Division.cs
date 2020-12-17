using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje2
{
    class Division
    {
        private int dividendo { get; set; }
        private int divisor { get; set; }
        private int residuo { get; set; }
        private int cociente { get; set; }
        public Division()
        {
            this.dividendo = 0;
            this.divisor = 0;
            this.residuo = 0;
            this.cociente = 0;
        }

        public void operacion() 
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(" -------------------------");
                Console.WriteLine($"|       Operacion #{i + 1}      |");
                Console.WriteLine(" -------------------------\n");
                Console.WriteLine("   Ingresa el dividendo:");
                this.dividendo = Int32.Parse(Console.ReadLine());
                Console.WriteLine("   Ingresa el divisor:");
                this.divisor = Int32.Parse(Console.ReadLine());
                try
                {
                    Console.WriteLine($"\n Dividir ->   {this.dividendo} |___{this.divisor}___");
                    Console.WriteLine($"\nEl residuo es: {this.calcularResiduo()} \nEl cociente es: {this.calcularCociente()}\n");
                } catch (DivideByZeroException e)
                {
                    Console.WriteLine("\n Syntax ERROR: "+e.Message+"\n");
                }
            }
        }

        public int calcularResiduo()
        {
            this.residuo = (this.dividendo % this.divisor);
            return this.residuo;
        }
        public int calcularCociente()
        {
            this.cociente = (this.dividendo / this.divisor);
            return this.cociente;
        }
    }
}
