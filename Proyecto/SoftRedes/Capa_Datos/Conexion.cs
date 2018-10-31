using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Capa_Datos
{
    public class Conexion
    {
        const string CadenaConexion = "Data Source=PC-MIG;Initial Catalog=SoftRed;Integrated Security=True";
        private static readonly SqlConnection conexion = new SqlConnection(CadenaConexion);
        public static SqlConnection AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return conexion;
        }
        public static void CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}