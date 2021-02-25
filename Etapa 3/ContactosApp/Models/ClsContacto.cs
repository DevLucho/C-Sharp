using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ClsContacto
    {
        string nombres;
        string apellidos;
        string telefono;
        string organizacion;

        public ClsContacto(string nombres, string apellidos, string telefono, string organizacion)
        {
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Telefono = telefono;
            this.Organizacion = organizacion;
        }

        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Organizacion { get => organizacion; set => organizacion = value; }
    }
}
