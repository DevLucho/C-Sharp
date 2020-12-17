using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eje3
{
    public partial class FormAccidente : Form
    {

        List<OficinaSeguro> registros = new List<OficinaSeguro>();

        public FormAccidente()
        {
            // Registro para sexo: Masculino o Femenino
            // Registro carro: Bogota o Otras ciudades

            /* 
             * Agrega objetos a la lista - (Registros por defecto)
             */

            //OficinaSeguro seguro = new OficinaSeguro(2002, "Masculino", "Bogota");
            //registros.Add(seguro);

            InitializeComponent();
        }
        private void FormAccidente_Load(object sender, EventArgs e)
        {
            dtpFechaNa.MaxDate = DateTime.Now;
            Limpiar();
            MostrarPorcentajes();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if ((cbMaculino.Checked || cbFemenino.Checked) && (rdBogota.Checked || rdOtras.Checked))
            {
                OficinaSeguro accidente = new OficinaSeguro();
                accidente.AnioNacimiento = dtpFechaNa.Value.Year;
                if (cbMaculino.Checked)
                    accidente.Sexo = "Masculino";
                else if (cbFemenino.Checked)
                    accidente.Sexo = "Femenino";

                if (rdBogota.Checked)
                    accidente.RegistroCarro = "Bogota";
                else if (rdOtras.Checked)
                    accidente.RegistroCarro = "Otras ciudades";

                OficinaSeguro objAccidente = new OficinaSeguro(accidente.AnioNacimiento, accidente.Sexo, accidente.RegistroCarro);
                registros.Add(objAccidente);
                MessageBox.Show("Registro exitoso");
                Limpiar();
                MostrarPorcentajes();
            }
            else
                MessageBox.Show("Faltan campos por completar.");
        }

        public int CalcularEdad(int anioNac)
        {
            return DateTime.Now.Year - anioNac;
        }

        public double PorcentajeMenores()
        {
            if (registros.Any())
            {
                int count = 0; // Contador: conductores menores de 30 anios
                foreach (var item in this.registros)
                {
                    if (CalcularEdad(item.AnioNacimiento) < 30)
                        count++;
                }
                return Math.Round(((count * 100) / double.Parse(this.registros.Count.ToString())));
            }
            else
                return 0;
        }

        public double PorcentajeSexo(int sexo)
        {
            if (registros.Any())
            {
                int countH = 0; // Contador: conductores masculinos
                int countF = 0; // Contador: conductores femeninos
                foreach (var item in this.registros)
                {
                    if (item.Sexo.Equals("Masculino"))
                        countH++;
                    else
                        countF++;
                }
                if (sexo == 1)
                    return Math.Round(((countF * 100) / double.Parse(this.registros.Count.ToString())));
                else
                    return Math.Round(((countH * 100) / double.Parse(this.registros.Count.ToString())));
            }
            else
                return 0;
        }

        public double PorcentajeEdades()
        {
            if (registros.Any())
            {
                int count = 0; // Contador: coductores masculinos entre 12 y 30 anios.
                foreach (var item in this.registros)
                {
                    int edad = CalcularEdad(item.AnioNacimiento);
                    if ((edad >= 12 && edad <= 30) && item.Sexo.Equals("Masculino"))
                        count++;
                }
                return Math.Round(((count * 100) / double.Parse(this.registros.Count.ToString())));
            }
            else
                return 0;
        }

        public double PorcentajeCarros()
        {
            if (registros.Any())
            {
                int count = 0; // Contador: Conductores cuyos carros estan fuera de Bogota
                foreach (var item in this.registros)
                {
                    if (item.RegistroCarro.Equals("Otras ciudades"))
                        count++;
                }
                return Math.Round(((count * 100) / double.Parse(this.registros.Count.ToString())));
            }
            else
                return 0;
        }

        public void Limpiar()
        {
            cbFemenino.Checked = false;
            cbMaculino.Checked = false;
            rdBogota.Checked = false;
            rdOtras.Checked = false;
        }

        public void MostrarPorcentajes()
        {
            lblPorcMenores.Text = PorcentajeMenores().ToString() + " %";
            lblPorcFemen.Text = PorcentajeSexo(1).ToString() + " %";
            lblPorcMascu.Text = PorcentajeSexo(2).ToString() + " %";
            lblMascuEntre.Text = PorcentajeEdades().ToString() + " %";
            lblFueraBogo.Text = PorcentajeCarros().ToString() + " %";
            lblCount.Text = this.registros.Count.ToString();
        }
        private void cbMaculino_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFemenino.Checked)
                cbMaculino.Checked = false;
        }

        private void cbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMaculino.Checked)
                cbFemenino.Checked = false;
        }
    }
}
