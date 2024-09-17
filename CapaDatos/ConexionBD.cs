using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConexionBD
    {
        SqlConnection ConexionABD = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString);

        public SqlConnection Abrir()
        {
            if (ConexionABD.State == ConnectionState.Closed)
            {
                ConexionABD.Open();
            }
            return ConexionABD;
        }
        public SqlConnection Cerrar()
        {
            if (ConexionABD.State == ConnectionState.Open)
            {
                ConexionABD.Close();
            }
            return ConexionABD;
        }
        public ConexionBD() { }
    }
}
