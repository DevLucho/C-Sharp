namespace TiendaDeportiva
{
    partial class FormTienda
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.compra = new System.Windows.Forms.TextBox();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.cbArticulo = new System.Windows.Forms.ComboBox();
            this.cbTienda = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTienda4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTienda3 = new System.Windows.Forms.TextBox();
            this.txtTienda2 = new System.Windows.Forms.TextBox();
            this.txtTienda1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtArti4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtArti3 = new System.Windows.Forms.TextBox();
            this.txtArti2 = new System.Windows.Forms.TextBox();
            this.txtArti1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnVender);
            this.groupBox1.Controls.Add(this.compra);
            this.groupBox1.Controls.Add(this.cantidad);
            this.groupBox1.Controls.Add(this.cbArticulo);
            this.groupBox1.Controls.Add(this.cbTienda);
            this.groupBox1.Location = new System.Drawing.Point(12, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 350);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comprar articulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "VALOR COMPRA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CANTIDAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ARTICULO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TIENDA:";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(74, 238);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(92, 23);
            this.btnVender.TabIndex = 4;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // compra
            // 
            this.compra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.compra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.compra.Enabled = false;
            this.compra.Location = new System.Drawing.Point(57, 195);
            this.compra.Name = "compra";
            this.compra.Size = new System.Drawing.Size(121, 13);
            this.compra.TabIndex = 3;
            this.compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(91, 112);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(121, 20);
            this.cantidad.TabIndex = 2;
            // 
            // cbArticulo
            // 
            this.cbArticulo.FormattingEnabled = true;
            this.cbArticulo.Items.AddRange(new object[] {
            "Articulo 1",
            "Articulo 2",
            "Articulo 3",
            "Articulo 4"});
            this.cbArticulo.Location = new System.Drawing.Point(91, 78);
            this.cbArticulo.Name = "cbArticulo";
            this.cbArticulo.Size = new System.Drawing.Size(121, 21);
            this.cbArticulo.TabIndex = 1;
            // 
            // cbTienda
            // 
            this.cbTienda.FormattingEnabled = true;
            this.cbTienda.Items.AddRange(new object[] {
            "Tienda 1",
            "Tienda 2",
            "Tienda 3",
            "Tienda 4"});
            this.cbTienda.Location = new System.Drawing.Point(91, 42);
            this.cbTienda.Name = "cbTienda";
            this.cbTienda.Size = new System.Drawing.Size(121, 21);
            this.cbTienda.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtTienda4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTienda3);
            this.groupBox2.Controls.Add(this.txtTienda2);
            this.groupBox2.Controls.Add(this.txtTienda1);
            this.groupBox2.Location = new System.Drawing.Point(248, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 128);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ventas tienda";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Tienda 4:";
            // 
            // txtTienda4
            // 
            this.txtTienda4.Enabled = false;
            this.txtTienda4.Location = new System.Drawing.Point(87, 97);
            this.txtTienda4.Name = "txtTienda4";
            this.txtTienda4.Size = new System.Drawing.Size(121, 20);
            this.txtTienda4.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tienda 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tienda 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tienda 1:";
            // 
            // txtTienda3
            // 
            this.txtTienda3.Enabled = false;
            this.txtTienda3.Location = new System.Drawing.Point(87, 71);
            this.txtTienda3.Name = "txtTienda3";
            this.txtTienda3.Size = new System.Drawing.Size(121, 20);
            this.txtTienda3.TabIndex = 6;
            // 
            // txtTienda2
            // 
            this.txtTienda2.Enabled = false;
            this.txtTienda2.Location = new System.Drawing.Point(87, 45);
            this.txtTienda2.Name = "txtTienda2";
            this.txtTienda2.Size = new System.Drawing.Size(121, 20);
            this.txtTienda2.TabIndex = 5;
            // 
            // txtTienda1
            // 
            this.txtTienda1.AllowDrop = true;
            this.txtTienda1.Enabled = false;
            this.txtTienda1.Location = new System.Drawing.Point(87, 19);
            this.txtTienda1.Name = "txtTienda1";
            this.txtTienda1.Size = new System.Drawing.Size(121, 20);
            this.txtTienda1.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtArti4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtArti3);
            this.groupBox3.Controls.Add(this.txtArti2);
            this.groupBox3.Controls.Add(this.txtArti1);
            this.groupBox3.Location = new System.Drawing.Point(248, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 127);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ventas articulo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Articulo 4:";
            // 
            // txtArti4
            // 
            this.txtArti4.Enabled = false;
            this.txtArti4.Location = new System.Drawing.Point(87, 97);
            this.txtArti4.Name = "txtArti4";
            this.txtArti4.Size = new System.Drawing.Size(121, 20);
            this.txtArti4.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Articulo 3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Articulo 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Articulo 1:";
            // 
            // txtArti3
            // 
            this.txtArti3.Enabled = false;
            this.txtArti3.Location = new System.Drawing.Point(87, 71);
            this.txtArti3.Name = "txtArti3";
            this.txtArti3.Size = new System.Drawing.Size(121, 20);
            this.txtArti3.TabIndex = 9;
            // 
            // txtArti2
            // 
            this.txtArti2.Enabled = false;
            this.txtArti2.Location = new System.Drawing.Point(87, 45);
            this.txtArti2.Name = "txtArti2";
            this.txtArti2.Size = new System.Drawing.Size(121, 20);
            this.txtArti2.TabIndex = 8;
            // 
            // txtArti1
            // 
            this.txtArti1.Enabled = false;
            this.txtArti1.Location = new System.Drawing.Point(87, 19);
            this.txtArti1.Name = "txtArti1";
            this.txtArti1.Size = new System.Drawing.Size(121, 20);
            this.txtArti1.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Location = new System.Drawing.Point(248, 400);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(214, 83);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ventas totales";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Ventas totales:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(87, 38);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(207, 494);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.Text = "Limpiar";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TiendaDeportiva.Properties.Resources._84477864_concepto_horizontal_de_banner_de_equipo_deportivo_ilustración_plana_de_concepto_de_vector_horizontal_de2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(474, 529);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormTienda";
            this.Text = "Tiendas deportivas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox compra;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.ComboBox cbArticulo;
        private System.Windows.Forms.ComboBox cbTienda;
        private System.Windows.Forms.TextBox txtTienda3;
        private System.Windows.Forms.TextBox txtTienda2;
        private System.Windows.Forms.TextBox txtTienda1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtArti3;
        private System.Windows.Forms.TextBox txtArti2;
        private System.Windows.Forms.TextBox txtArti1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTienda4;
        private System.Windows.Forms.TextBox txtArti4;
        private System.Windows.Forms.Label label13;
    }
}

