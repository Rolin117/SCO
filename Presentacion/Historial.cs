using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmHistorial : Form
    {
        private ConsultaDatos objetoDatos = new ConsultaDatos();


        public frmHistorial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            comboBoxCitaF.SelectedIndexChanged -= comboBoxCitaF_SelectedIndexChanged;
            ConfigurarComboBoxEstado();

            comboBoxCitaF.SelectedIndexChanged += comboBoxCitaF_SelectedIndexChanged;
            EjecutarFiltro();

            LimpiarFiltros();
        }

        private void LimpiarFiltros()
        {
            try
            {
                comboBoxPacienteF.TextChanged -= comboBoxPacienteF_TextChanged;
                comboBoxCitaF.SelectedIndexChanged -= comboBoxCitaF_SelectedIndexChanged;
                dateTimeFechaCitaF.ValueChanged -= dateTimeFechaCitaF_ValueChanged;

                comboBoxPacienteF.Text = "";
                comboBoxPacienteF.SelectedIndex = -1;

                comboBoxCitaF.Text = "Todos";

                dateTimeFechaCitaF.Value = DateTime.Now;
                dateTimeFechaCitaF.Checked = false;

                comboBoxPacienteF.TextChanged += comboBoxPacienteF_TextChanged;
                comboBoxCitaF.SelectedIndexChanged += comboBoxCitaF_SelectedIndexChanged;
                dateTimeFechaCitaF.ValueChanged += dateTimeFechaCitaF_ValueChanged;

                EjecutarFiltro();

            } catch (Exception ex) {
                MessageBox.Show("Error al limpiar los filtros: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ConfigurarComboBoxEstado()
        {
            comboBoxCitaF.Items.Clear();
            comboBoxCitaF.Items.Add("Todos");
            comboBoxCitaF.Items.Add("Pendiente");
            comboBoxCitaF.Items.Add("Completada");
            comboBoxCitaF.Items.Add("Cancelada");

            comboBoxCitaF.SelectedIndex = 0;

        }

        private void LeerCitasGrid()
        {
            try
            {
                tbHistorial.DataSource = objetoDatos.ListarCitas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las citas: " + ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            EjecutarFiltro();

            if (tbHistorial.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron citas que coincidan con la búsqueda manual.",
                                "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EjecutarFiltro()
        {
            try
            {
                string filtroPaciente = comboBoxPacienteF.Text;
                string filtroEstado = comboBoxCitaF.SelectedItem != null ?
                                      comboBoxCitaF.Text : "Todos";

                DateTime fechaFiltro = dateTimeFechaCitaF.Value;
                bool usarFecha = dateTimeFechaCitaF.Checked;

                DataTable resultado = objetoDatos.FiltrarHistorialAvanzado(filtroPaciente, filtroEstado, fechaFiltro, usarFecha);
                tbHistorial.DataSource = resultado;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar los filtros: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxCitaF_SelectedIndexChanged(object sender, EventArgs e)
        {
            EjecutarFiltro();
        }

        private void dateTimeFechaCitaF_ValueChanged(object sender, EventArgs e)
        {
            EjecutarFiltro();
        }

        private void comboBoxPacienteF_TextChanged(object sender, EventArgs e)
        {
            EjecutarFiltro();
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }
    }
}
