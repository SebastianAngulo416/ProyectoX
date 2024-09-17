using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormPrincipal : Form
    {
        Procedimientos proc = new Procedimientos();
        private Form login;
        private Inicio inicio;
        private Registro registro;
        private VerMenu platos;
        private Actualizar actualizar;
        private AgregarP agregar;
        private Eliminar eliminar;
        public FormPrincipal()
        {
            InitializeComponent();
        }
        void cerrarforma(object sender, FormClosedEventArgs e)
        {
            login = null;
            inicio = null;
            registro = null;
            platos = null;
            actualizar = null;
            agregar = null;
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login == null)
            {
                login = new Login();
                login.MdiParent = this;
                login.FormClosed += new FormClosedEventHandler(cerrarforma);
                login.Show();

            }
            else
            {
                login.Activate();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
           
                botoninicio.Enabled = false;
                botonVer.Enabled = false;
            
            
        }
        public void ActivarBotones()
        {
            botoninicio.Enabled = true;
            botonVer.Enabled = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botoninicio_Click(object sender, EventArgs e)
        {
            if (inicio == null)
            {
                inicio = new Inicio();
                inicio.MdiParent = this;
                inicio.Show();

            }
            else
            {
                inicio.Activate();
            }
        }

        private void verMenuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (platos == null)
            {
                platos = new VerMenu();
                platos.MdiParent = this;
                platos.Show();

            }
            else
            {
                platos.Activate();
            }
        }

        private void agregarNuevoPlatilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (agregar == null)
            {
                agregar = new AgregarP();
                agregar.MdiParent = this;
                agregar.Show();

            }
            else
            {
                agregar.Activate();
            }
        }

        private void actualizarPlatilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (actualizar == null)
            {
                actualizar = new Actualizar();
                actualizar.MdiParent = this;
                actualizar.Show();

            }
            else
            {
                actualizar.Activate();
            }
        }

        private void elimarPlatilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (eliminar == null)
            {
                eliminar = new Eliminar();
                eliminar.MdiParent = this;
                eliminar.Show();

            }
            else
            {
                eliminar.Activate();
            }
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (registro == null)
            {
                registro = new Registro();
                registro.MdiParent = this;
                registro.Show();

            }
            else
            {
                registro.Activate();
            }
        }
    }
}
