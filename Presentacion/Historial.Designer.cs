namespace Presentacion
{
    partial class frmHistorial
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeFechaCitaF = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCitaF = new System.Windows.Forms.ComboBox();
            this.comboBoxPacienteF = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarFiltro = new FontAwesome.Sharp.IconButton();
            this.tbHistorial = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbHistorial)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(294, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filtrar por estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(552, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Filtrar por fecha:";
            // 
            // dateTimeFechaCitaF
            // 
            this.dateTimeFechaCitaF.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dateTimeFechaCitaF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaCitaF.Location = new System.Drawing.Point(556, 81);
            this.dateTimeFechaCitaF.Name = "dateTimeFechaCitaF";
            this.dateTimeFechaCitaF.ShowCheckBox = true;
            this.dateTimeFechaCitaF.Size = new System.Drawing.Size(189, 26);
            this.dateTimeFechaCitaF.TabIndex = 4;
            this.dateTimeFechaCitaF.ValueChanged += new System.EventHandler(this.dateTimeFechaCitaF_ValueChanged);
            // 
            // comboBoxCitaF
            // 
            this.comboBoxCitaF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCitaF.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBoxCitaF.FormattingEnabled = true;
            this.comboBoxCitaF.Location = new System.Drawing.Point(298, 80);
            this.comboBoxCitaF.Name = "comboBoxCitaF";
            this.comboBoxCitaF.Size = new System.Drawing.Size(172, 27);
            this.comboBoxCitaF.TabIndex = 5;
            this.comboBoxCitaF.SelectedIndexChanged += new System.EventHandler(this.comboBoxCitaF_SelectedIndexChanged);
            // 
            // comboBoxPacienteF
            // 
            this.comboBoxPacienteF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPacienteF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPacienteF.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBoxPacienteF.FormattingEnabled = true;
            this.comboBoxPacienteF.Location = new System.Drawing.Point(24, 80);
            this.comboBoxPacienteF.Name = "comboBoxPacienteF";
            this.comboBoxPacienteF.Size = new System.Drawing.Size(232, 27);
            this.comboBoxPacienteF.TabIndex = 6;
            this.comboBoxPacienteF.TextChanged += new System.EventHandler(this.comboBoxPacienteF_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(193, 161);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(158, 34);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Aplicar filtros";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.btnLimpiarFiltro.IconColor = System.Drawing.Color.Silver;
            this.btnLimpiarFiltro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarFiltro.IconSize = 25;
            this.btnLimpiarFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(419, 161);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(158, 34);
            this.btnLimpiarFiltro.TabIndex = 8;
            this.btnLimpiarFiltro.Text = "Limpiar";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // tbHistorial
            // 
            this.tbHistorial.AllowUserToAddRows = false;
            this.tbHistorial.AllowUserToDeleteRows = false;
            this.tbHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbHistorial.Location = new System.Drawing.Point(102, 264);
            this.tbHistorial.Name = "tbHistorial";
            this.tbHistorial.ReadOnly = true;
            this.tbHistorial.Size = new System.Drawing.Size(763, 250);
            this.tbHistorial.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiarFiltro);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.comboBoxPacienteF);
            this.groupBox1.Controls.Add(this.comboBoxCitaF);
            this.groupBox1.Controls.Add(this.dateTimeFechaCitaF);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox1.Location = new System.Drawing.Point(79, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 212);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultas e historial de citas";
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1003, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbHistorial);
            this.Name = "frmHistorial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbHistorial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeFechaCitaF;
        private System.Windows.Forms.ComboBox comboBoxCitaF;
        private System.Windows.Forms.ComboBox comboBoxPacienteF;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiarFiltro;
        private System.Windows.Forms.DataGridView tbHistorial;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}