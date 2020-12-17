using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDeVideoJuegos
{
    public partial class FormBuqueda : Form
    {
        public FormBuqueda()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                FormTiendaVideojugos form = new FormTiendaVideojugos();
                form.presupuesto = int.Parse(textPresupuesto.Text);
                form.capacidad = int.Parse(textCapacidad.Text);
                form.showBuscarJ();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
