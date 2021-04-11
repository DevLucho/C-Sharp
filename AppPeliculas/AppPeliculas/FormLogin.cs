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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int documento = 0;
            string contrasenia = txtPass.Text;
            try
            {
                documento = Convert.ToInt32(txtDoc.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Documento incorrecto");
            }

            if (documento != 0 && !String.IsNullOrEmpty(contrasenia))
            {
                if (Usuario.Login(documento, contrasenia) != null)
                {
                    FormTiendaPeliculas formApp = new FormTiendaPeliculas(Usuario.Login(documento, contrasenia));
                    this.Hide();
                    formApp.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Documento y/o contraseña iconrrecto(s).");
                }
            }
            else
            {
                MessageBox.Show("Completa los campos");
            }
        }

        private void lnkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro();
            this.Hide();
            formRegistro.ShowDialog();
            this.Close();
        }
    }
}
