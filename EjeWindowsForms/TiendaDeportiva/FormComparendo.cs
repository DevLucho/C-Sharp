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

namespace TiendaDeportiva
{
    public partial class FormComparendo : Form
    {
        public FormComparendo()
        {
            InitializeComponent();
        }

        int velocidadd;
        int multaa;
        int cuadrante;
        string placa;
        int totalInfracciones1;
        int totalInfracciones2;
        int totalInfracciones3;
        int totalInfracciones4;
        int multaPromedio1;
        int multaPromedio2;
        int multaPromedio3;
        int multaPromedio4;
        int totalMulta1;
        int totalMulta2;
        int totalMulta3;
        int totalMulta4;

        private void InicializarVariables()
        {
            velocidadd = 0;
            multaa = 0;
            cuadrante = 0;
            totalInfracciones1 = 0;
            totalInfracciones2 = 0;
            totalInfracciones3 = 0;
            totalInfracciones4 = 0;
            multaPromedio1 = 0;
            multaPromedio2 = 0;
            multaPromedio3 = 0;
            multaPromedio4 = 0;
            totalMulta1 = 0;
            totalMulta2 = 0;
            totalMulta3 = 0;
            totalMulta4 = 0;
        }
        public void mostraCajas()
        {
            txtInfra1.Text = totalInfracciones1.ToString();
            txtInfra2.Text = totalInfracciones2.ToString();
            txtInfra3.Text = totalInfracciones3.ToString();
            txtInfra4.Text = totalInfracciones4.ToString();

            txtMulProm1.Text = "$ " + darFormato(multaPromedio1);
            txtMulProm2.Text = "$ " + darFormato(multaPromedio2);
            txtMulProm3.Text = "$ " + darFormato(multaPromedio3);
            txtMulProm4.Text = "$ " + darFormato(multaPromedio4);

            txtTotalMul1.Text = "$ " + darFormato(totalMulta1);
            txtTotalMul2.Text = "$ " + darFormato(totalMulta2);
            txtTotalMul3.Text = "$ " + darFormato(totalMulta3);
            txtTotalMul4.Text = "$ " + darFormato(totalMulta4);
        }

        private void FormComparendos_Load(object sender, EventArgs e)
        {
            InicializarVariables();
            mostraCajas();
        }

        public string darFormato(int precio)
        {
            return precio.ToString("N", CultureInfo.CreateSpecificCulture("es-ES"));
        }

        private void txtComparendo_Click(object sender, EventArgs e)
        {
            try
            {
                placa = txtVelocidad.Text;
                velocidadd = int.Parse(txtVelcdad.Text);
                if (velocidadd > 80)
                {
                    multaa = (velocidadd - 80) * 2000;
                    dataGridView1.Rows.Add(placa, velocidadd, "80Km/h", darFormato(multaa));
                    switch (cbCuadrante.SelectedIndex)
                    {
                        case 0:
                            totalInfracciones1++;
                            totalMulta1 += multaa;
                            multaPromedio1 = totalMulta1 / totalInfracciones1;
                            break;
                        case 1:
                            totalInfracciones2++;
                            totalMulta2 += multaa;
                            multaPromedio2 = totalMulta2 / totalInfracciones2;
                            break;
                        case 2:
                            totalInfracciones3++;
                            totalMulta3 += multaa;
                            multaPromedio3 = totalMulta3 / totalInfracciones3;
                            break;
                        case 3:
                            totalInfracciones4++;
                            totalMulta4 += multaa;
                            multaPromedio4 = totalMulta4 / totalInfracciones4;
                            break;
                    }
                    mostraCajas();
                }
                else
                {
                    MessageBox.Show("La velocidad no genera multa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rellena los campos. " + ex.Message);
            }

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void FormComparendo_Load(object sender, EventArgs e)
        {

        }
    }
}


