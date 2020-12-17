using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class FormAhorcado : Form
    {

        DialogResult result;
        int marcador;
        int fallos;
        int longitud;
        string adivinar;
        string[] palabraSolucion;
        string[] palabras = {
            "CURRICULUM","JUNIOR","TOTTO","CELULAR","INSISTIR",
            "CARTERA","REGISTRO","DESPERTAR","ARRESTAR","IDENTICO"
        };

        public FormAhorcado()
        {
            InitializeComponent();
            this.marcador = 0;
            this.fallos = 0;
            textMarcador.Text = this.marcador.ToString();
            textFallos.Text = this.fallos.ToString();
            this.disabledBtn(groupBox2); // Todos los botones disabled
        }

        private void btnRecarga_Click(object sender, EventArgs e)
        {

            this.Limpiar(groupBox3, groupBox2, groupBox4);
            this.fallos = 0;

            Random rdm = new Random();
            int i = rdm.Next(0, 9);

            adivinar = palabras[i];
            longitud = adivinar.Length;
            palabraSolucion = new string[adivinar.Length];

            for (int j = 0; j < adivinar.Length; j++)
            {
                palabraSolucion[j] = "_";
            }

            this.mostrarArreglo();

        }

        private void mostrarArreglo()
        {
            textMarcador.Text = this.marcador.ToString();
            textFallos.Text = this.fallos.ToString();
            txtAdivinar.ResetText();
            for (int i = 0; i < this.adivinar.Length; i++)
            {
                txtAdivinar.Text += this.palabraSolucion[i] + " ";
            }
        }

        private void validarLetra(char letra)
        {

            bool verificar = false;

            for (int i = 0; i < this.adivinar.Length; i++)
            {
                if (letra == this.adivinar[i])
                {
                    verificar = true;
                    this.palabraSolucion[i] = letra.ToString();
                    longitud = longitud - 1;
                }
            }
            if (!verificar)
            {
                this.fallos++;
            }

            this.mostrarArreglo();
            textLetras.Text += letra + " - ";
            this.pintarAhorcado();

            if (longitud == 0)
            {
                this.marcador++;
                textMarcador.Text = this.marcador.ToString();
                result = MessageBox.Show("Juego terminado, felicitaciones!");
                if (result == DialogResult.OK)
                {
                    this.adivinar = "";
                    this.Limpiar(groupBox3, groupBox2, groupBox4);
                    this.disabledBtn(groupBox2);
                }
            }
        }
        // Limpia todo los controles del form
        public void Limpiar(GroupBox gb, GroupBox gb2, GroupBox gb3)
        {
            foreach (var txt in gb.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
            }
            foreach (var btn in gb2.Controls)
            {
                if (btn is Button)
                {
                    ((Button)btn).Enabled = true;
                }
            }
            foreach (var img in gb3.Controls)
            {
                if (img is PictureBox)
                {
                    ((PictureBox)img).Visible = false;
                }
            }
        }
        // Deshabilita todos los botones
        public void disabledBtn(GroupBox gb)
        {
            foreach (var btn in gb.Controls)
            {
                if (btn is Button)
                {
                    ((Button)btn).Enabled = false;
                }
            }
        }

        private void pintarAhorcado()
        {
            switch (this.fallos)
            {
                case 1:
                    img1.Visible = true;
                    break;
                case 2:
                    img1.Visible = false;
                    img2.Visible = true;
                    break;
                case 3:
                    img2.Visible = false;
                    img3.Visible = true;
                    break;
                case 4:
                    img3.Visible = false;
                    img4.Visible = true;
                    break;
                case 5:
                    img4.Visible = false;
                    img5.Visible = true;
                    break;
                case 6:
                    img5.Visible = false;
                    img6.Visible = true;
                    break;
                case 7:
                    img6.Visible = false;
                    img7.Visible = true;
                    break;
                case 8:
                    img7.Visible = false;
                    img8.Visible = true;
                    result = MessageBox.Show($"Perdites :( la palabra era: {this.adivinar}");
                    if (result == DialogResult.OK)
                    {
                        this.adivinar = "";
                        this.Limpiar(groupBox3, groupBox2, groupBox4);
                        this.disabledBtn(groupBox2);
                    }
                    break;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            this.validarLetra('A');
            btnA.Enabled = false;
        }
        private void btnB_Click(object sender, EventArgs e)
        {
            this.validarLetra('B');
            btnB.Enabled = false;
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            this.validarLetra('C');
            btnC.Enabled = false;
        }
        private void btnD_Click(object sender, EventArgs e)
        {
            this.validarLetra('D');
            btnD.Enabled = false;
        }
        private void btnE_Click(object sender, EventArgs e)
        {
            this.validarLetra('E');
            btnE.Enabled = false;
        }
        private void btnF_Click(object sender, EventArgs e)
        {
            this.validarLetra('F');
            btnF.Enabled = false;
        }
        private void btnG_Click(object sender, EventArgs e)
        {
            this.validarLetra('G');
            btnG.Enabled = false;
        }
        private void btnH_Click(object sender, EventArgs e)
        {
            this.validarLetra('H');
            btnH.Enabled = false;
        }
        private void btnI_Click(object sender, EventArgs e)
        {
            this.validarLetra('I');
            btnI.Enabled = false;
        }
        private void btnJ_Click(object sender, EventArgs e)
        {
            this.validarLetra('J');
            btnJ.Enabled = false;
        }
        private void btnK_Click(object sender, EventArgs e)
        {
            this.validarLetra('K');
            btnK.Enabled = false;
        }
        private void btnL_Click(object sender, EventArgs e)
        {
            this.validarLetra('L');
            btnL.Enabled = false;
        }
        private void btnM_Click(object sender, EventArgs e)
        {
            this.validarLetra('M');
            btnM.Enabled = false;
        }
        private void btnN_Click(object sender, EventArgs e)
        {
            this.validarLetra('N');
            btnN.Enabled = false;
        }
        private void btnO_Click(object sender, EventArgs e)
        {
            this.validarLetra('O');
            btnO.Enabled = false;
        }
        private void btnP_Click(object sender, EventArgs e)
        {
            this.validarLetra('P');
            btnP.Enabled = false;
        }
        private void btnQ_Click(object sender, EventArgs e)
        {
            this.validarLetra('Q');
            btnQ.Enabled = false;
        }
        private void btnR_Click(object sender, EventArgs e)
        {
            this.validarLetra('R');
            btnR.Enabled = false;
        }
        private void btnS_Click(object sender, EventArgs e)
        {
            this.validarLetra('S');
            btnS.Enabled = false;
        }
        private void btnT_Click(object sender, EventArgs e)
        {
            this.validarLetra('T');
            btnT.Enabled = false;
        }
        private void btnU_Click(object sender, EventArgs e)
        {
            this.validarLetra('U');
            btnU.Enabled = false;
        }
        private void btnV_Click(object sender, EventArgs e)
        {
            this.validarLetra('V');
            btnV.Enabled = false;
        }
        private void btnW_Click(object sender, EventArgs e)
        {
            this.validarLetra('W');
            btnW.Enabled = false;
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            this.validarLetra('X');
            btnX.Enabled = false;
        }
        private void btnY_Click(object sender, EventArgs e)
        {
            this.validarLetra('Y');
            btnY.Enabled = false;
        }
        private void btnZ_Click(object sender, EventArgs e)
        {
            this.validarLetra('Z');
            btnZ.Enabled = false;
        }
    }
}
