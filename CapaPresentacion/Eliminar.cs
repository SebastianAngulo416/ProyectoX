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
    public partial class Eliminar : Form
    {
        Procedimientos proc = new Procedimientos();
        private VerMenu menu;
        public Eliminar()
        {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
               
                if (!int.TryParse(txtid.Text, out id))
                {
                    MessageBox.Show("El ID no es válido. Por favor, ingrese un número entero");
                    return;
                }
                
                proc.Eliminar(id);
                MessageBox.Show("Se ha eliminado Correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha Ocurrido un Error" + ex.Message);
            }
            
            
        }
    }
}
