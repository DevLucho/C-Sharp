using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje12
{
    class ParqueDiversion
    {
        double altura;
        double peso;
        int edad;
        string genero;

        public void PedirDatos()
        {
            Console.WriteLine("========== Parque de diversiones ==========\n");
            Console.WriteLine("Ingresa tu altura:");
            this.altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu peso:");
            this.peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu edad:");
            this.edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu genero (Masculino / Femenino) ");
            this.genero = Console.ReadLine();
        }

        public string DeterminaJuego(double altura, double peso, int edad, string genero)
        {
            if (genero.Equals("Masculino"))
            {
                if (altura == 1.40 && peso == 65) return "Licuadora";
                else if (altura == 1.80 && peso == 80) return "Montaña Rusa";
                else return "";
            }
            else if (genero.Equals("Femenino"))
            {
                if (altura == 1.20 && peso == 60) return "Carros Chocones";
                else if (altura == 1.60 && peso == 70) return "El pulpo";
                else return "";
            }
            else return "";
        }

        public double Altura { get => altura; set => altura = value; }
        public double Peso { get => peso; set => peso = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }
    }
}
