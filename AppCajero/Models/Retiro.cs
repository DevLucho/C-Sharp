using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Retiro
    {
        DateTime fecha;
        double valorRetirado;
        double retirosDiarios;

        public Retiro()
        {

        }

        public Retiro(DateTime fecha, double valorRetirado)
        {
            this.fecha = fecha;
            this.valorRetirado = valorRetirado;
        }

        public bool topeMaximoRetiro(List<Retiro> retiros, double cantidad)
        {
            foreach (var retiro in retiros)
            {
                if (DateTime.Now.Date == retiro.Fecha.Date)
                {
                    retirosDiarios += retiro.ValorRetirado;
                }
            }
            retirosDiarios += cantidad;
            if (retirosDiarios > Banco.retiroDiario)
            {
                return false;
            }
            retirosDiarios -= cantidad;
            return true;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double ValorRetirado { get => valorRetirado; set => valorRetirado = value; }
        public double RetirosDiarios { get => retirosDiarios; set => retirosDiarios = value; }
    }
}
