using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public class CuentaController
    {
        public static string RecargarCuenta(ClsCuenta cuenta, double cantidad)
        {
            if( cantidad > 0 )
            {
                cuenta.Cantidad += cantidad;
                return $"Se han recargado: $ {darFormato(cantidad)} pesos.";
            } else
            {
                return "No se permiten valores negativos.";
            }
        }

        public static string RetirarDinero (ClsCuenta cuenta, double cantidad)
        {
            if ( cantidad > 0)
            {
                if (cantidad > cuenta.Cantidad)
                {
                    return "Fondos insuficientes";
                }
                else
                {
                    cuenta.Cantidad -= cantidad;
                    return $"Retiro existoso de $ {darFormato(cantidad)} pesos.";
                }
            } else
            {
                return "No se permiten valores negativos.";
            }
        }

        public static string ConsultarSaldo (ClsCuenta cuenta) 
        {
            return $"$ {darFormato(cuenta.Cantidad)}";
        }

        public static string darFormato(double precio)
        {
            return precio.ToString("N", CultureInfo.CreateSpecificCulture("es-ES"));
        }

    }
}
