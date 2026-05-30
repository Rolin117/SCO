namespace Presentacion
{
    partial class Dashboard
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnPacientes = new FontAwesome.Sharp.IconMenuItem();
            this.btnCitas = new FontAwesome.Sharp.IconMenuItem();
            this.btnConsultas = new FontAwesome.Sharp.IconMenuItem();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.tituloSCO = new System.Windows.Forms.Label();
            this.iconoSCO = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoSCO)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPacientes,
            this.btnCitas,
            this.btnConsultas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(190, 606);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPacientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnPacientes.IconColor = System.Drawing.Color.White;
            this.btnPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPacientes.IconSize = 25;
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Padding = new System.Windows.Forms.Padding(4, 0, 4, 5);
            this.btnPacientes.Size = new System.Drawing.Size(177, 34);
            this.btnPacientes.Text = "Control de pacientes";
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCitas.ForeColor = System.Drawing.Color.White;
            this.btnCitas.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.btnCitas.IconColor = System.Drawing.Color.White;
            this.btnCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCitas.IconSize = 25;
            this.btnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Padding = new System.Windows.Forms.Padding(4, 0, 4, 5);
            this.btnCitas.Size = new System.Drawing.Size(177, 34);
            this.btnCitas.Text = "Control de citas";
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnConsultas.IconColor = System.Drawing.Color.White;
            this.btnConsultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultas.IconSize = 25;
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Padding = new System.Windows.Forms.Padding(4, 0, 4, 5);
            this.btnConsultas.Size = new System.Drawing.Size(177, 34);
            this.btnConsultas.Text = "Consultas e historial";
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelDashboard.Controls.Add(this.tituloSCO);
            this.panelDashboard.Controls.Add(this.iconoSCO);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(190, 0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1019, 606);
            this.panelDashboard.TabIndex = 1;
            this.panelDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.frmCitas_Paint);
            // 
            // tituloSCO
            // 
            this.tituloSCO.AutoSize = true;
            this.tituloSCO.Font = new System.Drawing.Font("MS Reference Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloSCO.ForeColor = System.Drawing.Color.SteelBlue;
            this.tituloSCO.Location = new System.Drawing.Point(527, 406);
            this.tituloSCO.Name = "tituloSCO";
            this.tituloSCO.Size = new System.Drawing.Size(124, 58);
            this.tituloSCO.TabIndex = 1;
            this.tituloSCO.Text = "SCO";
            // 
            // iconoSCO
            // 
            this.iconoSCO.Image = global::Presentacion.Properties.Resources.SCO_icono;
            this.iconoSCO.InitialImage = ((System.Drawing.Image)(resources.GetObject("iconoSCO.InitialImage")));
            this.iconoSCO.Location = new System.Drawing.Point(343, 143);
            this.iconoSCO.Name = "iconoSCO";
            this.iconoSCO.Size = new System.Drawing.Size(491, 333);
            this.iconoSCO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoSCO.TabIndex = 0;
            this.iconoSCO.TabStop = false;
            this.iconoSCO.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 606);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Control dental";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoSCO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem btnConsultas;
        private FontAwesome.Sharp.IconMenuItem btnPacientes;
        private FontAwesome.Sharp.IconMenuItem btnCitas;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.PictureBox iconoSCO;
        private System.Windows.Forms.Label tituloSCO;
    }
}

