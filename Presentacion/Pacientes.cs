using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmPacientes : Form
    {

        private PacienteDatos objetoDatos = new PacienteDatos();

        private int idPacienteSeleccionado = 0;

        public frmPacientes()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtCorreo.Text) && !CorreoValido(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, introduce una dirección de correo electrónico válida (ejemplo: usuario@correo.com).",
                                "Correo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            if (!TelefonoValido(txtTelefono.Text))
            {
                MessageBox.Show("El número de teléfono debe contener exactamente los 8 dígitos requeridos.",
                                "Teléfono Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                Pacientes nuevoPaciente = new Pacientes()
                {
                    nombre_paciente = txtNombre.Text.Trim(),
                    apellido_paciente = txtApellido.Text.Trim(),
                    telefono_paciente = txtTelefono.Text.Trim(),
                    correo_paciente = txtCorreo.Text.Trim(),
                    fecha_nacimiento_paciente = dateTimeFechaNacimiento.Value.Date,
                    notas_medicas_paciente = string.IsNullOrWhiteSpace(txtNotasMedicas.Text) ? null : txtNotasMedicas.Text.Trim()
                };

                objetoDatos.InsertarPaciente(nuevoPaciente);

                MessageBox.Show("¡Paciente registrado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LeerPacientesGrid();
                LimpiarCampos();
                CargarApellidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el paciente: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            LeerPacientesGrid();
            LimpiarCampos();
            CargarApellidos();
        }

        private void LeerPacientesGrid()
        {
            try
            {
                tbPaciente.DataSource = objetoDatos.LeerPacientes();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            dateTimeFechaNacimiento.Value = DateTime.Now;
            txtNotasMedicas.Clear();

            txtNombre.Focus();
            btnGuardarPaciente.Enabled = true;
        }

        private void CargarApellidos()
        {
            try
            {
                DataTable dt = objetoDatos.ObtenerApellidos();

                comboBoxBuscarPacienteApellido.Items.Clear();

                comboBoxBuscarPacienteApellido.Items.Add("Mostrar Todos");

                foreach (DataRow fila in dt.Rows)
                {
                    comboBoxBuscarPacienteApellido.Items.Add(fila["apellido_paciente"].ToString());
                }

                comboBoxBuscarPacienteApellido.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el buscador de apellidos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarPaciente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCorreo.Text) && !CorreoValido(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, introduce una dirección de correo electrónico válida (ejemplo: usuario@correo.com).",
                                "Correo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return; 
            }

            if (!TelefonoValido(txtTelefono.Text))
            {
                MessageBox.Show("El número de teléfono debe contener exactamente los 8 dígitos requeridos.",
                                "Teléfono Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return; 
            }

            if (idPacienteSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un paciente de la tabla para poder modificarlo.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Pacientes pacienteEditado = new Pacientes()
                {
                    id_paciente = idPacienteSeleccionado,
                    nombre_paciente = txtNombre.Text.Trim(),
                    apellido_paciente = txtApellido.Text.Trim(),
                    telefono_paciente = txtTelefono.Text.Trim(),
                    correo_paciente = txtCorreo.Text.Trim(),
                    fecha_nacimiento_paciente = dateTimeFechaNacimiento.Value,
                    notas_medicas_paciente = string.IsNullOrWhiteSpace(txtNotasMedicas.Text) ? null : txtNotasMedicas.Text.Trim()
                };

                objetoDatos.ActualizarPaciente(pacienteEditado);

                MessageBox.Show("¡Registro actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LeerPacientesGrid();
                LimpiarCampos();
                CargarApellidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el registro: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void tbPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = tbPaciente.Rows[e.RowIndex];

                idPacienteSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);

                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
                txtTelefono.Text = fila.Cells["Teléfono"].Value.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
                dateTimeFechaNacimiento.Value = Convert.ToDateTime(fila.Cells["F. Nacimiento"].Value);
                txtNotasMedicas.Text = fila.Cells["Notas Médicas"].Value.ToString();

                btnGuardarPaciente.Enabled = false;
            }

        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            if (idPacienteSeleccionado == 0)
            {
                MessageBox.Show("Por favor, seleccione un paciente de la tabla para poder eliminarlo.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar este paciente?",
                                                     "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    objetoDatos.EliminarPaciente(idPacienteSeleccionado);

                    MessageBox.Show("Paciente eliminado del sistema.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LeerPacientesGrid();
                    LimpiarCampos();
                    CargarApellidos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiarPaciente_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void comboBoxBuscarPacienteApellido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBuscarPacienteApellido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbPaciente.DataSource is DataTable dt)
                {
                    string textoBusqueda = comboBoxBuscarPacienteApellido.Text.Trim();

                    if (string.IsNullOrEmpty(textoBusqueda) || textoBusqueda == "-- Mostrar Todos --")
                    {
                        dt.DefaultView.RowFilter = "";
                    }
                    else
                    {
                        dt.DefaultView.RowFilter = $"Apellido LIKE '%{textoBusqueda}%'";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al realizar la búsqueda: " + ex.Message,
                                "Error de Filtrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private bool CorreoValido(string email)
        {
            string expresion = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, expresion);
        }

        private bool TelefonoValido(string telefono)
        {
            string soloNumeros = telefono.Replace("-", "").Replace(" ", "").Trim();

            return soloNumeros.Length == 8 && soloNumeros.All(char.IsDigit);
        }


    }
}
