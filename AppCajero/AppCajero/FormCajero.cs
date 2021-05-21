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
using System.Media;
using System.IO;

namespace AppCajero
{
    public partial class FormCajero : Form
    {
        Cuenta cuenta;

        public FormCajero()
        {
            InitializeComponent();
        }

        public FormCajero(Cuenta cuenta)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            lblTitular.Text = cuenta.Cliente.Nombre;
        }

        private void FormCajero_Load(object sender, EventArgs e)
        {

        }

        public virtual void btnEnter_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnClear_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnCerrar_Click(object sender, EventArgs e)
        {
            sonido();
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Close();
        }

        public void sonido()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Directory.GetCurrentDirectory() + "\\efecto_cajero.wav");
            soundPlayer.Play();
        }

        // Consultar saldo
        protected virtual void btnAction1_Click(object sender, EventArgs e)
        {
            sonido();
            MessageBox.Show(cuenta.consultarSaldo(), "Saldo actual");
        }

        // Retirar saldo
        protected virtual void btnAction2_Click(object sender, EventArgs e)
        {
            sonido();
            this.Hide();
            FormOpciones formOpciones = new FormOpciones(1, cuenta);
            formOpciones.ShowDialog();
            this.Close();
        }

        // Hacer transferencia
        protected virtual void btnAction3_Click(object sender, EventArgs e)
        {
            sonido();
            this.Hide();
            FormOpciones formOpciones = new FormOpciones(2, cuenta);
            formOpciones.ShowDialog();
            this.Close();
        }

        // Consulta numero de cuenta
        protected virtual void btnAction4_Click(object sender, EventArgs e)
        {
            sonido();
            MessageBox.Show(cuenta.NumCuenta.ToString(), "Número de cuenta.");
        }

        // Consulta de puntos
        protected virtual void btnAction5_Click(object sender, EventArgs e)
        {
            sonido();
            MessageBox.Show("Tienes en total: " + cuenta.Puntos.ToString() + "pts.", "Consulta de puntos");
        }

        // Canje de puntos
        protected virtual void btnAction6_Click(object sender, EventArgs e)
        {
            sonido();
            string puntos = Microsoft.VisualBasic.Interaction.InputBox($"Puntos actuales: {cuenta.Puntos}pts\nRecuerde que los puntos a redimir deben ser multiplos de 10.\n\nIngrese la cantidad de puntos a redimir:", "Canjear puntos", "");
            if (!String.IsNullOrEmpty(puntos))
            {
                try
                {
                    MessageBox.Show(cuenta.canjearPuntos(int.Parse(puntos)), "Respuesta");
                }
                catch (Exception)
                {
                    MessageBox.Show("Solo se permite numeros enteros.", "Tipo de dato incorrecto.");
                }
            }
        }
    }
}
