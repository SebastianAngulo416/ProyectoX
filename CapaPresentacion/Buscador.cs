using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class Buscador : Form
    {
        Procedimientos proc = new Procedimientos();
        private Inicio inicio;
        public Buscador()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int id;
            string nombre = txtnombre.Text; 
            if (!int.TryParse(txtid.Text, out id))
            {
                MessageBox.Show("El ID no es válido. Por favor, ingrese un número entero");
                return; 
            }
            Busqueda.DataSource = proc.buscarDatos(id, nombre);
            txtid.Clear();
            txtnombre.Clear();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (inicio == null)
            {

                inicio = new Inicio();
                inicio.MdiParent = this.MdiParent;
                inicio.Show();
                this.Close();

            }
            else
            {
                inicio.Activate();
            }
        }
    }
}
