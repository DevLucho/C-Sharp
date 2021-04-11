using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPeliculas
{
    public class Pelicula
    {
        public static List<Pelicula> peliculas = new List<Pelicula>();
        int identificador;
        string nombre;
        string genero;
        double precio;
        int disponibilidad;
        string anotaciones;
        DateTime fechaAlquiler;
        DateTime fechaDevolucion;

        public Pelicula(int identificador, string nombre, string genero, double precio, int disponibilidad)
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.genero = genero;
            this.precio = precio;
            this.disponibilidad = disponibilidad;
            this.anotaciones = "";
        }

        public static int alquilar ( int cantidad, int identificador, Usuario usuario )
        {
            foreach (var pelicula in peliculas)
            {
                if ( pelicula.Identificador == identificador )
                {
                    if (pelicula.Disponibilidad >= 0)
                    {
                        if (cantidad > 0 && cantidad <= pelicula.Disponibilidad)
                        {
                            pelicula.Disponibilidad = pelicula.Disponibilidad - cantidad;
                            MessageBox.Show($"Has alquilado exitosamente {cantidad} pelicula(s) de {pelicula.Nombre}");
                            usuario.PeliculasAlquiladas.Add(pelicula);
                            return pelicula.Disponibilidad;
                        }
                        else
                        {
                            MessageBox.Show($"No se permiten valores negativos, ceros, ni valores mayores a la disponibilidad. \nHay disponibles {pelicula.Disponibilidad} peliculas");
                            return pelicula.Disponibilidad;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay disponibilidad");
                        return 0;
                    }
                }
            }
            return 0;
        }

        public int Identificador { get => identificador; set => identificador = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Genero { get => genero; set => genero = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
        public DateTime FechaAlquiler { get => fechaAlquiler; set => fechaAlquiler = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public string Anotaciones { get => anotaciones; set => anotaciones = value; }
    }
}
