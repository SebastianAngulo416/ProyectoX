namespace CapaPresentacion
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botoninicio = new System.Windows.Forms.ToolStripMenuItem();
            this.botonVer = new System.Windows.Forms.ToolStripMenuItem();
            this.verMenuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoPlatilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarPlatilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elimarPlatilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem,
            this.botoninicio,
            this.botonVer,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 37);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.registroToolStripMenuItem});
            this.entradaToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(76, 33);
            this.entradaToolStripMenuItem.Text = "Entrar";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // botoninicio
            // 
            this.botoninicio.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoninicio.Name = "botoninicio";
            this.botoninicio.Size = new System.Drawing.Size(68, 33);
            this.botoninicio.Text = "Inicio";
            this.botoninicio.Click += new System.EventHandler(this.botoninicio_Click);
            // 
            // botonVer
            // 
            this.botonVer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verMenuToolStripMenuItem1});
            this.botonVer.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVer.Name = "botonVer";
            this.botonVer.Size = new System.Drawing.Size(50, 33);
            this.botonVer.Text = "Ver";
            // 
            // verMenuToolStripMenuItem1
            // 
            this.verMenuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoPlatilloToolStripMenuItem,
            this.actualizarPlatilloToolStripMenuItem,
            this.elimarPlatilloToolStripMenuItem});
            this.verMenuToolStripMenuItem1.Name = "verMenuToolStripMenuItem1";
            this.verMenuToolStripMenuItem1.Size = new System.Drawing.Size(158, 34);
            this.verMenuToolStripMenuItem1.Text = "Ver Menu";
            this.verMenuToolStripMenuItem1.Click += new System.EventHandler(this.verMenuToolStripMenuItem1_Click);
            // 
            // agregarNuevoPlatilloToolStripMenuItem
            // 
            this.agregarNuevoPlatilloToolStripMenuItem.Name = "agregarNuevoPlatilloToolStripMenuItem";
            this.agregarNuevoPlatilloToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.agregarNuevoPlatilloToolStripMenuItem.Text = "Agregar Nuevo Platillo";
            this.agregarNuevoPlatilloToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoPlatilloToolStripMenuItem_Click);
            // 
            // actualizarPlatilloToolStripMenuItem
            // 
            this.actualizarPlatilloToolStripMenuItem.Name = "actualizarPlatilloToolStripMenuItem";
            this.actualizarPlatilloToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.actualizarPlatilloToolStripMenuItem.Text = "Actualizar Platillo";
            this.actualizarPlatilloToolStripMenuItem.Click += new System.EventHandler(this.actualizarPlatilloToolStripMenuItem_Click);
            // 
            // elimarPlatilloToolStripMenuItem
            // 
            this.elimarPlatilloToolStripMenuItem.Name = "elimarPlatilloToolStripMenuItem";
            this.elimarPlatilloToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.elimarPlatilloToolStripMenuItem.Text = "Elimar Platillo";
            this.elimarPlatilloToolStripMenuItem.Click += new System.EventHandler(this.elimarPlatilloToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(64, 33);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.registroToolStripMenuItem.Text = "Registro";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(845, 560);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem botoninicio;
        private System.Windows.Forms.ToolStripMenuItem botonVer;
        private System.Windows.Forms.ToolStripMenuItem verMenuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoPlatilloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarPlatilloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elimarPlatilloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
    }
}

