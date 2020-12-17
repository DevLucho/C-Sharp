using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje3
{
    public class OficinaSeguro
    {
        int anioNacimiento;
        string sexo;
        string registroCarro;

        public OficinaSeguro()
        {
        }

        public OficinaSeguro(int anioNacimiento, string sexo, string registroCarro)
        {
            this.AnioNacimiento = anioNacimiento;
            this.Sexo = sexo;
            this.RegistroCarro = registroCarro;
        }

        public int AnioNacimiento { get => anioNacimiento; set => anioNacimiento = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string RegistroCarro { get => registroCarro; set => registroCarro = value; }

    }
}
