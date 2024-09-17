namespace CapaPresentacion
{
    partial class Buscador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscador));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.nombretxt = new System.Windows.Forms.Label();
            this.Busqueda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Busqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(15, 406);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 25);
            this.linkLabel1.TabIndex = 72;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Salir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Location = new System.Drawing.Point(521, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 77);
            this.label3.TabIndex = 71;
            this.label3.Text = "RestaurantX";
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.ForeColor = System.Drawing.Color.Gold;
            this.Logo.Location = new System.Drawing.Point(7, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(98, 76);
            this.Logo.TabIndex = 70;
            this.Logo.Text = "RX";
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.LightGreen;
            this.linkLabel2.Location = new System.Drawing.Point(716, 22);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(67, 25);
            this.linkLabel2.TabIndex = 69;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "↩️ Volver";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Chocolate;
            this.button2.Location = new System.Drawing.Point(353, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 36);
            this.button2.TabIndex = 68;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(307, 175);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(316, 20);
            this.txtnombre.TabIndex = 67;
            // 
            // nombretxt
            // 
            this.nombretxt.AutoSize = true;
            this.nombretxt.BackColor = System.Drawing.Color.Transparent;
            this.nombretxt.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombretxt.ForeColor = System.Drawing.Color.LawnGreen;
            this.nombretxt.Location = new System.Drawing.Point(183, 170);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(118, 25);
            this.nombretxt.TabIndex = 66;
            this.nombretxt.Text = "Nombre del Plato:";
            // 
            // Busqueda
            // 
            this.Busqueda.BackgroundColor = System.Drawing.Color.Tan;
            this.Busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Busqueda.Location = new System.Drawing.Point(143, 219);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(556, 92);
            this.Busqueda.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(300, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 77);
            this.label1.TabIndex = 64;
            this.label1.Text = "Buscar Plato";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(307, 141);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(316, 20);
            this.txtid.TabIndex = 74;
            // 
            // idtxt
            // 
            this.idtxt.AutoSize = true;
            this.idtxt.BackColor = System.Drawing.Color.Transparent;
            this.idtxt.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.idtxt.Location = new System.Drawing.Point(219, 136);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(82, 25);
            this.idtxt.TabIndex = 73;
            this.idtxt.Text = "Id del Plato:";
            // 
            // Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.label1);
            this.Name = "Buscador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador";
            ((System.ComponentModel.ISupportInitialize)(this.Busqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label nombretxt;
        private System.Windows.Forms.DataGridView Busqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label idtxt;
    }
}