using Microsoft.Data.SqlClient;
using Snoopy.Context;
using Snoopy.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snoopy.Controller
{
    internal class ControllerSnoopy : IControllerSnoopy
    {
        private Conexion conexion = new Conexion();

        public List<SnoopyModel> ObtenerPersonajes()
        {
            List<SnoopyModel> personajes = new List<SnoopyModel>();

            using (SqlConnection conn = conexion.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetPersonajes", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            personajes.Add(new SnoopyModel
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apodo = reader["Apodo"].ToString(),
                                Raza = reader["Raza"].ToString(),
                                Dueño = reader["Dueño"].ToString(),
                                Personalidad = reader["Personalidad"].ToString(),
                                PrimeraAparicion = Convert.ToDateTime(reader["PrimeraAparicion"]),
                                ImagenURL = reader["ImagenURL"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los personajes: " + ex.Message);
                }
            }

            return personajes;
        }
    }
}
