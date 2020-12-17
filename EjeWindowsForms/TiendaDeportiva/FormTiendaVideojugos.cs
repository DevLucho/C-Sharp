using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic;

namespace TiendaDeVideoJuegos
{
    public partial class FormTiendaVideojugos : Form
    {
        public FormTiendaVideojugos()
        {
            InitializeComponent();
        }
        public double presupuesto = 0;
        public int capacidad = 0;
        int indice = -1;
        double descuento = 0;
        double totalVenta = 0;
        string juegoAdecuado = "";
        string[,] juego =
        {
            { "NBA","DEPORTES","1024","400000","100"},
            { "CRASH","AVENTURA","820","280000","30"},
            { "CALL OF DUTY","ACCION","500","99000","140"},
            {"NEED FOR SPEED","VELOCIDAD","200","50000","66" }
        };
        int[] juegosV;

        private void FormTiendaVideojugos_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < juego.GetLength(0); i++)
            {
                comboJuego.Items.Add(juego[i, 0]);
            }
            juegosV = new int[juego.GetLength(0)];
            for (int i = 0; i < juegosV.Length; i++)
            {
                juegosV[i] = 0;

            }
        }

        private void comboJuego_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            indice = comboJuego.SelectedIndex;
            textNombre.Text = juego[indice, 0];
            textCategoria.Text = juego[indice, 1];
            textTamaño.Text = juego[indice, 2] + "kb";
            textPrecio.Text = "$ " + darFormato(double.Parse(juego[indice, 3]));
            textDisponibles.Text = juego[indice, 4];

            switch (indice)
            {
                case 0:
                    pictureImagen.Image = TiendaDeportiva.Properties.Resources.NBA;
                    break;
                case 1:
                    pictureImagen.Image = TiendaDeportiva.Properties.Resources.CRASH;
                    break;
                case 2:
                    pictureImagen.Image = TiendaDeportiva.Properties.Resources.CALL;
                    break;
                case 3:
                    pictureImagen.Image = TiendaDeportiva.Properties.Resources.NEDD;
                    break;
            }
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            try
            {
                int compra;
                compra = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad a comprar", "COMPRA", "0"));
                juego[indice, 4] = (int.Parse(juego[indice, 4]) + compra).ToString();
                textDisponibles.Text = juego[indice, 4];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void buttonVender_Click(object sender, EventArgs e)
        {
            try
            {
                int venta;
                venta = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("ingrese la cantidad a vender", "VENTA", "0"));
                if (int.Parse(juego[indice, 4]) >= venta)
                {
                    juego[indice, 4] = (int.Parse(juego[indice, 4]) - venta).ToString();
                    textDisponibles.Text = juego[indice, 4];
                    juegosV[indice] = juegosV[indice] + venta;
                    if (venta >= 25 && juego[indice, 1] == "ACCION")
                    {
                        descuento = 0.15;

                    }
                    if (descuento < 0.15 && (venta >= 32 && juego[indice, 0] == "MARIO") || (venta >= 12 && juego[indice, 1] == "DEPORTES") || (venta >= 15 && juego[indice, 1] == "CARRERAS"))
                    {
                        descuento = 0.10;
                    }
                    totalVenta += venta * double.Parse(juego[indice, 3]);
                }
                else
                {
                    MessageBox.Show("Agotado");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buttonJuegosVendidos_Click(object sender, EventArgs e)
        {
            int mayor = -1;
            int indiceMayor = 0;
            for (int i = 0; i < juegosV.Length; i++)
            {
                if (juegosV[i] > mayor)
                {
                    mayor = juegosV[i];
                    indiceMayor = i;
                }

            }
            MessageBox.Show("Juego mas vendido es " + juego[indiceMayor, 0]);
        }

        private void buttonBuscarJ_Click(object sender, EventArgs e)
        {
            FormBuqueda formularioB = new FormBuqueda();
            formularioB.ShowDialog();
        }

        public void showBuscarJ()
        {
            if (this.capacidad <= int.Parse(juego[3, 2]) && this.presupuesto <= double.Parse(juego[3, 3]))
            {
                this.juegoAdecuado = juego[3, 0];
                MessageBox.Show("El juego apropiado para usted es:\n" + this.juegoAdecuado);
            }
            else if (this.capacidad <= int.Parse(juego[2, 2]) && this.presupuesto <= double.Parse(juego[2, 3]))
            {
                this.juegoAdecuado = juego[2, 0];
                MessageBox.Show("El juego apropiado para usted es:\n" + this.juegoAdecuado);
            }
            else if (this.capacidad <= int.Parse(juego[1, 2]) && this.presupuesto <= double.Parse(juego[1, 3]))
            {
                this.juegoAdecuado = juego[1, 0];
                MessageBox.Show("El juego apropiado para usted es:\n" + this.juegoAdecuado);
            }
            else if (this.capacidad <= int.Parse(juego[0, 2]) && this.presupuesto <= double.Parse(juego[0, 3]))
            {
                this.juegoAdecuado = juego[0, 0];
                MessageBox.Show("El juego apropiado para usted es:\n" + this.juegoAdecuado);
            }
            else
            {
                MessageBox.Show($"Lo siento...\nNo encotramos un juego que se aproxime a los requisitos especificados\nPrecio: ${darFormato(this.presupuesto)} y Capacidad (kb): {this.capacidad}kb");
            }

        }

        private void buttonFinalizarV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El valor de la venta es: $ " + darFormato(totalVenta) + "\nDescuento: " + descuento * 100
                + "% que equivale a: $" + darFormato(totalVenta * descuento) + "\nEl total a pagar: $" + darFormato((totalVenta - totalVenta * descuento)));
            totalVenta = 0;
            descuento = 0;
        }

        public string darFormato(double precio)
        {
            return precio.ToString("N", CultureInfo.CreateSpecificCulture("es-ES"));
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
