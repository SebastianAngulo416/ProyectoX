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
    public partial class Login : Form
    {
        Procedimientos proc = new Procedimientos();
        private Form login;
        private Inicio inicio;
        private Registro registro;
        //private VerMenu platos;
        //private Actualizar actualizar;
        //private AgregarPlato agregar;
        //private Buscador buscador;
        public Login()
        {
            InitializeComponent();
        }

        private void Ingreso_Click(object sender, EventArgs e)
        {
            string nombre = nombretxt.Text;
            string contraseña = contraseñatxt.Text;
            
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("No ha ingresado ningun parametro");
                return;
            }
            try
            {
                string resultado = proc.ValidarEntrada(nombre, contraseña);
                if (resultado == "AccesoPermitido")
                {
                    if (inicio == null)
                    {
                        MessageBox.Show("¡Bienvenido! Inicio de Sesion Exitoso");
                        var parentForm = (FormPrincipal)this.MdiParent;
                        parentForm.ActivarBotones();
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
                else if (resultado == "DatosIncorrectos")
                {
                    MessageBox.Show("Nombre o contraseña incorrectos");
                }
                else if (resultado == "CuentaNoExiste")
                {
                    MessageBox.Show("La cuenta ingresada no existe");
                }
                else
                {
                    MessageBox.Show("Hubo un Error durante la verificación");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha podido conectar a la base de datos por el error: "+ ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (registro == null)
            {
                registro = new Registro();
                registro.MdiParent = this.MdiParent;
                registro.Show();
            }
            else
            {
                registro.Activate();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
