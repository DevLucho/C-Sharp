using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Views
{
    public partial class FormContactos : System.Windows.Forms.Form
    {
        public FormContactos()
        {
            InitializeComponent();
            btnEliminar.Visible = false;
            btnBuscar.Visible = false;
            btnTodos.Visible = false;
            MostrarContactos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar();
            this.Hide();
            formAgregar.ShowDialog();
            this.Close();
        }

        public void MostrarContactos()
        {
            if (ContactoController.contactos.Count != 0)
            {
                foreach (var item in ContactoController.contactos)
                {
                    listContactos.Items.Add("📞 " +  item.Telefono + " 👤 " + item.Nombres + " " + item.Apellidos + " 💼 " + item.Organizacion);
                }
            }
        }

        private void listContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listContactos.SelectedIndex != -1)
                btnEliminar.Visible = true;
            else
                btnEliminar.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int i = listContactos.SelectedIndex;
            if (i!=-1)
            {
                listContactos.Items.RemoveAt(i);
                MessageBox.Show(ContactoController.EliminarContacto(i));
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClsContacto item = ContactoController.BuscarContacto(txtSearch.Text);
            if (item != null)
            {
                btnTodos.Visible = true;
                listContactos.Items.Clear();
                listContactos.Items.Add("📞 " + item.Telefono + " 👤 " + item.Nombres + " " + item.Apellidos + " 💼 " + item.Organizacion);
            } else
            {
                MessageBox.Show($"No hay resultados con la busqueda: {txtSearch.Text}");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
                btnBuscar.Visible = true;
            else
                btnBuscar.Visible = false;
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            listContactos.Items.Clear();
            MostrarContactos();
        }
    }
}
