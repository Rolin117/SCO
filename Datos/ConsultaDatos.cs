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
            string query = "SELECT C.id_cita, (P.nombre_paciente + ' ' + P.apellido_paciente) AS Paciente, " +
                           "C.fecha_cita, C.hora_cita, C.motivo_consulta, C.estado_consulta, C.id_paciente " +
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
            catch (Exception) { throw; }
            return tabla;
        }

        //Metodo INSERT
        public bool InsertarCita(int idPaciente, DateTime fecha, TimeSpan hora, string estado, string motivo)
        {
            string query = "INSERT INTO tb_citas (id_paciente, fecha_cita, hora_cita, estado_consulta, motivo_consulta) " +
                           "VALUES (@idPaciente, @fecha, @hora, @estado, @motivo)";
            try
            {
                using (SqlConnection con = conexion.LeerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                        cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                        cmd.Parameters.AddWithValue("@hora", hora);
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@motivo", motivo);

                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ActualizarCita(int id, int idPaciente, DateTime fecha, TimeSpan hora, string estado, string motivo)
        {
            string query = "UPDATE tb_citas SET id_paciente=@idPaciente, fecha_cita=@fecha, hora_cita=@hora, " +
                           "motivo_consulta=@motivo, estado_consulta=@estado WHERE id_cita=@id";
            try
            {
                using (SqlConnection con = conexion.LeerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Asignamos las variables directamente
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                        cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                        cmd.Parameters.AddWithValue("@hora", hora);
                        cmd.Parameters.AddWithValue("@motivo", motivo);
                        cmd.Parameters.AddWithValue("@estado", estado);

                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Metodo DELETE
        public bool EliminarCita(int idCita)
        {
            string query = "DELETE FROM tb_citas WHERE id_cita = @id";
            try
            {
                using (SqlConnection con = conexion.LeerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", idCita);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Metodos de busqueda con apellido y nombres
        public DataTable ObtenerPacientes()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT id_paciente, apellido_paciente + ', ' + nombre_paciente AS NombreCompleto FROM tb_pacientes ORDER BY apellido_paciente ASC";

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

        public DataTable BuscarCitasPorApellido(string apellido)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT c.id_cita, (p.nombre_paciente + ' ' + p.apellido_paciente) AS Paciente, " +
                           "c.fecha_cita, c.hora_cita, c.motivo_consulta, c.estado_consulta, c.id_paciente " +
                           "FROM tb_citas c " +
                           "INNER JOIN tb_pacientes p ON c.id_paciente = p.id_paciente " +
                           "WHERE p.apellido_paciente LIKE @apellido";
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
            catch (Exception) { throw; }
            return tabla;
        }

        public DataTable ObtenerApellidosConCitas()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT DISTINCT p.apellido_paciente FROM tb_citas c " +
                           "INNER JOIN tb_pacientes p ON c.id_paciente = p.id_paciente " +
                           "ORDER BY p.apellido_paciente ASC";
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
            catch (Exception) { throw; }
            return tabla;
        }

        //Metodo de Horas Ocupadas
        public DataTable ObtenerHorasOcupadasPorFecha(DateTime fecha)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT hora_cita FROM tb_citas WHERE CAST(fecha_cita AS DATE) = @fecha AND estado_consulta != 'Cancelada'";

            try
            {
                using (SqlConnection con = conexion.LeerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@fecha", fecha.Date);

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

        //Filtro de busqueda para historial de citas
        public DataTable FiltrarHistorialAvanzado(string paciente, string estado, DateTime fecha, bool filtrarPorFecha)
        {
            DataTable tabla = new DataTable();

            string query = "SELECT C.id_cita AS [ID Cita], " +
                           "(P.nombre_paciente + ' ' + P.apellido_paciente) AS Paciente, " +
                           "C.fecha_cita AS [Fecha], C.hora_cita AS [Hora], " +
                           "C.motivo_consulta AS [Motivo], C.estado_consulta AS [Estado] " +
                           "FROM tb_citas C " +
                           "INNER JOIN tb_pacientes P ON C.id_paciente = P.id_paciente " +
                           "WHERE (@paciente = '' OR (P.nombre_paciente + ' ' + P.apellido_paciente) LIKE @paciente) " +
                           "  AND (@estado = 'Todos' OR @estado = '' OR C.estado_consulta = @estado) " +
                           "  AND (@filtrarFecha = 0 OR CAST(C.fecha_cita AS DATE) = CAST(@fecha AS DATE)) " +
                           "ORDER BY C.fecha_cita DESC, C.hora_cita DESC";
            try
            {
                using (SqlConnection con = conexion.LeerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@paciente", string.IsNullOrEmpty(paciente) ? "" : "%" + paciente + "%");
                        cmd.Parameters.AddWithValue("@estado", string.IsNullOrEmpty(estado) ? "Todos" : estado.Trim());
                        cmd.Parameters.AddWithValue("@fecha", fecha.Date);
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
