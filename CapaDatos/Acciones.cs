using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Web;
using System.Runtime.Remoting.Messaging;
using System.Configuration;
using CapaDatos;


namespace CapaDatos
{
    public class Acciones
    {
        private ConexionBD conexion = new ConexionBD();

        SqlCommand comandos = new SqlCommand();
        SqlDataReader leer;
        DataTable Tabla = new DataTable();


        public DataTable Mostrar()
        {
            try
            {
                comandos.Connection = conexion.Abrir();
                comandos.CommandText = "Select * From Platos";
                comandos.CommandType = CommandType.Text;
                leer = comandos.ExecuteReader();
                Tabla.Load(leer);
                conexion.Cerrar();
                return Tabla;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conexion.Cerrar();
            }

        }
        public DataTable Buscar(int id, string nombre)
        {
            try
            {
                comandos.Connection = conexion.Abrir();
                comandos.CommandText = "SELECT * FROM Platos WHERE (@Id IS NULL OR PlatoID = @Id) OR (@Nombre IS NULL OR Nombre = @Nombre)";
                comandos.CommandType = CommandType.Text;
                comandos.Parameters.AddWithValue("@Id", (object)id ?? DBNull.Value);
                comandos.Parameters.AddWithValue("@Nombre", (object)nombre ?? DBNull.Value);
                leer = comandos.ExecuteReader();
                Tabla.Load(leer);
                conexion.Cerrar();
                return Tabla;
            }
            catch(Exception)
            {
                return null;
            }
            finally
            {
                conexion.Cerrar();
            }
        }
        public void IngresarDatos1(string correo, string nombre, string contraseña)
        {
            try
            {
                comandos.Connection = conexion.Abrir();
                comandos.CommandText = "SP_IngresarDatosUser";
                comandos.CommandType = CommandType.StoredProcedure;
                comandos.Parameters.AddWithValue("@Correo", correo);
                comandos.Parameters.AddWithValue("@Nombre", nombre);
                comandos.Parameters.AddWithValue("@Contraseña", contraseña);
                comandos.ExecuteNonQuery();
                comandos.Parameters.Clear();
            }
            catch(Exception ex)
            {
                Console.WriteLine(" " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
            

        }
        public void IngresarDatos2(string nombre, string descripcion, decimal precio, string categoria)
        {
            try
            {
                comandos.Connection = conexion.Abrir();
                comandos.CommandText = "SP_AgregarPlato";
                comandos.CommandType = CommandType.StoredProcedure;
                comandos.Parameters.AddWithValue("@Nombre", nombre);
                comandos.Parameters.AddWithValue("@descripcion", descripcion);
                comandos.Parameters.AddWithValue("@precio", precio);
                comandos.Parameters.AddWithValue("@Categoria", categoria);
                comandos.ExecuteNonQuery();
                comandos.Parameters.Clear();
            }
            catch(Exception ex)
            {
                Console.WriteLine(" " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }

        }
        public void Actualizar(int id, string nombre, string descripcion, decimal precio, string categoria)
        {
            try
            {
                comandos.Connection = conexion.Abrir();
                comandos.CommandText = "SP_ActualizarPlato";
                comandos.CommandType = CommandType.StoredProcedure;

                comandos.Parameters.AddWithValue("@PlatoID", id);
                comandos.Parameters.AddWithValue("@nombre", nombre);
                comandos.Parameters.AddWithValue("@descripcion", descripcion);
                comandos.Parameters.AddWithValue("@precio", precio);
                comandos.Parameters.AddWithValue("@categoria", categoria);
                comandos.ExecuteNonQuery();
                comandos.Parameters.Clear();
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrio un Error");
            }
            finally
            {
                conexion.Cerrar();
            }
                
        }
        public void Eliminar(int id)
        {
            try
            {
                comandos.Connection = conexion.Abrir();
                comandos.CommandText = "SP_EliminarPlato";
                comandos.CommandType = CommandType.StoredProcedure;
                comandos.Parameters.AddWithValue("@ID", id);
                comandos.ExecuteNonQuery();
                comandos.Parameters.Clear();
            }
            catch
            {

            }
            finally
            {
                conexion.Cerrar();
            }
            
            

            //O

            //comandos.Connection = conexion.Abrir();
            //comandos.CommandText = "Delete Platos Where PlatoID = @id";
            //comandos.CommandType = CommandType.StoredProcedure;
            //comandos.Parameters.AddWithValue("@ID", id);
            //comandos.ExecuteNonQuery();
            //comandos.Parameters.Clear();
        }
        public string Validar(string nombre, string contraseña)
        {
            string resultado = "No se pudo";
            try
            {
                comandos.Parameters.Clear();
                comandos.Connection = conexion.Abrir();
                comandos.CommandText = "SP_VerificarIngreso";
                comandos.CommandType = CommandType.StoredProcedure;

                comandos.Parameters.AddWithValue("@Nombre", nombre);
                comandos.Parameters.AddWithValue("@Contraseña", contraseña);
                
                using (leer = comandos.ExecuteReader())
                {
                    if (leer.Read())
                    {
                        resultado = leer["Resultado"].ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                return $"Error: {ex.Message}";
            }
            finally
            {
                conexion.Cerrar();
            }
            return resultado;
        }



       
        
            
        



    }
}
