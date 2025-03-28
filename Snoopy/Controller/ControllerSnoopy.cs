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


        // CREATE - Insertar un nuevo personaje
        public void InsertarPersonaje(SnoopyModel personaje)
        {
            using (SqlConnection conn = conexion.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO Personajes (Nombre, Apodo, Raza, Dueño, Personalidad, PrimeraAparicion, ImagenURL)
                                     VALUES (@Nombre, @Apodo, @Raza, @Dueño, @Personalidad, @PrimeraAparicion, @ImagenURL)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", personaje.Nombre ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Apodo", personaje.Apodo ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Raza", personaje.Raza ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Dueño", personaje.Dueño ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Personalidad", personaje.Personalidad ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PrimeraAparicion", personaje.PrimeraAparicion ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ImagenURL", personaje.ImagenURL ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar el personaje: " + ex.Message);
                }
            }
        }

        // UPDATE - Modificar un personaje existente
        public void ActualizarPersonaje(SnoopyModel personaje)
        {
            using (SqlConnection conn = conexion.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE Personajes 
                                     SET Nombre = @Nombre, Apodo = @Apodo, Raza = @Raza, Dueño = @Dueño, 
                                         Personalidad = @Personalidad, PrimeraAparicion = @PrimeraAparicion, ImagenURL = @ImagenURL
                                     WHERE ID = @ID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", personaje.ID);
                    cmd.Parameters.AddWithValue("@Nombre", personaje.Nombre ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Apodo", personaje.Apodo ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Raza", personaje.Raza ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Dueño", personaje.Dueño ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Personalidad", personaje.Personalidad ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PrimeraAparicion", personaje.PrimeraAparicion ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ImagenURL", personaje.ImagenURL ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el personaje: " + ex.Message);
                }
            }
        }

        // DELETE - Eliminar un personaje por ID
        public void EliminarPersonaje(int id)
        {
            using (SqlConnection conn = conexion.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Personajes WHERE ID = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar el personaje: " + ex.Message);
                }
            }
        }
    }
}

