using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosUnad
{
    class Tienda
    {
        private const double DESC = 0.15; // Descuento 15%
        private double descuento; // Almacena el precio total descuentado
        private double precioCompra; // Almacena el precio inicial
        private double precioFinal; // Almacena el total a pagar

        // Modifica la variable precioCompra
        public void setPrecioCompra(double precioCompra) => this.precioCompra = precioCompra;
        // Retorna la variable precioCompra
        public double getPrecioCompra()
        {
            return this.precioCompra;
        }
        // Retorna el valor del descuento
        public double getDesc() 
        {
            return DESC*100;
        }
        // Retorna el precio a pagar teniendo en cuenta el descuento
        public double getPrecioFinal()
        {
            return this.precioFinal = this.precioCompra - this.descuento;
        }
        // Calcula descuento
        public double calculaDescuento(double precioCompra)
        {
            return this.descuento = precioCompra * DESC;
        }
        // Formato para los precios
        public string darFormato(double precio)
        {
            return precio.ToString("N", CultureInfo.CreateSpecificCulture("es-ES"));
        }
    }
}
