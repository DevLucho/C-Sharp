using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPeliculas
{
    public partial class FormRegistro : Form
    {

        FormLogin formLogin = new FormLogin();

        public FormRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string titular = txtTitular.Text;
            int documento = 0;
            try
            {
                documento = Convert.ToInt32(txtDoc.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Numero de documento invalido.");
            }
            string contrasenia = txtPass.Text;
            if (String.IsNullOrEmpty(titular) || String.IsNullOrEmpty(contrasenia) || documento == 0)
            {
                MessageBox.Show("Completa todos los campos.");
            }
            else
            {
                MessageBox.Show(Usuario.CrearCliente(titular, documento, contrasenia));
                this.Hide();
                formLogin.ShowDialog();
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formLogin.ShowDialog();
            this.Close();
        }
    }
}
