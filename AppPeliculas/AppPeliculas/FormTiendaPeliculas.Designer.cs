namespace AppPeliculas
{
    partial class FormTiendaPeliculas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonPelisAlquiladas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboPelicula = new System.Windows.Forms.ComboBox();
            this.buttonAlquilar = new System.Windows.Forms.Button();
            this.textDisponibles = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textGenero = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureImagen = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.btnCerrarSesion);
            this.groupBox2.Controls.Add(this.buttonPelisAlquiladas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(555, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 339);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // buttonPelisAlquiladas
            // 
            this.buttonPelisAlquiladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPelisAlquiladas.ForeColor = System.Drawing.Color.Black;
            this.buttonPelisAlquiladas.Location = new System.Drawing.Point(33, 39);
            this.buttonPelisAlquiladas.Name = "buttonPelisAlquiladas";
            this.buttonPelisAlquiladas.Size = new System.Drawing.Size(116, 45);
            this.buttonPelisAlquiladas.TabIndex = 1;
            this.buttonPelisAlquiladas.Text = "Mis peliculas alquiladas";
            this.buttonPelisAlquiladas.UseVisualStyleBackColor = true;
            this.buttonPelisAlquiladas.Click += new System.EventHandler(this.buttonPelisAlquiladas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.comboPelicula);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureImagen);
            this.groupBox1.Controls.Add(this.buttonAlquilar);
            this.groupBox1.Controls.Add(this.textDisponibles);
            this.groupBox1.Controls.Add(this.textPrecio);
            this.groupBox1.Controls.Add(this.textGenero);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(39, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 373);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peliculas";
            // 
            // comboPelicula
            // 
            this.comboPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPelicula.FormattingEnabled = true;
            this.comboPelicula.Location = new System.Drawing.Point(24, 20);
            this.comboPelicula.Name = "comboPelicula";
            this.comboPelicula.Size = new System.Drawing.Size(525, 23);
            this.comboPelicula.TabIndex = 14;
            this.comboPelicula.SelectedIndexChanged += new System.EventHandler(this.comboPelicula_SelectedIndexChanged);
            // 
            // buttonAlquilar
            // 
            this.buttonAlquilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlquilar.ForeColor = System.Drawing.Color.Black;
            this.buttonAlquilar.Location = new System.Drawing.Point(24, 322);
            this.buttonAlquilar.Name = "buttonAlquilar";
            this.buttonAlquilar.Size = new System.Drawing.Size(100, 31);
            this.buttonAlquilar.TabIndex = 10;
            this.buttonAlquilar.Text = "Alquilar";
            this.buttonAlquilar.UseVisualStyleBackColor = true;
            this.buttonAlquilar.Click += new System.EventHandler(this.buttonAlquilar_Click);
            // 
            // textDisponibles
            // 
            this.textDisponibles.Enabled = false;
            this.textDisponibles.Location = new System.Drawing.Point(132, 155);
            this.textDisponibles.Name = "textDisponibles";
            this.textDisponibles.ReadOnly = true;
            this.textDisponibles.Size = new System.Drawing.Size(216, 21);
            this.textDisponibles.TabIndex = 9;
            // 
            // textPrecio
            // 
            this.textPrecio.Enabled = false;
            this.textPrecio.Location = new System.Drawing.Point(132, 128);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.ReadOnly = true;
            this.textPrecio.Size = new System.Drawing.Size(216, 21);
            this.textPrecio.TabIndex = 8;
            // 
            // textGenero
            // 
            this.textGenero.Enabled = false;
            this.textGenero.Location = new System.Drawing.Point(132, 101);
            this.textGenero.Name = "textGenero";
            this.textGenero.ReadOnly = true;
            this.textGenero.Size = new System.Drawing.Size(216, 21);
            this.textGenero.TabIndex = 6;
            // 
            // textNombre
            // 
            this.textNombre.Enabled = false;
            this.textNombre.Location = new System.Drawing.Point(132, 74);
            this.textNombre.Name = "textNombre";
            this.textNombre.ReadOnly = true;
            this.textNombre.Size = new System.Drawing.Size(216, 21);
            this.textNombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 155);
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
            this.label3.Location = new System.Drawing.Point(21, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Genero:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Bienvenido: ";
            // 
            // lblNombreUser
            // 
            this.lblNombreUser.AutoSize = true;
            this.lblNombreUser.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreUser.Location = new System.Drawing.Point(128, 145);
            this.lblNombreUser.Name = "lblNombreUser";
            this.lblNombreUser.Size = new System.Drawing.Size(0, 15);
            this.lblNombreUser.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppPeliculas.Properties.Resources.banner_peliculas;
            this.pictureBox1.Location = new System.Drawing.Point(39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureImagen
            // 
            this.pictureImagen.Location = new System.Drawing.Point(354, 74);
            this.pictureImagen.Name = "pictureImagen";
            this.pictureImagen.Size = new System.Drawing.Size(195, 279);
            this.pictureImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureImagen.TabIndex = 11;
            this.pictureImagen.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.Location = new System.Drawing.Point(33, 273);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(116, 45);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // FormTiendaPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(824, 561);
            this.Controls.Add(this.lblNombreUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTiendaPeliculas";
            this.Text = "Alquiler de peliculas";
            this.Load += new System.EventHandler(this.FormTiendaPeliculas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonPelisAlquiladas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboPelicula;
        private System.Windows.Forms.PictureBox pictureImagen;
        private System.Windows.Forms.Button buttonAlquilar;
        private System.Windows.Forms.TextBox textDisponibles;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textGenero;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreUser;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}

