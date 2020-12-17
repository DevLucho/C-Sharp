namespace TiendaDeportiva
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolComparendos = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTiendas = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolJuegos = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolComparendos,
            this.ToolTiendas,
            this.ToolJuegos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ToolComparendos
            // 
            this.ToolComparendos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolComparendos.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolComparendos.ForeColor = System.Drawing.Color.Snow;
            this.ToolComparendos.Name = "ToolComparendos";
            this.ToolComparendos.Size = new System.Drawing.Size(165, 25);
            this.ToolComparendos.Text = "Form Comparendos";
            this.ToolComparendos.Click += new System.EventHandler(this.ToolComparendos_Click);
            // 
            // ToolTiendas
            // 
            this.ToolTiendas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolTiendas.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolTiendas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToolTiendas.Name = "ToolTiendas";
            this.ToolTiendas.Size = new System.Drawing.Size(207, 25);
            this.ToolTiendas.Text = "Form Tiendas Deportivas";
            this.ToolTiendas.Click += new System.EventHandler(this.ToolTiendas_Click);
            // 
            // ToolJuegos
            // 
            this.ToolJuegos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolJuegos.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolJuegos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolJuegos.Name = "ToolJuegos";
            this.ToolJuegos.Size = new System.Drawing.Size(181, 25);
            this.ToolJuegos.Text = "Form Venta de juegos";
            this.ToolJuegos.Click += new System.EventHandler(this.ToolJuegos_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Formularios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolComparendos;
        private System.Windows.Forms.ToolStripMenuItem ToolTiendas;
        private System.Windows.Forms.ToolStripMenuItem ToolJuegos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}