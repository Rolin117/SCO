using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidad;


namespace Presentacion
{
    public partial class frmCitas : Form
    {

        private ConsultaDatos objetoDatos = new ConsultaDatos();
        private int idCitaSeleccionada = 0;

        public frmCitas()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            idCitaSeleccionada = 0;

            if (comboBoxPaciente.Items.Count > 0)
            {
                comboBoxPaciente.SelectedIndex = 0;
            }

            dateTimeFechaCita.Value = DateTime.Today;
            ActualizarHorariosDisponibles(dateTimeFechaCita.Value);

            if (comboBoxEstado.Items.Count > 0)
            {
                comboBoxEstado.SelectedIndex = 0;
            }

            btnGuardarCita.Enabled = true;
            txtMotivoCita.Clear();
            comboBoxPaciente.Focus();
        }

        private void frmCitas_Load(object sender, EventArgs e)
        {
            dateTimeFechaCita.MinDate = DateTime.Today;

            LimpiarCampos();
            LlenarComboBoxPacientes();
            ConfigurarComboBoxEstado();
            dateTimeFechaCita.Value = DateTime.Now.Date;
            ActualizarHorariosDisponibles(dateTimeFechaCita.Value);
            LlenarComboBoxBuscarApellidos();
            LeerCitasGrid();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurarComboBoxEstado()
        {
            comboBoxEstado.Items.Clear();

            comboBoxEstado.Items.Add("Pendiente");
            comboBoxEstado.Items.Add("Completada");
            comboBoxEstado.Items.Add("Cancelada");

            comboBoxEstado.SelectedIndex = 0;
        }

        private void LeerCitasGrid()
        {
            try
            {
                tbCitas.DataSource = objetoDatos.ListarCitas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las citas: " + ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarComboBoxPacientes()
        {
            try
            {
                DataTable tbCitas  = objetoDatos.ObtenerPacientes();

                DataRow filaPorDefecto = tbCitas.NewRow();
                filaPorDefecto["id_paciente"] = 0;
                filaPorDefecto["NombreCompleto"] = "Seleccione un Paciente";
                tbCitas.Rows.InsertAt(filaPorDefecto, 0);

                comboBoxPaciente.DataSource = tbCitas;

                comboBoxPaciente.ValueMember = "id_paciente";

                comboBoxPaciente.DisplayMember = "NombreCompleto";

                comboBoxPaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBoxPaciente.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de pacientes: " + ex.Message,
                                "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarHorariosDisponibles(DateTime fechaSeleccionada)
        {
            try
            {
                string[] horarioClinica = { "08:00", "09:00", "10:00", "11:00", "14:00", "15:00", "16:00", "17:00" };

                DataTable dtOcupadas = objetoDatos.ObtenerHorasOcupadasPorFecha(fechaSeleccionada);
                List<string> listaHorasOcupadas = new List<string>();

                foreach (DataRow fila in dtOcupadas.Rows)
                {
                    if (fila["hora_cita"] != DBNull.Value)
                    {
                        string horaRaw = fila["hora_cita"].ToString();
                        if (TimeSpan.TryParse(horaRaw, out TimeSpan ts))
                        {
                            listaHorasOcupadas.Add(ts.ToString(@"hh\:mm"));
                        }
                    }
                }

                comboBoxHora.Items.Clear();

                foreach (string hora in horarioClinica)
                {
                    if (fechaSeleccionada.Date == DateTime.Today)
                    {
                        TimeSpan horaActual = DateTime.Now.TimeOfDay;
                        TimeSpan horaItem = TimeSpan.Parse(hora);

                        if (horaItem <= horaActual)
                        {
                            continue; 
                        }
                    }

                    if (!listaHorasOcupadas.Contains(hora))
                    {
                        comboBoxHora.Items.Add(hora);
                    }
                }

                if (comboBoxHora.Items.Count > 0)
                {
                    comboBoxHora.SelectedIndex = 0; 
                }
                else
                {
                    comboBoxHora.Text = "Sin cupos";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico al calcular horarios: " + ex.Message,
                                "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiarDatosCita_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardarCita_Click(object sender, EventArgs e)
        {
            TimeSpan horaConvertida = TimeSpan.Parse(comboBoxHora.Text);

            if (string.IsNullOrWhiteSpace(txtMotivoCita.Text))
            {
                MessageBox.Show("El motivo de la consulta es obligatorio para poder registrar la cita.",
                                "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMotivoCita.Focus();
                return; 
            }

            if (idCitaSeleccionada > 0)
            {
                MessageBox.Show("Esta cita ya se encuentra registrada. Si desea cambiar datos, use 'Actualizar'.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool exito = objetoDatos.InsertarCita(
                Convert.ToInt32(comboBoxPaciente.SelectedValue),
                dateTimeFechaCita.Value,
                horaConvertida, 
                comboBoxEstado.Text,
                txtMotivoCita.Text.Trim()
            );

            if (exito)
            {
                MessageBox.Show("Cita programada con éxito.", "Éxito");
                ActualizarHorariosDisponibles(dateTimeFechaCita.Value);
                LimpiarCampos();
                LlenarComboBoxPacientes();
                LlenarComboBoxBuscarApellidos();
                LeerCitasGrid();

            }
        }

        private void tbCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = tbCitas.Rows[e.RowIndex];
            if (fila.IsNewRow) return;

            try
            {
                idCitaSeleccionada = Convert.ToInt32(fila.Cells["id_cita"].Value);

                if (fila.Cells["id_paciente"].Value != DBNull.Value)
                {
                    comboBoxPaciente.SelectedValue = fila.Cells["id_paciente"].Value;
                }

                if (fila.Cells["fecha_cita"].Value != DBNull.Value)
                {
                    dateTimeFechaCita.Value = Convert.ToDateTime(fila.Cells["fecha_cita"].Value);
                }

                if (fila.Cells["hora_cita"].Value != DBNull.Value)
                {
                    TimeSpan horaBD = (TimeSpan)fila.Cells["hora_cita"].Value;
                    string horaTexto = horaBD.ToString(@"hh\:mm");

                    if (!comboBoxHora.Items.Contains(horaTexto))
                    {
                        comboBoxHora.Items.Add(horaTexto);
                    }
                    comboBoxHora.Text = horaTexto;
                }

                if (fila.Cells["estado_consulta"].Value != DBNull.Value)
                {
                    comboBoxEstado.Text = fila.Cells["estado_consulta"].Value.ToString();
                }

                if (fila.Cells["motivo_consulta"].Value != DBNull.Value)
                {
                    txtMotivoCita.Text = fila.Cells["motivo_consulta"].Value.ToString();
                }
                else
                {
                    txtMotivoCita.Clear();
                }

                btnGuardarCita.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la cita: " + ex.Message, "Error de Selección",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimeFechaCita_ValueChanged(object sender, EventArgs e)
        {
            ActualizarHorariosDisponibles(dateTimeFechaCita.Value);
        }

        private void btnActualizarCita_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMotivoCita.Text))
            {
                MessageBox.Show("El motivo de la consulta no puede quedar vacío al actualizar la cita.",
                                "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMotivoCita.Focus();
                return;
            }

            if (idCitaSeleccionada == 0)
            {
                MessageBox.Show("Por favor, seleccione una cita de la tabla para poder modificarla.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToInt32(comboBoxPaciente.SelectedValue) == 0 || comboBoxHora.Text == "Sin cupos")
            {
                MessageBox.Show("Asegúrese de seleccionar un paciente y un horario válido.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                TimeSpan horaConvertida = TimeSpan.Parse(comboBoxHora.Text);

                bool exito = objetoDatos.ActualizarCita(
                    idCitaSeleccionada,
                    Convert.ToInt32(comboBoxPaciente.SelectedValue),
                    dateTimeFechaCita.Value,
                    horaConvertida,
                    comboBoxEstado.Text,
                    txtMotivoCita.Text.Trim()
                );

                if (exito)
                {
                    MessageBox.Show("La cita ha sido modificada con éxito.", "Sistema Médico",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ActualizarHorariosDisponibles(dateTimeFechaCita.Value);
                    LimpiarCampos();
                    LeerCitasGrid();
                    LlenarComboBoxPacientes();
                    LlenarComboBoxBuscarApellidos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la cita. Verifique los datos.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar actualizar: " + ex.Message, "Error Crítico",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            if (idCitaSeleccionada == 0)
            {
                MessageBox.Show("Por favor, seleccione la cita que desea eliminar desde la tabla.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está completamente seguro de que desea eliminar permanentemente esta cita?",
                                                     "Confirmar Eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    bool exito = objetoDatos.EliminarCita(idCitaSeleccionada);

                    if (exito)
                    {
                        MessageBox.Show("La cita ha sido eliminada correctamente de la agenda.", "Sistema Médico",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ActualizarHorariosDisponibles(dateTimeFechaCita.Value);
                        LimpiarCampos();
                        LlenarComboBoxPacientes();
                        LlenarComboBoxBuscarApellidos();
                        LeerCitasGrid();

                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la cita seleccionada.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar eliminar la cita: " + ex.Message, "Error Crítico",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LlenarComboBoxBuscarApellidos()
        {
            try
            {
                comboBoxBuscarCitaApellido.SelectedIndexChanged -= comboBoxBuscarCitaApellido_SelectedIndexChanged;

                DataTable dtApellidos = objetoDatos.ObtenerApellidosConCitas();

                comboBoxBuscarCitaApellido.DataSource = dtApellidos;
                comboBoxBuscarCitaApellido.DisplayMember = "apellido_paciente";
                comboBoxBuscarCitaApellido.ValueMember = "apellido_paciente";

                comboBoxBuscarCitaApellido.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los apellidos de búsqueda: " + ex.Message, "Error");
            }
            finally
            {
                comboBoxBuscarCitaApellido.SelectedIndexChanged += comboBoxBuscarCitaApellido_SelectedIndexChanged;
            }
        }

        private void comboBoxBuscarCitaApellido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBuscarCitaApellido.SelectedIndex != -1 && comboBoxBuscarCitaApellido.SelectedValue != null)
            {
                string apellidoSeleccionado = comboBoxBuscarCitaApellido.SelectedValue.ToString();
                DataTable dtCitasFiltradas = objetoDatos.BuscarCitasPorApellido(apellidoSeleccionado);
                tbCitas.DataSource = dtCitasFiltradas;
            }
        }
    }
    
}
