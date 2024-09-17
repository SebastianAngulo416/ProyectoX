namespace CapaPresentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.contraseñatxt = new System.Windows.Forms.TextBox();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Text2 = new System.Windows.Forms.Label();
            this.Text1 = new System.Windows.Forms.Label();
            this.Ingreso = new System.Windows.Forms.Button();
            this.TituloA = new System.Windows.Forms.Label();
            this.TituloB = new System.Windows.Forms.Label();
            this.TituloR = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.contraseñatxt);
            this.panel1.Controls.Add(this.nombretxt);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.Text2);
            this.panel1.Controls.Add(this.Text1);
            this.panel1.Controls.Add(this.Ingreso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(393, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 450);
            this.panel1.TabIndex = 31;
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.ForeColor = System.Drawing.Color.Gold;
            this.Logo.Location = new System.Drawing.Point(178, 29);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(98, 76);
            this.Logo.TabIndex = 25;
            this.Logo.Text = "RX";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(355, 416);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(40, 25);
            this.linkLabel2.TabIndex = 22;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Salir";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(149, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 42);
            this.label1.TabIndex = 20;
            this.label1.Text = "Iniciar Sesion";
            // 
            // contraseñatxt
            // 
            this.contraseñatxt.Location = new System.Drawing.Point(140, 232);
            this.contraseñatxt.Name = "contraseñatxt";
            this.contraseñatxt.PasswordChar = '*';
            this.contraseñatxt.Size = new System.Drawing.Size(197, 20);
            this.contraseñatxt.TabIndex = 19;
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(140, 191);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(197, 20);
            this.nombretxt.TabIndex = 18;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(194, 321);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 25);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Registrarse";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text2.Location = new System.Drawing.Point(61, 227);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(83, 25);
            this.Text2.TabIndex = 16;
            this.Text2.Text = "Contraseña:";
            this.Text2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(14, 186);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(130, 25);
            this.Text1.TabIndex = 15;
            this.Text1.Text = "Nombre de Usuario:";
            this.Text1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Ingreso
            // 
            this.Ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ingreso.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingreso.ForeColor = System.Drawing.Color.Red;
            this.Ingreso.Location = new System.Drawing.Point(168, 276);
            this.Ingreso.Name = "Ingreso";
            this.Ingreso.Size = new System.Drawing.Size(130, 42);
            this.Ingreso.TabIndex = 14;
            this.Ingreso.Text = "Ingresar";
            this.Ingreso.UseVisualStyleBackColor = true;
            this.Ingreso.Click += new System.EventHandler(this.Ingreso_Click);
            // 
            // TituloA
            // 
            this.TituloA.AutoSize = true;
            this.TituloA.BackColor = System.Drawing.Color.Transparent;
            this.TituloA.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloA.ForeColor = System.Drawing.Color.Cyan;
            this.TituloA.Location = new System.Drawing.Point(176, 186);
            this.TituloA.Name = "TituloA";
            this.TituloA.Size = new System.Drawing.Size(42, 58);
            this.TituloA.TabIndex = 30;
            this.TituloA.Text = "A";
            // 
            // TituloB
            // 
            this.TituloB.AutoSize = true;
            this.TituloB.BackColor = System.Drawing.Color.Transparent;
            this.TituloB.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloB.ForeColor = System.Drawing.Color.White;
            this.TituloB.Location = new System.Drawing.Point(65, 70);
            this.TituloB.Name = "TituloB";
            this.TituloB.Size = new System.Drawing.Size(262, 77);
            this.TituloB.TabIndex = 29;
            this.TituloB.Text = "¡Bienvenido!";
            // 
            // TituloR
            // 
            this.TituloR.AutoSize = true;
            this.TituloR.BackColor = System.Drawing.Color.Transparent;
            this.TituloR.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloR.ForeColor = System.Drawing.Color.Gold;
            this.TituloR.Location = new System.Drawing.Point(65, 285);
            this.TituloR.Name = "TituloR";
            this.TituloR.Size = new System.Drawing.Size(273, 77);
            this.TituloR.TabIndex = 28;
            this.TituloR.Text = "RestaurantX";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TituloA);
            this.Controls.Add(this.TituloB);
            this.Controls.Add(this.TituloR);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contraseñatxt;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Button Ingreso;
        private System.Windows.Forms.Label TituloA;
        private System.Windows.Forms.Label TituloB;
        private System.Windows.Forms.Label TituloR;
    }
}