namespace AppPeliculas
{
    partial class FormPeliculasAlquiladas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovedad = new System.Windows.Forms.Button();
            this.listPelis = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(113, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pelicula            |             Genero             |            Anotaciones";
            // 
            // btnNovedad
            // 
            this.btnNovedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNovedad.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovedad.Location = new System.Drawing.Point(659, 73);
            this.btnNovedad.Name = "btnNovedad";
            this.btnNovedad.Size = new System.Drawing.Size(129, 44);
            this.btnNovedad.TabIndex = 6;
            this.btnNovedad.Text = "✖️ Generar novedad";
            this.btnNovedad.UseVisualStyleBackColor = false;
            this.btnNovedad.Click += new System.EventHandler(this.btnNovedad_Click);
            // 
            // listPelis
            // 
            this.listPelis.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPelis.FormattingEnabled = true;
            this.listPelis.ItemHeight = 19;
            this.listPelis.Location = new System.Drawing.Point(31, 73);
            this.listPelis.Name = "listPelis";
            this.listPelis.Size = new System.Drawing.Size(622, 327);
            this.listPelis.TabIndex = 5;
            this.listPelis.SelectedIndexChanged += new System.EventHandler(this.listPelis_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mis peliculas alquiladas";
            // 
            // FormPeliculasAlquiladas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppPeliculas.Properties.Resources.img_pelis;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNovedad);
            this.Controls.Add(this.listPelis);
            this.Name = "FormPeliculasAlquiladas";
            this.Text = "Mis pelicula alquiladas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNovedad;
        private System.Windows.Forms.ListBox listPelis;
        private System.Windows.Forms.Label label1;
    }
}