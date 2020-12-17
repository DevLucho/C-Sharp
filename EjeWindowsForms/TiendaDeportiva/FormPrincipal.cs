using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaDeVideoJuegos;

namespace TiendaDeportiva
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void ToolComparendos_Click(object sender, EventArgs e)
        {
            FormComparendo formComparendo = new FormComparendo();
            formComparendo.Show();
        }

        private void ToolTiendas_Click(object sender, EventArgs e)
        {
            FormTienda formTienda = new FormTienda();
            formTienda.Show();
        }

        private void ToolJuegos_Click(object sender, EventArgs e)
        {
            FormTiendaVideojugos formTiendaVideojugos = new FormTiendaVideojugos();
            formTiendaVideojugos.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
