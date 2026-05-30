using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        private readonly string cadenaConexion = "Server=.;Database=SCO;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection LeerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                return conexion;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
