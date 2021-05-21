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

namespace AppCajero
{
    public partial class FormPago : FormOpciones
    {
        Cuenta cuenta;
        int op;
        public FormPago(int op, Cuenta cuenta)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            this.op = op;
            if (op == 1)
                lblPago.Text = "Por favor digita el monto a retirar";
            else
                lblPago.Text = "Por favor digita el monto a transferir";
        }

        public FormPago()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            sonido();
            txtMonto.Text += '1';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            sonido();
            txtMonto.Text += '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            sonido();
            txtMonto.Text += '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            sonido();
            txtMonto.Text += '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            sonido();
            txtMonto.Text += '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            sonido();
            txtMonto.Text += '6';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            sonido();
            txtMonto.Text += '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            sonido();
            txtMonto.Text += '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            sonido();
            txtMonto.Text += '9';
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            sonido();
            txtMonto.Text += '0';
        }

        public new void btnEnter_Click(object sender, EventArgs e)
        {
            sonido();
            if (!String.IsNullOrEmpty(txtMonto.Text))
            {
                if ( op == 1)
                {
                    MessageBox.Show(this.cuenta.retirarSaldo(double.Parse(txtMonto.Text)));
                    this.Hide();
                    FormCajero formCajero = new FormCajero(this.cuenta);
                    formCajero.ShowDialog();
                    this.Close();
                }
                else
                {
                    double cantidad = double.Parse(txtMonto.Text);
                    if (cantidad <= this.cuenta.Saldo)
                    {
                        this.Hide();
                        FormTransfer formTransfer = new FormTransfer(this.cuenta, cantidad);
                        formTransfer.ShowDialog();
                        this.Close();
                    }
                }
            }
            else
                MessageBox.Show("Digita el monto a retirar", "Atención!");
        }

        public new void btnClear_Click(object sender, EventArgs e)
        {
            sonido();
            txtMonto.Text = "";
        }

        public override void btnCancel_Click(object sender, EventArgs e)
        {
            sonido();
            this.Hide();
            FormOpciones formOpciones = new FormOpciones(op, cuenta);
            formOpciones.ShowDialog();
            this.Close();
        }
    }
}
