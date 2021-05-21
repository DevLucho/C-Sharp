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
    public partial class FormLogin : FormCajero
    {
        static int sesiones = 0;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            sesiones++;
            if (sesiones == 1)
            {
                Cliente cliente = new Cliente("Luis David Huertas Redondo", 1000999999, "123");
                Cuenta cuenta = new Cuenta(cliente, 1200000, 1234567890, 0425, 200);
                Banco.agregar(cuenta);

                Cliente cliente2 = new Cliente("Shanon Martinez Gomez", 1000941682, "123");
                Cuenta cuenta2 = new Cuenta(cliente2, 2300000, 1234567891, 0425, 100);
                Banco.agregar(cuenta2);
            }
        }

        public new void btnEnter_Click(object sender, EventArgs e)
        {
            sonido();
            int documento = 0;
            string clave = txtClave.Text;
            bool valid = false;
            try
            {
                documento = Convert.ToInt32(txtUsuario.Text);
                valid = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Documento incorrecto");
            }
            if (valid)
            {
                if (documento != 0 && !String.IsNullOrEmpty(clave))
                {
                    if (Cliente.login(documento, clave) != null)
                    {
                        FormCajero formCajero = new FormCajero(Cliente.login(documento, clave));
                        this.Hide();
                        formCajero.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Documento y/o contraseña iconrrecto(s).");
                }
                else
                    MessageBox.Show("Completa los campos");
            }
        }

        public new void btnClear_Click(object sender, EventArgs e)
        {
            sonido();
            txtClave.Text = "";
            txtUsuario.Text = "";
        }
    }
}
