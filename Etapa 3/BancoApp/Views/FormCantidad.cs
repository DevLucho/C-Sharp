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
using Controllers;

namespace Views
{
    public partial class FormCantidad : Form
    {
       
        public FormCantidad(string opcion)
        {
            InitializeComponent();
            btnAction.Text = opcion;
            lblSaldo.Text = CuentaController.ConsultarSaldo(FormApp.cliente.Cuenta);
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            double cant = 0.0;
            try
            {
                cant = Convert.ToDouble(cantidad.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error tipo de dato. Solo se permiten numeros enteros / decimales");
            }

            if (cant != 0.0)
            {
                if (btnAction.Text.Equals("Retirar"))
                    MessageBox.Show(CuentaController.RetirarDinero(FormApp.cliente.Cuenta, cant));
                else if (btnAction.Text.Equals("Recargar"))
                    MessageBox.Show(CuentaController.RecargarCuenta(FormApp.cliente.Cuenta, cant));

                FormApp formApp = new FormApp(FormApp.cliente);
                this.Hide();
                formApp.ShowDialog();
                this.Close();
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormApp formApp = new FormApp(FormApp.cliente);
            this.Hide();
            formApp.ShowDialog();
            this.Close();
        }
    }
}
