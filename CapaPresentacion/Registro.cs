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
    public partial class Registro : Form
    {
        Procedimientos proc = new Procedimientos();
        public Registro()
        {
            InitializeComponent();
        }

        private void Ingreso_Click(object sender, EventArgs e)
        {
            Procedimientos proc = new Procedimientos();
            string nombre = nombrer.Text;
            string correo = correotext.Text;
            string contraseña = ContraseñaText.Text;
            try
            {
                proc.InsertarDatos1(correo, nombre, contraseña);
                MessageBox.Show("Se ha ingresado con exito a la base de datos");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un Error" + ex.Message);
            }
            nombrer.Clear();
            correotext.Clear();
            ContraseñaText.Clear();

           
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
