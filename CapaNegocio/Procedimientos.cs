using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Procedimientos
    {
        private Acciones acciones = new Acciones();
        public DataTable LeerDatos()
        {
            DataTable tabla = new DataTable();
            tabla = acciones.Mostrar();
            return tabla;
        }
        public DataTable buscarDatos(int id, string nombre)
        {
            DataTable table = new DataTable();
            table = acciones.Buscar(id, nombre);
            return table;
        }
        public void InsertarDatos1(string correo, string nombre, string contraseña)
        {
            acciones.IngresarDatos1(correo, nombre, contraseña);
        }
        public void InsertarDatos2(string nombre, string descripcion, decimal precio, string categoria)
        {
            acciones.IngresarDatos2(nombre, descripcion, precio, categoria);
        }
        public void Actualizar(int id, string nombre, string descripcion, decimal precio, string categoria)
        {
            acciones.Actualizar(id, nombre, descripcion, precio, categoria);
        }
        public void Eliminar(int id)
        {
            acciones.Eliminar(id);
        }
        public string ValidarEntrada(string nombre, string contraseña)
        {
            return acciones.Validar(nombre, contraseña);
        }

        public Procedimientos()
        {

        }
       
    }
}
