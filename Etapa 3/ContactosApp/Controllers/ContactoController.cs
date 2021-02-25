using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public class ContactoController
    {
        public static List<ClsContacto> contactos = new List<ClsContacto>();

        // Validar si esta almacenado el telefono
        static public bool ExisteTelefono(string telefono)
        {
            foreach (var item in contactos)
            {
                if (item.Telefono.Equals(telefono))
                    return true;
            }
            return false;
        }

        static public string AñadirContacto(ClsContacto contacto)
        {
            if (!ExisteTelefono(contacto.Telefono))
            {
                contactos.Add(contacto);
                return "✔ Nuevo contacto agregado.";
            }
            else
            {
                return $"✖️ El telefono {contacto.Telefono} ya esta registrado.";
            }
        }

        static public string EliminarContacto(int i)
        {
            contactos.RemoveAt(i);
            return "✔ Contacto eliminado.";
        }

        static public ClsContacto BuscarContacto(string telefono)
        {
            foreach (var item in contactos)
            {
                if (item.Telefono.Equals(telefono))
                    return item;
            }
            return null;
        }
    }
}
