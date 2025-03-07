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
                                ID = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : 0, // Si es null, asigna 0
                                Nombre = reader["Nombre"] != DBNull.Value ? reader["Nombre"].ToString() : null,
                                Apodo = reader["Apodo"] != DBNull.Value ? reader["Apodo"].ToString() : null,
                                Raza = reader["Raza"] != DBNull.Value ? reader["Raza"].ToString() : null,
                                Dueño = reader["Dueño"] != DBNull.Value ? reader["Dueño"].ToString() : null,
                                Personalidad = reader["Personalidad"] != DBNull.Value ? reader["Personalidad"].ToString() : null,
                                PrimeraAparicion = reader["PrimeraAparicion"] != DBNull.Value ? Convert.ToDateTime(reader["PrimeraAparicion"]) : (DateTime?)null,
                                ImagenURL = reader["ImagenURL"] != DBNull.Value ? reader["ImagenURL"].ToString() : null

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
