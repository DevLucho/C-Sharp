using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cliente
    {
        string nombre;
        int nroDocumento;
        string contrasenia;

        public Cliente(string nombre, int nroDocumento, string contrasenia)
        {
            this.nombre = nombre;
            this.nroDocumento = nroDocumento;
            this.contrasenia = contrasenia;
        }

        public static Cuenta login(int nroDocumento, string contrasenia)
        {
            foreach (var cuenta in Banco.cuentas)
            {
                if (cuenta.Cliente.NroDocumento == nroDocumento && cuenta.Cliente.Contrasenia == contrasenia)
                {
                    return cuenta;
                }
            }
            return null;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int NroDocumento { get => nroDocumento; set => nroDocumento = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
    }
}
