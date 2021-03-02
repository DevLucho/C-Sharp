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
    public partial class FormApp : Form
    {
        public static ClsCliente cliente;

        public FormApp(ClsCliente cliente)
        {
            InitializeComponent();
            FormApp.cliente = cliente;
            txtTitular.Text = cliente.Titular;
            txtSaldo.Text = CuentaController.ConsultarSaldo(cliente.Cuenta);
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            FormCantidad formCantidad = new FormCantidad("Retirar");
            this.Hide();
            formCantidad.ShowDialog();
            this.Close();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            FormCantidad formCantidad = new FormCantidad("Recargar");
            this.Hide();
            formCantidad.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Close();
        }
    }
}
