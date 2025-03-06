using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snoopy.Context
{
    public class Conexion
    {
        private string connectionString = "Server=CORRALES;Database=PeanutsDB;User ID=AlumnnosUNINTER;Password=Uninter2025;Integrated Security=False;MultipleActiveResultSets=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos: " + ex.Message);
            }
        }
    }
}
