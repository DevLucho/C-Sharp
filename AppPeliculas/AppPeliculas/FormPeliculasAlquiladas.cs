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
    public partial class FormPeliculasAlquiladas : Form
    {
        Usuario usuario;
        public FormPeliculasAlquiladas(Usuario usuario)
        {
            InitializeComponent();
            btnNovedad.Visible = false;
            this.usuario = usuario;
            MostrarPelis();
        }

        private void listPelis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPelis.SelectedIndex != -1)
                btnNovedad.Visible = true;
            else
                btnNovedad.Visible = false;
        }
        public void MostrarPelis()
        {
            if (this.usuario.PeliculasAlquiladas.Count != 0)
            {
                foreach (var pelicula in this.usuario.PeliculasAlquiladas)
                {
                    listPelis.Items.Add(pelicula.Identificador + " 🎬 " + pelicula.Nombre +"  |  "+ " 💿 " + pelicula.Genero +"  |  " + pelicula.Anotaciones);
                }
            }
        }

        private void btnNovedad_Click(object sender, EventArgs e)
        {
            string novedad = Microsoft.VisualBasic.Interaction.InputBox($"Ingrese la novedad que quieres registrar", "Alquilar pelicula", "");
            int i = listPelis.SelectedIndex;
            if (i != -1)
            {
                if ( novedad != "" )
                {
                    string identificador = listPelis.SelectedItem.ToString();
                    usuario.generarNovedad(Convert.ToInt32(identificador.Substring(0, 1)), novedad);
                    listPelis.Items.RemoveAt(i);
                    MostrarPelis();
                }
            }
        }
    }
}
