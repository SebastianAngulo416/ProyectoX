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
    public partial class Actualizar : Form
    {
        Procedimientos proc = new Procedimientos();
        private VerMenu menu;
        public Actualizar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            string nombre = txtanombre.Text;
            string descripcion = txtadescripcion.Text;
            decimal precio;
            string categoria = bxacategoria.Text;
            if (string.IsNullOrEmpty(txtidp.Text) || string.IsNullOrEmpty(txtanombre.Text) ||
            string.IsNullOrEmpty(txtadescripcion.Text) || string.IsNullOrEmpty(txtaprecio.Text) ||
            string.IsNullOrEmpty(bxacategoria.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos.");
                return;
            }
            try
            {
                if (!int.TryParse(txtidp.Text, out id))
                {
                    MessageBox.Show("El ID no es válido. Por favor, ingrese un número entero");
                    return;
                }

                if (!decimal.TryParse(txtaprecio.Text, out precio))
                {
                    MessageBox.Show("El precio no es válido");
                    return;
                }
                proc.Actualizar(id, nombre, descripcion, precio, categoria);
                MessageBox.Show("Se ha actualizado el platillo Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha Ocurrido un Error" + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (menu == null)
            {

                menu = new VerMenu();
                menu.MdiParent = this.MdiParent;
                menu.Show();
                this.Close();

            }
            else
            {
                menu.Activate();
            }
        }
    }
}
