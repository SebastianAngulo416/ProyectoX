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

namespace CapaPresentacion
{
    public partial class AgregarP : Form
    {
        Procedimientos proc = new Procedimientos();
        public AgregarP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Procedimientos proc = new Procedimientos();
            string nombre = nombreptxt.Text;
            string descripcion = descripcionptxt.Text;
            decimal precio = decimal.Parse(preciotxt.Text);
            string categoria = categoriabx.Text;
            try
            {
                proc.InsertarDatos2(nombre, descripcion, precio, categoria);
                MessageBox.Show("Se ha ingresado con exito a la base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un Error" + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
