using CapaNegocio;
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

namespace CapaPresentacion
{
    public partial class VerMenu : Form
    {
        Procedimientos proc = new Procedimientos();
        private Actualizar actualizar;
        private Eliminar eliminar;
        private Inicio inicio;
        public VerMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TablaDatos.DataSource = proc.LeerDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (actualizar == null)
            {
                actualizar = new Actualizar();
                actualizar.MdiParent = this.MdiParent;
                actualizar.Show();
            }
            else
            {
                actualizar.Activate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (eliminar == null)
            {
                eliminar = new Eliminar();
                eliminar.MdiParent = this.MdiParent;
                eliminar.Show();
            }
            else
            {
                eliminar.Activate();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (inicio == null)
            {
                inicio = new Inicio();
                inicio.MdiParent = this.MdiParent;
                inicio.Show();
            }
            else
            {
                inicio.Activate();
            }
        }

        private void VerMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
