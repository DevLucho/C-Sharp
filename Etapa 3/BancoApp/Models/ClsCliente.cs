using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ClsCliente
    {
        string titular;
        int nroDocumento;
        string contrasenia;
        ClsCuenta cuenta;

        public ClsCliente(string titular, int nroDocumento, string contrasenia)
        {
            this.Titular = titular;
            this.NroDocumento = nroDocumento;
            this.Contrasenia = contrasenia;
        }

        public ClsCliente(string titular, int nroDocumento, string contrasenia, ClsCuenta cuenta)
        {
            this.Titular = titular;
            this.NroDocumento = nroDocumento;
            this.Contrasenia = contrasenia;
            this.Cuenta = cuenta;
        }

        public string Titular { get => titular; set => titular = value; }
        public int NroDocumento { get => nroDocumento; set => nroDocumento = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public ClsCuenta Cuenta { get => cuenta; set => cuenta = value; }
    }
}
