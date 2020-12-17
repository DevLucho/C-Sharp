using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Telas
    {
        private int cantidad; // Almacena cantidad de comprada de telas
        private double pIncremento; // Almacena el incremento de cada tela
        private double pAlgodon; // Almacena valor de la tela Algodon 
        private double pLino; // Almacena valor de la tela Lino
        private double pFranela; // Almacena valor de la tela Franela
        private double pCrepe; // Almacena valor de la tela Crepe
        private double pTotal; // Almacena el total de la inversion a realizar

        // Inicializa precio por defecto de telas
        public Telas()
        {
            this.pAlgodon = 5000;
            this.pLino = 4000;
            this.pFranela = 6000;
            this.pCrepe = 8000;
        }
        public void calcularPrecio(string tela, int cantidad)
        {
            this.incrementarTela(tela); // Llama al metodo que aumenta el precio de la tela teniendo en cuenta el incremento
            this.cantidad = cantidad; // Almacena la cantidad comprada en la variable cantidad
            
            // Suma al precio total cada tela comprada
            switch (tela)
            {
                case "Algodón":
                    this.pTotal += this.pAlgodon * this.cantidad;
                    break;
                case "Lino":
                    this.pTotal += this.pLino * this.cantidad;
                    break;
                case "Franela":
                    this.pTotal += this.pFranela * this.cantidad;
                    break;
                case "Crepé":
                    this.pTotal += this.pCrepe * this.cantidad;
                    break;
                default:
                    Console.WriteLine("Tela no existe");
                    break;
            }

        }
        public void incrementarTela(string tela)
        {
            // Aumenta el valor de la tela teniendo en cuenta el incremento
            switch (tela)
            {
                case "Algodón":
                    this.pIncremento = 0.10;
                    this.pAlgodon = (this.pAlgodon * pIncremento) + this.pAlgodon;
                    break;
                case "Lino":
                    this.pIncremento = 0.15;
                    this.pLino = (this.pLino * pIncremento) + this.pLino;
                    break;
                case "Franela":
                    this.pIncremento = 0.20;
                    this.pFranela = (this.pFranela * pIncremento) + this.pFranela;
                    break;
                case "Crepé":
                    this.pIncremento = 0.15;
                    this.pCrepe = (this.pCrepe * pIncremento) + this.pCrepe;
                    break;
                default:
                    Console.WriteLine("Tela no existe");
                    break;
            }
        }

        // Formato a precios
        public string darFormato(double precio)
        {
            return precio.ToString("N", CultureInfo.CreateSpecificCulture("es-ES"));
        }

        // Metodos get y set ⬇️⬇️

        public int getCantidad()
        {
            return this.cantidad;
        }

        public double getIncremento()
        {
            return this.pIncremento * 100;
        }

        public double getPAlgodon()
        {
            return this.pAlgodon;
        }

        public double getPLino()
        {
            return this.pLino;
        }

        public double getPFranela()
        {
            return this.pFranela;
        }

        public double getPCrepe()
        {
            return this.pCrepe;
        }

        public double getPTotal()
        {
            return this.pTotal;
        }
    }
}
