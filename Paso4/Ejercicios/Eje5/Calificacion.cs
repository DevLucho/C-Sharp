using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje5
{
    class Calificacion
    {
        double nota;
        double[] notas;
        double promedio;
        string mensaje;

        public Calificacion()
        {
            this.nota = 0.0;
            this.notas = new double[3];
            this.promedio = 0.0;
            this.mensaje = "";
        }

        public void pedirNotas()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingrese nota #{i + 1}");
                bool error; // validacion para que cuando se capture una excepcion no se frene la aplicacion
                do
                {
                    error = false;
                    if (ValidarNota(this.nota)) Console.WriteLine(this.mensaje);
                    try
                    {
                        this.nota = double.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message + " Valor no valido.");
                        error = true;
                    }
                } while (ValidarNota(this.nota) || error);
                this.notas[i] = this.nota; // agregar al array la nota
            }
        }
        
        public bool ValidarNota(double nota)
        {
            bool valida = true;
            if (nota >= 0 && nota <= 5) valida = false;
            else this.mensaje = "Valor no valido.";
            return valida;
        }

        public void CalcularPromedio()
        {
            this.promedio = ((this.notas.Sum()) / this.notas.Length);
        }

        public string Mensajes()
        {
            if (this.promedio >= 4.6) this.mensaje = "Excelente";
            else if (this.promedio >= 4.0 && this.promedio <= 4.5) this.mensaje = "Muy bueno";
            else if (this.promedio >= 3.5 && this.promedio <= 3.9) this.mensaje = "Bueno";
            else if (this.promedio >= 3.0 && this.promedio <= 3.4) this.mensaje = "Satisfactorio";
            else this.mensaje = "Deficiente";

            return this.mensaje;
        }
        // Mostrar notas agregadas en el array
        public void MostrarNotas()
        {
            Console.Write("\nSus notas son: ");
            for (int i = 0; i < this.notas.Length; i++)
            {
                Console.Write(this.notas[i] + "  ");
            }
        }

        public double Promedio { get => promedio; set => promedio = value; }
    }
}
