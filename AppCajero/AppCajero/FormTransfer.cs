using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using System.Numerics;

namespace AppCajero
{
    public partial class FormTransfer : FormOpciones
    {
        Cuenta cuenta;
        double cantidad;
        public FormTransfer(Cuenta cuenta, double cantidad )
        {
            InitializeComponent();
            this.cuenta = cuenta;
            this.cantidad = cantidad;
        }
        public FormTransfer()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            sonido();
            lblNumCuenta.Text += '1';
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            sonido();
            lblNumCuenta.Text += '2';
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            sonido();
            lblNumCuenta.Text += '3';
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            sonido();
            lblNumCuenta.Text += '4';
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            sonido();
            lblNumCuenta.Text += '5';
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            sonido();
            lblNumCuenta.Text += '6';
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            sonido();
            lblNumCuenta.Text += '7';
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            sonido();
            lblNumCuenta.Text += '8';
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            sonido();
            lblNumCuenta.Text += '9';
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            sonido();
            lblNumCuenta.Text += '0';
        }

        public new void btnEnter_Click(object sender, EventArgs e)
        {
            sonido();
            if (!String.IsNullOrEmpty(lblNumCuenta.Text))
            {
                if (cuenta.transferir(BigInteger.Parse(lblNumCuenta.Text), cantidad))
                {
                    MessageBox.Show($"Se realizo exisamente la transacción de {cuenta.darFormato(cantidad)} pesos.");
                    this.Hide();
                    FormCajero formCajero = new FormCajero(cuenta);
                    formCajero.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("La tarjeta no fue encontrada");
            } else
            {
                MessageBox.Show("Completa el número de cuenta.","Error");
            }
        }

        private new void btnClear_Click(object sender, EventArgs e)
        {
            sonido();
            lblNumCuenta.Text = "";
        }

        public override void btnCancel_Click(object sender, EventArgs e)
        {
            sonido();
            this.Hide();
            FormOpciones formOpciones = new FormOpciones(2, cuenta);
            formOpciones.ShowDialog();
            this.Close();
        }
    }
}
