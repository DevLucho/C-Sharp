namespace TiendaDeVideoJuegos
{
    partial class FormTiendaVideojugos
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
            this.comboJuego = new System.Windows.Forms.ComboBox();
            this.buttonVender = new System.Windows.Forms.Button();
            this.pictureImagen = new System.Windows.Forms.PictureBox();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.textDisponibles = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textTamaño = new System.Windows.Forms.TextBox();
            this.textCategoria = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonFinalizarV = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonJuegosVendidos = new System.Windows.Forms.Button();
            this.buttonBuscarJ = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.comboJuego);
            this.groupBox1.Controls.Add(this.buttonVender);
            this.groupBox1.Controls.Add(this.pictureImagen);
            this.groupBox1.Controls.Add(this.buttonComprar);
            this.groupBox1.Controls.Add(this.textDisponibles);
            this.groupBox1.Controls.Add(this.textPrecio);
            this.groupBox1.Controls.Add(this.textTamaño);
            this.groupBox1.Controls.Add(this.textCategoria);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(50, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 382);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Juegos";
            // 
            // comboJuego
            // 
            this.comboJuego.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboJuego.FormattingEnabled = true;
            this.comboJuego.Location = new System.Drawing.Point(24, 20);
            this.comboJuego.Name = "comboJuego";
            this.comboJuego.Size = new System.Drawing.Size(464, 23);
            this.comboJuego.TabIndex = 14;
            this.comboJuego.SelectedIndexChanged += new System.EventHandler(this.comboJuego_SelectedIndexChanged_1);
            // 
            // buttonVender
            // 
            this.buttonVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVender.ForeColor = System.Drawing.Color.Black;
            this.buttonVender.Location = new System.Drawing.Point(162, 263);
            this.buttonVender.Name = "buttonVender";
            this.buttonVender.Size = new System.Drawing.Size(100, 31);
            this.buttonVender.TabIndex = 12;
            this.buttonVender.Text = "Vender";
            this.buttonVender.UseVisualStyleBackColor = true;
            this.buttonVender.Click += new System.EventHandler(this.buttonVender_Click);
            // 
            // pictureImagen
            // 
            this.pictureImagen.Location = new System.Drawing.Point(293, 74);
            this.pictureImagen.Name = "pictureImagen";
            this.pictureImagen.Size = new System.Drawing.Size(195, 279);
            this.pictureImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureImagen.TabIndex = 11;
            this.pictureImagen.TabStop = false;
            this.pictureImagen.Click += new System.EventHandler(this.pictureImagen_Click);
            // 
            // buttonComprar
            // 
            this.buttonComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComprar.ForeColor = System.Drawing.Color.Black;
            this.buttonComprar.Location = new System.Drawing.Point(24, 263);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(100, 31);
            this.buttonComprar.TabIndex = 10;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // textDisponibles
            // 
            this.textDisponibles.Enabled = false;
            this.textDisponibles.Location = new System.Drawing.Point(132, 182);
            this.textDisponibles.Name = "textDisponibles";
            this.textDisponibles.ReadOnly = true;
            this.textDisponibles.Size = new System.Drawing.Size(141, 21);
            this.textDisponibles.TabIndex = 9;
            // 
            // textPrecio
            // 
            this.textPrecio.Enabled = false;
            this.textPrecio.Location = new System.Drawing.Point(132, 155);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.ReadOnly = true;
            this.textPrecio.Size = new System.Drawing.Size(141, 21);
            this.textPrecio.TabIndex = 8;
            // 
            // textTamaño
            // 
            this.textTamaño.Enabled = false;
            this.textTamaño.Location = new System.Drawing.Point(132, 128);
            this.textTamaño.Name = "textTamaño";
            this.textTamaño.ReadOnly = true;
            this.textTamaño.Size = new System.Drawing.Size(141, 21);
            this.textTamaño.TabIndex = 7;
            // 
            // textCategoria
            // 
            this.textCategoria.Enabled = false;
            this.textCategoria.Location = new System.Drawing.Point(132, 101);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.ReadOnly = true;
            this.textCategoria.Size = new System.Drawing.Size(141, 21);
            this.textCategoria.TabIndex = 6;
            // 
            // textNombre
            // 
            this.textNombre.Enabled = false;
            this.textNombre.Location = new System.Drawing.Point(132, 74);
            this.textNombre.Name = "textNombre";
            this.textNombre.ReadOnly = true;
            this.textNombre.Size = new System.Drawing.Size(141, 21);
            this.textNombre.TabIndex = 5;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Disponibles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tamaño en KB:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Black;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(21, 74);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(62, 15);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            // 
            // buttonFinalizarV
            // 
            this.buttonFinalizarV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalizarV.Location = new System.Drawing.Point(591, 529);
            this.buttonFinalizarV.Name = "buttonFinalizarV";
            this.buttonFinalizarV.Size = new System.Drawing.Size(182, 41);
            this.buttonFinalizarV.TabIndex = 15;
            this.buttonFinalizarV.Text = "Finalizar venta";
            this.buttonFinalizarV.UseVisualStyleBackColor = true;
            this.buttonFinalizarV.Click += new System.EventHandler(this.buttonFinalizarV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TiendaDeportiva.Properties.Resources.BANNER_VIDEO_JUEGOS;
            this.pictureBox1.Location = new System.Drawing.Point(50, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.buttonJuegosVendidos);
            this.groupBox2.Controls.Add(this.buttonBuscarJ);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(591, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 315);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // buttonJuegosVendidos
            // 
            this.buttonJuegosVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJuegosVendidos.ForeColor = System.Drawing.Color.Black;
            this.buttonJuegosVendidos.Location = new System.Drawing.Point(36, 135);
            this.buttonJuegosVendidos.Name = "buttonJuegosVendidos";
            this.buttonJuegosVendidos.Size = new System.Drawing.Size(113, 45);
            this.buttonJuegosVendidos.TabIndex = 1;
            this.buttonJuegosVendidos.Text = "Juegos Mas Vendidos";
            this.buttonJuegosVendidos.UseVisualStyleBackColor = true;
            this.buttonJuegosVendidos.Click += new System.EventHandler(this.buttonJuegosVendidos_Click);
            // 
            // buttonBuscarJ
            // 
            this.buttonBuscarJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarJ.ForeColor = System.Drawing.Color.Black;
            this.buttonBuscarJ.Location = new System.Drawing.Point(36, 50);
            this.buttonBuscarJ.Name = "buttonBuscarJ";
            this.buttonBuscarJ.Size = new System.Drawing.Size(113, 44);
            this.buttonBuscarJ.TabIndex = 0;
            this.buttonBuscarJ.Text = "Buscar Juego";
            this.buttonBuscarJ.UseVisualStyleBackColor = true;
            this.buttonBuscarJ.Click += new System.EventHandler(this.buttonBuscarJ_Click);
            // 
            // FormTiendaVideojugos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(831, 602);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonFinalizarV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTiendaVideojugos";
            this.Text = "Tienda de videojuegos";
            this.Load += new System.EventHandler(this.FormTiendaVideojugos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNombre;
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureImagen;
        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.TextBox textDisponibles;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textTamaño;
        private System.Windows.Forms.TextBox textCategoria;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonVender;
        private System.Windows.Forms.ComboBox comboJuego;
        private System.Windows.Forms.Button buttonFinalizarV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonJuegosVendidos;
        private System.Windows.Forms.Button buttonBuscarJ;
    }
}

