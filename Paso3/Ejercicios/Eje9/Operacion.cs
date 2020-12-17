using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje9
{
    class Operacion
    {
        public int[] numeros { get; set; }
        public double raiz { get; set; }
        public int numMayor { get; set; }

        public Operacion() 
        {
            this.numeros = new int[4];
            this.numMayor = 0;
            this.raiz = 0.0;
        }
        public void calculaNumMayor() 
        {
            this.numMayor = this.numeros.Max();
        }
        public void calculaRaizCuadrada(double num) 
        {
            this.raiz=Math.Sqrt(num);
        }

    }
}
