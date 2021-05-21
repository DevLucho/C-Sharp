using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;

namespace Models
{
    public class Cuenta
    {
        List<Retiro> retiros = new List<Retiro>();
        Cliente cliente;
        double saldo;
        BigInteger numCuenta;
        int clave;
        int puntos;

        public Cuenta(Cliente cliente, double saldo, BigInteger numCuenta, int clave, int puntos)
        {
            this.cliente = cliente;
            this.saldo = saldo;
            this.numCuenta = numCuenta;
            this.clave = clave;
            this.puntos = puntos;
        }

        public string retirarSaldo(double cantidad)
        {
            if (cantidad > 0)
            {
                if (cantidad > this.saldo)
                    return "Fondos insuficientes";
                else
                {
                    if (cantidad > 600000)
                        return "Atención. La cantidad maxima por retiro son $600.000";
                    else
                    {
                        Retiro retiroAux = new Retiro();
                        if (retiroAux.topeMaximoRetiro(retiros, cantidad))
                        {
                            this.saldo -= cantidad;
                            Retiro retiro = new Retiro(DateTime.Now, cantidad);
                            retiros.Add(retiro);
                            return $"Retiro existoso de $ {darFormato(cantidad)} pesos.";
                        }
                        else
                            return $"Atención. Ya superaste el tope diario de retiros. ({darFormato(Banco.retiroDiario)})";
                    }
                }
            }
            else
                return "No se permiten valores negativos.";
        }

        public string consultarSaldo()
        {
            return $"$ {darFormato(this.saldo)}";
        }

        public string canjearPuntos(int puntos)
        {
            if (puntos <= this.puntos)
            {
                if (puntos % 10 == 0)
                {
                    this.puntos -= puntos;
                    this.saldo += puntos / 10;
                    return $"Se descontaron {puntos}pts. Por lo tanto se canjearón {puntos / 10} pesos.";
                }
                else
                    return "No se canjearon los puntos. Fijese que la cantidad sea multiplo de 10.";
            }
            else
                return "Puntos insuficientes.";
        }

        public bool transferir(BigInteger numCuenta, double cantidad)
        {
            bool valid = false;
            foreach (var cuenta in Banco.cuentas)
            {
                if (cuenta.numCuenta == numCuenta)
                {
                    this.saldo -= cantidad;
                    cuenta.Saldo += cantidad;
                    valid = true;
                }
            }
            return valid;
        }

        public string darFormato(double precio)
        {
            return precio.ToString("N", CultureInfo.CreateSpecificCulture("es-ES"));
        }

        public Cliente Cliente { get => cliente; set => cliente = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public BigInteger NumCuenta { get => numCuenta; set => numCuenta = value; }
        public int Clave { get => clave; set => clave = value; }
        public int Puntos { get => puntos; set => puntos = value; }

    }
}
