using Entidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Datos
{
    public class PacienteDatos
    {

        private Conexion conexion = new Conexion();

        //Metodo READ
        public DataTable LeerPacientes(string buscar = "")
        {
            DataTable tabla = new DataTable();
            string query = "SELECT id_paciente AS ID, nombre_paciente AS Nombre, apellido_paciente AS Apellido, telefono_paciente AS Teléfono, correo_paciente AS Correo, fecha_nacimiento_paciente AS [F. Nacimiento], notas_medicas_paciente AS [Notas Médicas] FROM tb_pacientes";

            if (!string.IsNullOrEmpty(buscar))
            {
                query += " WHERE apellido_paciente LIKE @buscar";
            }

            try
            {
                using (SqlConnection con = conexion.LeerConexion()) 
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (!string.IsNullOrEmpty(buscar))
                            cmd.Parameters.AddWithValue("@buscar", buscar + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw; 
            }
            return tabla;
        }

        //Metodo INSERT
        public void InsertarPaciente(Pacientes paciente)
        {
            string query = "INSERT INTO tb_pacientes (nombre_paciente, apellido_paciente, telefono_paciente, correo_paciente, fecha_nacimiento_paciente, notas_medicas_paciente) " +
                           "VALUES (@nombre, @apellido, @telefono, @correo, @fecha, @notas)";
            try
            {
                using (SqlConnection con = conexion.LeerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", paciente.nombre_paciente);
                        cmd.Parameters.AddWithValue("@apellido", paciente.apellido_paciente);
                        cmd.Parameters.AddWithValue("@telefono", paciente.telefono_paciente);
                        cmd.Parameters.AddWithValue("@correo", (object)paciente.correo_paciente ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@fecha", paciente.fecha_nacimiento_paciente);
                        cmd.Parameters.AddWithValue("@notas", (object)paciente.notas_medicas_paciente ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Metodo UPDATE
        public void ActualizarPaciente(Pacientes paciente)
        {
            string query = "UPDATE tb_pacientes SET nombre_paciente=@nombre, apellido_paciente=@apellido, telefono_paciente=@telefono, correo_paciente=@correo, fecha_nacimiento_paciente=@fecha, notas_medicas_paciente=@notas WHERE id_paciente=@id";

            try
            {
                using (SqlConnection con = conexion.LeerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", paciente.id_paciente);
                        cmd.Parameters.AddWithValue("@nombre", paciente.nombre_paciente);
                        cmd.Parameters.AddWithValue("@apellido", paciente.apellido_paciente);
                        cmd.Parameters.AddWithValue("@telefono", paciente.telefono_paciente);
                        cmd.Parameters.AddWithValue("@correo", (object)paciente.correo_paciente ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@fecha", paciente.fecha_nacimiento_paciente);
                        cmd.Parameters.AddWithValue("@notas", (object)paciente.notas_medicas_paciente ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw; 
            }
        }

        //Metodo DELETE
        public void EliminarPaciente(int id_paciente)
        {
            string query = "DELETE FROM tb_pacientes WHERE id_paciente = @id";
            try
            {
                using (SqlConnection con = conexion.LeerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id_paciente);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Metodos de busqueda
        public DataTable BuscarPacientesPorApellido(string apellido)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT id_paciente, nombre_paciente, apellido_paciente, " +
                           "telefono_paciente, correo_paciente, fecha_nacimiento_paciente, notas_medicas_paciente " +
                           "FROM tb_pacientes " +
                           "WHERE apellido_paciente LIKE @apellido";
            try
            {
                using (SqlConnection con = conexion.LeerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@apellido", "%" + apellido + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return tabla;
        }

        public DataTable ObtenerApellidos()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT DISTINCT apellido_paciente FROM tb_pacientes ORDER BY apellido_paciente ASC";

            try
            {
                using (SqlConnection con = conexion.LeerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return tabla;
        }
    }
}
