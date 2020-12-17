using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje13
{
    class Operacion
    {
        public double numero { get; set; }
        public double v_cubo { get; set; }
        public double v_cuadrado { get; set; }

        public Operacion()
        {
            this.numero = 0.0;
            this.v_cubo = 0.0;
            this.v_cuadrado = 0.0;
        }
        public void determinaParImpar() 
        {
            if ((this.numero % 2) == 0)
            {
                Console.WriteLine("{0} Es par", this.numero);
            }
            else { 
                Console.WriteLine("{0} Es impar", this.numero);
            }
        }
        public double calculaCuadrado()
        {
            this.v_cuadrado = Math.Pow(this.numero, 2);
            return this.v_cuadrado;
        }
        public double calculaCubo()
        {
            this.v_cubo = Math.Pow(this.numero, 3);
            return this.v_cubo;
        }
    }
}
