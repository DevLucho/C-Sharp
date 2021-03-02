using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public class ClienteController
    {
        public static List<ClsCliente> clientes = new List<ClsCliente>();

        public static string CrearCliente(string titular, int nroDocumento, string contrasenia)
        {
            ClsCuenta cuenta = new ClsCuenta();
            ClsCliente cliente = new ClsCliente(titular, nroDocumento, contrasenia, cuenta);
            clientes.Add(cliente);
            return "Cuenta creada satisfactoriamente";
        }

        public static ClsCliente Login (int nroDocumento, string contrasenia)
        {
            foreach (var cliente in clientes)
            {
                if ( cliente.NroDocumento == nroDocumento && cliente.Contrasenia == contrasenia)
                {
                    return cliente;
                }
            }
            return null;
        }
    }
}
