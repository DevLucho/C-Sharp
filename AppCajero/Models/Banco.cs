using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Banco
    {
        public static List<Cuenta> cuentas = new List<Cuenta>();

        public static double retiroDiario = 2000000;

        public static void agregar(Cuenta cuenta)
        {
            cuentas.Add(cuenta);
        }
    }
}
