using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje14
{
    class Operacion
    {
        public double num1{get; set;}
        public double num2{get; set;}
        public double suma{get; set;}
        public double vAbsoluto{get; set;}
        public double vCuadrado{get; set;}

        public Operacion()
        {
            this.num1 = 0.0;
            this.num2 = 0.0;
            this.vAbsoluto = 0.0;
        }
        public double sumar()
        {
            this.suma = (this.num1 + this.num2);
            return this.suma;
        }
        public double calcularValor()
        {
            if (this.sumar() > 0)
            {
                Console.Write($"\nLa suma es positiva por lo tanto {this.sumar()}² = ");
                this.vCuadrado = Math.Pow(this.sumar(), 2);
                return this.vCuadrado;
            }
            else if (this.sumar() < 0)
            {
                Console.Write($"\nLa suma es negativa por la tanto |{this.sumar()}| = ");
                this.vAbsoluto = Math.Abs(this.sumar());
                return this.vAbsoluto;
            }
            else {
                Console.Write("\nEl valor es }");
                return this.sumar();
            }
        }
    }
}
