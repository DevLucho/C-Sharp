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
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string organizacion = txtOrganizacion.Text;
            if (String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(apellido) || String.IsNullOrEmpty(telefono) || String.IsNullOrEmpty(organizacion))
            {
                MessageBox.Show("Completa todos los campos.");
            }
            else
            {
                ClsContacto contacto = new ClsContacto(nombre, apellido, telefono, organizacion);
                MessageBox.Show(ContactoController.AñadirContacto(contacto));
                FormContactos formContactos = new FormContactos();
                this.Hide();
                formContactos.ShowDialog();
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormContactos formContactos = new FormContactos();
            this.Hide();
            formContactos.ShowDialog();
            this.Close();
        }
    }
}
