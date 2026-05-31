namespace Presentacion
{
    partial class frmCitas
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiarDatosCita = new FontAwesome.Sharp.IconButton();
            this.btnEliminarCita = new FontAwesome.Sharp.IconButton();
            this.btnActualizarCita = new FontAwesome.Sharp.IconButton();
            this.btnGuardarCita = new FontAwesome.Sharp.IconButton();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMotivoCita = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeFechaCita = new System.Windows.Forms.DateTimePicker();
            this.tbCitas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxHora = new System.Windows.Forms.ComboBox();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxBuscarCitaApellido = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbCitas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paciente:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLimpiarDatosCita
            // 
            this.btnLimpiarDatosCita.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.btnLimpiarDatosCita.IconColor = System.Drawing.Color.Silver;
            this.btnLimpiarDatosCita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarDatosCita.IconSize = 25;
            this.btnLimpiarDatosCita.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarDatosCita.Location = new System.Drawing.Point(621, 204);
            this.btnLimpiarDatosCita.Name = "btnLimpiarDatosCita";
            this.btnLimpiarDatosCita.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLimpiarDatosCita.Size = new System.Drawing.Size(124, 29);
            this.btnLimpiarDatosCita.TabIndex = 13;
            this.btnLimpiarDatosCita.Text = "Limpiar";
            this.btnLimpiarDatosCita.UseVisualStyleBackColor = true;
            this.btnLimpiarDatosCita.Click += new System.EventHandler(this.btnLimpiarDatosCita_Click);
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarCita.IconColor = System.Drawing.Color.DarkRed;
            this.btnEliminarCita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarCita.IconSize = 25;
            this.btnEliminarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCita.Location = new System.Drawing.Point(621, 147);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(124, 29);
            this.btnEliminarCita.TabIndex = 12;
            this.btnEliminarCita.Text = "Eliminar";
            this.btnEliminarCita.UseVisualStyleBackColor = true;
            this.btnEliminarCita.Click += new System.EventHandler(this.btnEliminarCita_Click);
            // 
            // btnActualizarCita
            // 
            this.btnActualizarCita.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnActualizarCita.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnActualizarCita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarCita.IconSize = 25;
            this.btnActualizarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarCita.Location = new System.Drawing.Point(621, 89);
            this.btnActualizarCita.Name = "btnActualizarCita";
            this.btnActualizarCita.Size = new System.Drawing.Size(124, 29);
            this.btnActualizarCita.TabIndex = 11;
            this.btnActualizarCita.Text = "Actualizar";
            this.btnActualizarCita.UseVisualStyleBackColor = true;
            this.btnActualizarCita.Click += new System.EventHandler(this.btnActualizarCita_Click);
            // 
            // btnGuardarCita
            // 
            this.btnGuardarCita.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarCita.IconColor = System.Drawing.Color.Green;
            this.btnGuardarCita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCita.IconSize = 25;
            this.btnGuardarCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCita.Location = new System.Drawing.Point(621, 34);
            this.btnGuardarCita.Name = "btnGuardarCita";
            this.btnGuardarCita.Size = new System.Drawing.Size(124, 29);
            this.btnGuardarCita.TabIndex = 10;
            this.btnGuardarCita.Text = "Guardar";
            this.btnGuardarCita.UseVisualStyleBackColor = true;
            this.btnGuardarCita.Click += new System.EventHandler(this.btnGuardarCita_Click);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(123, 258);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(200, 23);
            this.comboBoxEstado.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Motivo:";
            // 
            // txtMotivoCita
            // 
            this.txtMotivoCita.Location = new System.Drawing.Point(118, 136);
            this.txtMotivoCita.Name = "txtMotivoCita";
            this.txtMotivoCita.Size = new System.Drawing.Size(471, 110);
            this.txtMotivoCita.TabIndex = 6;
            this.txtMotivoCita.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hora:";
            // 
            // dateTimeFechaCita
            // 
            this.dateTimeFechaCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaCita.Location = new System.Drawing.Point(116, 85);
            this.dateTimeFechaCita.Name = "dateTimeFechaCita";
            this.dateTimeFechaCita.Size = new System.Drawing.Size(198, 23);
            this.dateTimeFechaCita.TabIndex = 1;
            this.dateTimeFechaCita.ValueChanged += new System.EventHandler(this.dateTimeFechaCita_ValueChanged);
            // 
            // tbCitas
            // 
            this.tbCitas.AllowUserToAddRows = false;
            this.tbCitas.AllowUserToDeleteRows = false;
            this.tbCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbCitas.Location = new System.Drawing.Point(109, 388);
            this.tbCitas.Name = "tbCitas";
            this.tbCitas.ReadOnly = true;
            this.tbCitas.Size = new System.Drawing.Size(745, 167);
            this.tbCitas.TabIndex = 16;
            this.tbCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbCitas_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxHora);
            this.groupBox1.Controls.Add(this.btnLimpiarDatosCita);
            this.groupBox1.Controls.Add(this.btnEliminarCita);
            this.groupBox1.Controls.Add(this.btnActualizarCita);
            this.groupBox1.Controls.Add(this.btnGuardarCita);
            this.groupBox1.Controls.Add(this.comboBoxEstado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMotivoCita);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimeFechaCita);
            this.groupBox1.Controls.Add(this.comboBoxPaciente);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(109, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 294);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programacion de citas";
            // 
            // comboBoxHora
            // 
            this.comboBoxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHora.FormattingEnabled = true;
            this.comboBoxHora.Location = new System.Drawing.Point(414, 85);
            this.comboBoxHora.Name = "comboBoxHora";
            this.comboBoxHora.Size = new System.Drawing.Size(185, 23);
            this.comboBoxHora.TabIndex = 14;
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPaciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point(118, 32);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(295, 23);
            this.comboBoxPaciente.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Buscar cita por apellidos:";
            // 
            // comboBoxBuscarCitaApellido
            // 
            this.comboBoxBuscarCitaApellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxBuscarCitaApellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxBuscarCitaApellido.FormattingEnabled = true;
            this.comboBoxBuscarCitaApellido.Location = new System.Drawing.Point(284, 340);
            this.comboBoxBuscarCitaApellido.Name = "comboBoxBuscarCitaApellido";
            this.comboBoxBuscarCitaApellido.Size = new System.Drawing.Size(258, 21);
            this.comboBoxBuscarCitaApellido.TabIndex = 17;
            this.comboBoxBuscarCitaApellido.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuscarCitaApellido_SelectedIndexChanged);
            // 
            // frmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1003, 567);
            this.Controls.Add(this.comboBoxBuscarCitaApellido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCitas);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCitas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbCitas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnLimpiarDatosCita;
        private FontAwesome.Sharp.IconButton btnEliminarCita;
        private FontAwesome.Sharp.IconButton btnActualizarCita;
        private FontAwesome.Sharp.IconButton btnGuardarCita;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtMotivoCita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeFechaCita;
        private System.Windows.Forms.DataGridView tbCitas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxPaciente;
        private System.Windows.Forms.ComboBox comboBoxHora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxBuscarCitaApellido;
    }
}