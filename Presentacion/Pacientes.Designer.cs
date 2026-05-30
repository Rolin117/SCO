namespace Presentacion
{
    partial class frmPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarPaciente = new FontAwesome.Sharp.IconButton();
            this.btnActualizarPaciente = new FontAwesome.Sharp.IconButton();
            this.btnEliminarPaciente = new FontAwesome.Sharp.IconButton();
            this.btnGuardarPaciente = new FontAwesome.Sharp.IconButton();
            this.txtNotasMedicas = new System.Windows.Forms.RichTextBox();
            this.dateTimeFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPaciente = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxBuscarPacienteApellido = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiarPaciente);
            this.groupBox1.Controls.Add(this.btnActualizarPaciente);
            this.groupBox1.Controls.Add(this.btnEliminarPaciente);
            this.groupBox1.Controls.Add(this.btnGuardarPaciente);
            this.groupBox1.Controls.Add(this.txtNotasMedicas);
            this.groupBox1.Controls.Add(this.dateTimeFechaNacimiento);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 558);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control de pacientes";
            // 
            // btnLimpiarPaciente
            // 
            this.btnLimpiarPaciente.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.btnLimpiarPaciente.IconColor = System.Drawing.Color.Silver;
            this.btnLimpiarPaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarPaciente.IconSize = 25;
            this.btnLimpiarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarPaciente.Location = new System.Drawing.Point(182, 523);
            this.btnLimpiarPaciente.Name = "btnLimpiarPaciente";
            this.btnLimpiarPaciente.Size = new System.Drawing.Size(115, 30);
            this.btnLimpiarPaciente.TabIndex = 15;
            this.btnLimpiarPaciente.Text = "Limpiar";
            this.btnLimpiarPaciente.UseVisualStyleBackColor = true;
            this.btnLimpiarPaciente.Click += new System.EventHandler(this.btnLimpiarPaciente_Click);
            // 
            // btnActualizarPaciente
            // 
            this.btnActualizarPaciente.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnActualizarPaciente.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnActualizarPaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarPaciente.IconSize = 25;
            this.btnActualizarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarPaciente.Location = new System.Drawing.Point(182, 487);
            this.btnActualizarPaciente.Name = "btnActualizarPaciente";
            this.btnActualizarPaciente.Size = new System.Drawing.Size(115, 30);
            this.btnActualizarPaciente.TabIndex = 14;
            this.btnActualizarPaciente.Text = "Actualizar";
            this.btnActualizarPaciente.UseVisualStyleBackColor = true;
            this.btnActualizarPaciente.Click += new System.EventHandler(this.btnActualizarPaciente_Click);
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarPaciente.IconColor = System.Drawing.Color.DarkRed;
            this.btnEliminarPaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarPaciente.IconSize = 25;
            this.btnEliminarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPaciente.Location = new System.Drawing.Point(10, 523);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(115, 30);
            this.btnEliminarPaciente.TabIndex = 13;
            this.btnEliminarPaciente.Text = "Eliminar";
            this.btnEliminarPaciente.UseVisualStyleBackColor = true;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // btnGuardarPaciente
            // 
            this.btnGuardarPaciente.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarPaciente.IconColor = System.Drawing.Color.Green;
            this.btnGuardarPaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarPaciente.IconSize = 25;
            this.btnGuardarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPaciente.Location = new System.Drawing.Point(10, 487);
            this.btnGuardarPaciente.Name = "btnGuardarPaciente";
            this.btnGuardarPaciente.Size = new System.Drawing.Size(115, 30);
            this.btnGuardarPaciente.TabIndex = 12;
            this.btnGuardarPaciente.Text = "Guardar";
            this.btnGuardarPaciente.UseVisualStyleBackColor = true;
            this.btnGuardarPaciente.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtNotasMedicas
            // 
            this.txtNotasMedicas.Location = new System.Drawing.Point(10, 299);
            this.txtNotasMedicas.Name = "txtNotasMedicas";
            this.txtNotasMedicas.Size = new System.Drawing.Size(283, 182);
            this.txtNotasMedicas.TabIndex = 11;
            this.txtNotasMedicas.Text = "";
            // 
            // dateTimeFechaNacimiento
            // 
            this.dateTimeFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaNacimiento.Location = new System.Drawing.Point(148, 241);
            this.dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            this.dateTimeFechaNacimiento.Size = new System.Drawing.Size(135, 26);
            this.dateTimeFechaNacimiento.TabIndex = 10;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(76, 187);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(221, 26);
            this.txtCorreo.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(91, 129);
            this.txtTelefono.Mask = "0000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(115, 26);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(91, 75);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(206, 26);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 26);
            this.txtNombre.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Notas medicas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido(s):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre(s):";
            // 
            // tbPaciente
            // 
            this.tbPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbPaciente.Location = new System.Drawing.Point(349, 85);
            this.tbPaciente.Name = "tbPaciente";
            this.tbPaciente.Size = new System.Drawing.Size(470, 317);
            this.tbPaciente.TabIndex = 1;
            this.tbPaciente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbPaciente_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label7.Location = new System.Drawing.Point(345, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Buscar por apellido:";
            // 
            // comboBoxBuscarPacienteApellido
            // 
            this.comboBoxBuscarPacienteApellido.FormattingEnabled = true;
            this.comboBoxBuscarPacienteApellido.Location = new System.Drawing.Point(481, 44);
            this.comboBoxBuscarPacienteApellido.Name = "comboBoxBuscarPacienteApellido";
            this.comboBoxBuscarPacienteApellido.Size = new System.Drawing.Size(325, 21);
            this.comboBoxBuscarPacienteApellido.TabIndex = 13;
            this.comboBoxBuscarPacienteApellido.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuscarPacienteApellido_SelectedIndexChanged);
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(845, 567);
            this.Controls.Add(this.comboBoxBuscarPacienteApellido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPaciente);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPacientes";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.RichTextBox txtNotasMedicas;
        private System.Windows.Forms.DateTimePicker dateTimeFechaNacimiento;
        private FontAwesome.Sharp.IconButton btnEliminarPaciente;
        private FontAwesome.Sharp.IconButton btnGuardarPaciente;
        private System.Windows.Forms.DataGridView tbPaciente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxBuscarPacienteApellido;
        private FontAwesome.Sharp.IconButton btnLimpiarPaciente;
        private FontAwesome.Sharp.IconButton btnActualizarPaciente;
    }
}