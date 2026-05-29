using FontAwesome.Sharp;
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
    public partial class Dashboard : Form
    {

        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void abrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null )
            {
                menuActivo.BackColor = Color.SteelBlue;
            }

            menu.BackColor = Color.SkyBlue;
            menuActivo = menu;

            if(formularioActivo != null)
            {
                formularioActivo.Close();

            }

            iconoSCO.Visible = false;
            tituloSCO.Visible = false;
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panelDashboard.Controls.Add(formulario);
            formulario.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {

        }

        private void frmCitas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmPacientes());
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmCitas());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmHistorial());
        }
    }
}
