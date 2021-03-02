using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ClsCuenta
    {
        double cantidad;

        public ClsCuenta()
        {
            this.Cantidad = 0.0;
        }

        public ClsCuenta(double cantidad)
        {
            this.Cantidad = cantidad;
        }
        public double Cantidad { get => cantidad; set => cantidad = value; }
    }
}
