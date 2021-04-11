using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPeliculas
{
    public partial class FormTiendaPeliculas : Form
    {
        static int sesiones = 0;
        public static Usuario usuario;
        int indice = -1;

        public FormTiendaPeliculas(Usuario usuario)
        {
            InitializeComponent();
            FormTiendaPeliculas.usuario = usuario;
            lblNombreUser.Text = usuario.Nombre;
        }

        private void FormTiendaPeliculas_Load(object sender, EventArgs e)
        {
            sesiones++;
            if ( sesiones == 1)
            {
                Pelicula pelicula1 = new Pelicula(0, "Avengers End Game", "Acción/Ciencia ficción", 2000, 5);
                Pelicula pelicula2 = new Pelicula(1, "La razón de estar contigo", "Comedia/Drama", 2000, 5);
                Pelicula pelicula3 = new Pelicula(2, "Pokémon: detective Pikachu", "Infantil/Aventura", 2000, 5);
                Pelicula pelicula4 = new Pelicula(3, "Maestras del engaño", "Crimen", 2000, 5);
                Pelicula pelicula5 = new Pelicula(4, "Dumbo", "Infantil/Fantasía", 2000, 5);

                Pelicula.peliculas.Add(pelicula1);
                Pelicula.peliculas.Add(pelicula2);
                Pelicula.peliculas.Add(pelicula3);
                Pelicula.peliculas.Add(pelicula4);
                Pelicula.peliculas.Add(pelicula5);
            }

            foreach (var pelicula in Pelicula.peliculas)
            {
                comboPelicula.Items.Add(pelicula.Nombre);
            }
        }

        private void comboPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = comboPelicula.SelectedIndex;
            foreach (var pelicula in Pelicula.peliculas)
            {
                if (pelicula.Identificador == indice)
                {
                    textNombre.Text = pelicula.Nombre;
                    textGenero.Text = pelicula.Genero;
                    textPrecio.Text = "$ " + pelicula.Precio;
                    textDisponibles.Text = pelicula.Disponibilidad.ToString();
                    switch (indice)
                    {
                        
                        case 0:
                            pictureImagen.Image = AppPeliculas.Properties.Resources.img_avengers;
                            break;
                        case 1:
                            pictureImagen.Image = AppPeliculas.Properties.Resources.img_la_razon_de_estar_contigo;
                            break;
                        case 2:
                            pictureImagen.Image = AppPeliculas.Properties.Resources.img_pikachu;
                            break;
                        case 3:
                            pictureImagen.Image = AppPeliculas.Properties.Resources.img_maestras_del_engaño;
                            break;
                        case 4:
                            pictureImagen.Image = AppPeliculas.Properties.Resources.img_dumbo;
                            break;

                    }
                }
            }
        }

        public string darFormato(double precio)
        {
            return precio.ToString("N", CultureInfo.CreateSpecificCulture("es-ES"));
        }

        private void buttonAlquilar_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad a de peliculas a alquilar", "Alquilar pelicula", "0"));
            textDisponibles.Text = Pelicula.alquilar(cantidad, indice, usuario).ToString();
        }

        private void buttonPelisAlquiladas_Click(object sender, EventArgs e)
        {
            FormPeliculasAlquiladas form = new FormPeliculasAlquiladas(usuario);
            form.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Close();
        }
    }
}
