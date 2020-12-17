namespace Eje3
{
    partial class FormAccidente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFemenino = new System.Windows.Forms.CheckBox();
            this.cbMaculino = new System.Windows.Forms.CheckBox();
            this.rdBogota = new System.Windows.Forms.RadioButton();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.Label();
            this.lblFechaNa = new System.Windows.Forms.Label();
            this.dtpFechaNa = new System.Windows.Forms.DateTimePicker();
            this.rdOtras = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPorcMenores = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPorcFemen = new System.Windows.Forms.Label();
            this.lblPorcMascu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblMascuEntre = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblFueraBogo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFemenino);
            this.groupBox1.Controls.Add(this.cbMaculino);
            this.groupBox1.Controls.Add(this.rdBogota);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Sexo);
            this.groupBox1.Controls.Add(this.lblFechaNa);
            this.groupBox1.Controls.Add(this.dtpFechaNa);
            this.groupBox1.Controls.Add(this.rdOtras);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar conductor";
            // 
            // cbFemenino
            // 
            this.cbFemenino.AutoSize = true;
            this.cbFemenino.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFemenino.Location = new System.Drawing.Point(112, 106);
            this.cbFemenino.Name = "cbFemenino";
            this.cbFemenino.Size = new System.Drawing.Size(89, 20);
            this.cbFemenino.TabIndex = 11;
            this.cbFemenino.Text = "Femenino";
            this.cbFemenino.UseVisualStyleBackColor = true;
            this.cbFemenino.CheckedChanged += new System.EventHandler(this.cbFemenino_CheckedChanged);
            // 
            // cbMaculino
            // 
            this.cbMaculino.AutoSize = true;
            this.cbMaculino.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaculino.Location = new System.Drawing.Point(6, 106);
            this.cbMaculino.Name = "cbMaculino";
            this.cbMaculino.Size = new System.Drawing.Size(91, 20);
            this.cbMaculino.TabIndex = 10;
            this.cbMaculino.Text = "Masculino";
            this.cbMaculino.UseVisualStyleBackColor = true;
            this.cbMaculino.CheckedChanged += new System.EventHandler(this.cbMaculino_CheckedChanged);
            // 
            // rdBogota
            // 
            this.rdBogota.AutoSize = true;
            this.rdBogota.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBogota.Location = new System.Drawing.Point(9, 176);
            this.rdBogota.Name = "rdBogota";
            this.rdBogota.Size = new System.Drawing.Size(72, 20);
            this.rdBogota.TabIndex = 0;
            this.rdBogota.TabStop = true;
            this.rdBogota.Text = "Bogotá";
            this.rdBogota.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(63, 222);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(102, 38);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registro del carro";
            // 
            // Sexo
            // 
            this.Sexo.AutoSize = true;
            this.Sexo.Location = new System.Drawing.Point(6, 87);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(44, 16);
            this.Sexo.TabIndex = 2;
            this.Sexo.Text = "Sexo";
            // 
            // lblFechaNa
            // 
            this.lblFechaNa.AutoSize = true;
            this.lblFechaNa.Location = new System.Drawing.Point(6, 31);
            this.lblFechaNa.Name = "lblFechaNa";
            this.lblFechaNa.Size = new System.Drawing.Size(159, 16);
            this.lblFechaNa.TabIndex = 1;
            this.lblFechaNa.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNa
            // 
            this.dtpFechaNa.CustomFormat = "yyyy";
            this.dtpFechaNa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNa.Location = new System.Drawing.Point(9, 50);
            this.dtpFechaNa.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpFechaNa.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNa.Name = "dtpFechaNa";
            this.dtpFechaNa.Size = new System.Drawing.Size(174, 23);
            this.dtpFechaNa.TabIndex = 0;
            // 
            // rdOtras
            // 
            this.rdOtras.AutoSize = true;
            this.rdOtras.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOtras.Location = new System.Drawing.Point(112, 176);
            this.rdOtras.Name = "rdOtras";
            this.rdOtras.Size = new System.Drawing.Size(125, 20);
            this.rdOtras.TabIndex = 9;
            this.rdOtras.TabStop = true;
            this.rdOtras.Text = "Otras ciudades";
            this.rdOtras.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPorcMenores);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(271, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conductores menores de 30 años.";
            // 
            // lblPorcMenores
            // 
            this.lblPorcMenores.AutoSize = true;
            this.lblPorcMenores.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcMenores.Location = new System.Drawing.Point(79, 50);
            this.lblPorcMenores.Name = "lblPorcMenores";
            this.lblPorcMenores.Size = new System.Drawing.Size(0, 42);
            this.lblPorcMenores.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPorcFemen);
            this.groupBox3.Controls.Add(this.lblPorcMascu);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(271, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 154);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conductores del sexo:";
            // 
            // lblPorcFemen
            // 
            this.lblPorcFemen.AutoSize = true;
            this.lblPorcFemen.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcFemen.Location = new System.Drawing.Point(163, 75);
            this.lblPorcFemen.Name = "lblPorcFemen";
            this.lblPorcFemen.Size = new System.Drawing.Size(0, 42);
            this.lblPorcFemen.TabIndex = 4;
            // 
            // lblPorcMascu
            // 
            this.lblPorcMascu.AutoSize = true;
            this.lblPorcMascu.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcMascu.Location = new System.Drawing.Point(6, 75);
            this.lblPorcMascu.Name = "lblPorcMascu";
            this.lblPorcMascu.Size = new System.Drawing.Size(0, 42);
            this.lblPorcMascu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Femenino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masculino";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblMascuEntre);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(584, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 117);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Coductores masculinos con edad entre 12 y 30 años.";
            // 
            // lblMascuEntre
            // 
            this.lblMascuEntre.AutoSize = true;
            this.lblMascuEntre.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascuEntre.Location = new System.Drawing.Point(97, 50);
            this.lblMascuEntre.Name = "lblMascuEntre";
            this.lblMascuEntre.Size = new System.Drawing.Size(0, 42);
            this.lblMascuEntre.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblFueraBogo);
            this.groupBox5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(584, 134);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(307, 154);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Conductores cuyos carros estan registrados fuera de bogotá";
            // 
            // lblFueraBogo
            // 
            this.lblFueraBogo.AutoSize = true;
            this.lblFueraBogo.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFueraBogo.Location = new System.Drawing.Point(97, 75);
            this.lblFueraBogo.Name = "lblFueraBogo";
            this.lblFueraBogo.Size = new System.Drawing.Size(0, 42);
            this.lblFueraBogo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad de registros: ";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(655, 308);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 29);
            this.lblCount.TabIndex = 6;
            this.lblCount.Tag = "";
            // 
            // FormAccidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(898, 378);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormAccidente";
            this.Text = "Oficina de seguros";
            this.Load += new System.EventHandler(this.FormAccidente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Sexo;
        private System.Windows.Forms.Label lblFechaNa;
        private System.Windows.Forms.DateTimePicker dtpFechaNa;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBogota;
        private System.Windows.Forms.RadioButton rdOtras;
        private System.Windows.Forms.Label lblPorcMenores;
        private System.Windows.Forms.Label lblMascuEntre;
        private System.Windows.Forms.Label lblFueraBogo;
        private System.Windows.Forms.Label lblPorcFemen;
        private System.Windows.Forms.Label lblPorcMascu;
        private System.Windows.Forms.CheckBox cbFemenino;
        private System.Windows.Forms.CheckBox cbMaculino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCount;
    }
}

