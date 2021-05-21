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
    public partial class FormOpciones : FormCajero
    {
        Cuenta cuenta;
        int op;
        private void FormOpciones_Load(object sender, EventArgs e)
        {
        }
        public FormOpciones()
        {
            InitializeComponent();
        }
        public FormOpciones(int op, Cuenta cuenta)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            this.op = op;
            if (op == 1)
                lbltitle.Text = "Seleccione monto de retiro";
            else
                lbltitle.Text = "Seleccione monto de transferencia";
        }
        
        protected override void btnAction1_Click(object sender, EventArgs e)
        {
            procesarPago(op, 50000);
        }

        protected override void btnAction2_Click(object sender, EventArgs e)
        {
            procesarPago(op, 100000);
        }

        protected override void btnAction3_Click(object sender, EventArgs e)
        {
            procesarPago(op, 200000);
        }

        protected override void btnAction4_Click(object sender, EventArgs e)
        {
            procesarPago(op, 300000);
        }

        protected override void btnAction5_Click(object sender, EventArgs e)
        {
            procesarPago(op, 400000);
        }

        protected override void btnAction6_Click(object sender, EventArgs e)
        {
            procesarPago(op, 500000);
        }

        void btnAction7_Click(object sender, EventArgs e)
        {
            procesarPago(op, 600000);
        }

        // Seleccionar otro valor
        public override void btnCerrar_Click(object sender, EventArgs e)
        {
            sonido();
            this.Hide();
            FormPago formPago = new FormPago(op, cuenta);
            formPago.ShowDialog();
            this.Close();
        }

        // Volver al anterior form
        public virtual void btnCancel_Click(object sender, EventArgs e)
        {
            sonido();
            this.Hide();
            FormCajero formCajero = new FormCajero(cuenta);
            formCajero.ShowDialog();
            this.Close();
        }

        public void retirar(double cantidad)
        {
            MessageBox.Show(cuenta.retirarSaldo(cantidad));
            this.Hide();
            FormCajero formCajero = new FormCajero(cuenta);
            formCajero.ShowDialog();
            this.Close();
        }

        public void procesarPago(int op, double cantidad)
        {
            sonido();
            if (op == 1)
                retirar(cantidad);
            else
            {
                if (cantidad > cuenta.Saldo)
                    MessageBox.Show("Fondos insuficientes");
                else
                {
                    this.Hide();
                    FormTransfer formTransfer = new FormTransfer(this.cuenta, cantidad);
                    formTransfer.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
