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

namespace TiendaDeportiva
{
    public partial class FormTienda : Form
    {
        public FormTienda()
        {
            InitializeComponent();
        }

        int cant;
        int valorCompra;
        int tiendaC1;
        int tiendaC2;
        int tiendaC3;
        int tiendaC4;
        int valorArticulo1 = 100;
        int valorArticulo2 = 200;
        int valorArticulo3 = 300;
        int valorArticulo4 = 500;
        int articuloC1;
        int articuloC2;
        int articuloC3;
        int articuloC4;
        int total;

        public void inicializarVariables()
        {
            this.cant = 0;
            valorCompra = 0;
            tiendaC1 = 0;
            tiendaC2 = 0;
            tiendaC3 = 0;
            tiendaC4 = 0;
            articuloC1 = 0;
            articuloC2 = 0;
            articuloC3 = 0;
            articuloC4 = 0;
            total = 0;
        }

        public void mostrarCajas()
        {
            txtArti1.Text = "$ " + darFormato(articuloC1);
            txtArti2.Text = "$ " + darFormato(articuloC2);
            txtArti3.Text = "$ " + darFormato(articuloC3);
            txtArti4.Text = "$ " + darFormato(articuloC4);

            txtTienda1.Text = "$ " + darFormato(tiendaC1);
            txtTienda2.Text = "$ " + darFormato(tiendaC2);
            txtTienda3.Text = "$ " + darFormato(tiendaC3);
            txtTienda4.Text = "$ " + darFormato(tiendaC4);

            cantidad.Text = cant.ToString();
            compra.Text = "$ " + darFormato(valorCompra);
            txtTotal.Text = "$ " + darFormato(total);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                cant = int.Parse(cantidad.Text);
                switch (cbArticulo.SelectedIndex)
                {
                    case 0:
                        valorCompra = valorArticulo1 * cant;
                        articuloC1 += valorCompra;
                        switch (cbTienda.SelectedIndex)
                        {
                            case 0:
                                tiendaC1 += valorCompra;
                                break;
                            case 1:
                                tiendaC2 += valorCompra;
                                break;
                            case 2:
                                tiendaC3 += valorCompra;
                                break;
                            case 3:
                                tiendaC4 += valorCompra;
                                break;
                        }
                        break;
                    case 1:
                        valorCompra = valorArticulo2 * cant;
                        articuloC2 += valorCompra;
                        switch (cbTienda.SelectedIndex)
                        {
                            case 0:
                                tiendaC1 += valorCompra;
                                break;
                            case 1:
                                tiendaC2 += valorCompra;
                                break;
                            case 2:
                                tiendaC3 += valorCompra;
                                break;
                            case 3:
                                tiendaC4 += valorCompra;
                                break;
                        }
                        break;
                    case 2:
                        valorCompra = valorArticulo3 * cant;
                        articuloC3 += valorCompra;
                        switch (cbTienda.SelectedIndex)
                        {
                            case 0:
                                tiendaC1 += valorCompra;
                                break;
                            case 1:
                                tiendaC2 += valorCompra;
                                break;
                            case 2:
                                tiendaC3 += valorCompra;
                                break;
                            case 3:
                                tiendaC4 += valorCompra;
                                break;
                        }
                        break;
                    case 3:
                        valorCompra = valorArticulo4 * cant;
                        articuloC4 += valorCompra;
                        switch (cbTienda.SelectedIndex)
                        {
                            case 0:
                                tiendaC1 += valorCompra;
                                break;
                            case 1:
                                tiendaC2 += valorCompra;
                                break;
                            case 2:
                                tiendaC3 += valorCompra;
                                break;
                            case 3:
                                tiendaC4 += valorCompra;
                                break;
                        }
                        break;
                }

                total = valorCompra + total;
                mostrarCajas();
            }
            catch (Exception ex) { MessageBox.Show("Rellenas los campos. " + ex.Message); }
        }

        private void FormTienda_Load(object sender, EventArgs e)
        {
            inicializarVariables();
            mostrarCajas();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            inicializarVariables();
            mostrarCajas();
        }

        public string darFormato(int precio)
        {
            return precio.ToString("N", CultureInfo.CreateSpecificCulture("es-ES"));
        }
    }
}

