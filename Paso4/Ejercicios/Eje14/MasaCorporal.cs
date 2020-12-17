using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje14
{
    class MasaCorporal
    {
        double estatura;
        double peso;
        double imc;
        string composicionCorporal;

        public void PedirDatos()
        {
            Console.WriteLine("\nDigite peso en kg:");
            bool error; // validacion para que cuando se capture una excepcion no se frene la aplicacion
            do
            {
                error = false;
                try
                {
                    Peso = double.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    error = true;
                    Console.WriteLine(ex.Message + " Peso incorrecto.");
                }
            } while (error);

            Console.WriteLine("Digite estatura en metros:");
            do
            {
                error = false;
                try
                {
                    Estatura = double.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    error = true;
                    Console.WriteLine(ex.Message + " Estatura incorrecta");
                }
            } while (error);

        }

        public void CalcularImc()
        {
            this.Imc = (this.Peso / (Math.Pow(this.Estatura, 2)));
            this.Imc = Math.Round(this.Imc, 2);
        }

        public void Clasificar()
        {
            if (this.Imc < 18.5) this.ComposicionCorporal = "Peso inferior al normal";
            else if (this.Imc >= 18.5 && this.Imc <= 24.9) this.ComposicionCorporal = "Normal";
            else if (this.Imc >= 25.0 && this.Imc <= 29.9) this.ComposicionCorporal = "Peso superior al normal ";
            else this.ComposicionCorporal = "Obesidad";
        }

        public double Estatura { get => estatura; set => estatura = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Imc { get => imc; set => imc = value; }
        public string ComposicionCorporal { get => composicionCorporal; set => composicionCorporal = value; }

    }
}
