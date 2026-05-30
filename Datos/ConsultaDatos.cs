using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using Entidad;


namespace Datos
{
    public class ConsultaDatos
    {
        private Conexion conexion = new Conexion();

        //Metodo READ
        public DataTable ListarCitas()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT C.id_cita AS ID, (P.nombre_paciente + ' ' + P.apellido_paciente) AS Paciente, " +
                           "C.fecha_cita AS Fecha, C.hora_cita AS Hora, C.motivo_consulta AS Motivo, C.estado_consulta AS Estado, " +
                           "C.id_paciente AS IdPaciente " +
                           "FROM tb_citas C " +
                           "INNER JOIN tb_pacientes P ON C.id_paciente = P.id_paciente " +
                           "ORDER BY C.fecha_cita DESC, C.hora_cita DESC";
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

        //Metodo INSERT
        public void InsertarCita(Citas cita)
        {
            string query = "INSERT INTO tb_citas (id_paciente, fecha_cita, hora_cita, motivo_consulta, estado_consulta) " +
                           "VALUES (@idPaciente, @fecha, @hora, @motivo, @estado)";
            try
            {
                using (SqlConnection con = conexion.LeerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idPaciente", cita.id_paciente);
                        cmd.Parameters.AddWithValue("@fecha", cita.fecha_cita);
                        cmd.Parameters.AddWithValue("@hora", cita.hora_cita);
                        cmd.Parameters.AddWithValue("@motivo", cita.motivo_consulta);
                        cmd.Parameters.AddWithValue("@estado", cita.estado_consulta);

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
        public void ActualizarCita(Citas cita)
        {
            string query = "UPDATE tb_citas SET id_paciente=@idPaciente, fecha_cita=@fecha, hora_cita=@hora, " +
                           "motivo_consulta=@motivo, estado_consulta=@estado WHERE id_cita=@id";
            try
            {
                using (SqlConnection con = conexion.LeerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", cita.id_cita);
                        cmd.Parameters.AddWithValue("@idPaciente", cita.id_paciente);
                        cmd.Parameters.AddWithValue("@fecha", cita.fecha_cita);
                        cmd.Parameters.AddWithValue("@hora", cita.hora_cita);
                        cmd.Parameters.AddWithValue("@motivo", cita.motivo_consulta);
                        cmd.Parameters.AddWithValue("@estado", cita.estado_consulta);

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
        public void EliminarCita(int idCita)
        {
            string query = "DELETE FROM tb_citas WHERE id_cita = @id";
            try
            {
                using (SqlConnection con = conexion.LeerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", idCita);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Filtro de busqueda
        public DataTable FiltrarHistorialAvanzado(string paciente, string estado, DateTime fecha, bool filtrarPorFecha)
        {
            DataTable tabla = new DataTable();

            string query = "SELECT C.id_cita AS [ID Cita], " +
                           "(P.nombre_paciente + ' ' + P.apellido_paciente) AS Paciente, " +
                           "C.fecha_cita AS [Fecha], C.hora_cita AS [Hora], " +
                           "C.motivo_consulta AS [Motivo], C.estado_consulta AS [Estado] " +
                           "FROM tb_citas C " +
                           "INNER JOIN tb_pacientes P ON C.id_paciente = P.id_paciente " +
                           "WHERE (@paciente = '' OR P.nombre_paciente LIKE @paciente OR P.apellido_paciente LIKE @paciente) " +
                           "  AND (@estado = 'Todos' OR @estado = '' OR C.estado_consulta = @estado) " +
                           "  AND (@filtrarFecha = 0 OR CAST(C.fecha_cita AS DATE) = CAST(@fecha AS DATE)) " +
                           "ORDER BY C.fecha_cita DESC, C.hora_cita DESC";
            try
            {
                using (SqlConnection con = conexion.LeerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Configuramos los parámetros de forma segura contra inyección SQL
                        cmd.Parameters.AddWithValue("@paciente", string.IsNullOrEmpty(paciente) ? "" : "%" + paciente + "%");
                        cmd.Parameters.AddWithValue("@estado", string.IsNullOrEmpty(estado) ? "Todos" : estado);
                        cmd.Parameters.AddWithValue("@fecha", fecha);
                        cmd.Parameters.AddWithValue("@filtrarFecha", filtrarPorFecha ? 1 : 0);

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
