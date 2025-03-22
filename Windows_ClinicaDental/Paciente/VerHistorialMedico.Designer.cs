namespace Windows_ClinicaDental.Paciente
{
    partial class VerHistorialMedico
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
            dtgDatos = new DataGridView();
            fecha = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            observaciones = new DataGridViewTextBoxColumn();
            nombreTratamiento = new DataGridViewTextBoxColumn();
            nombreDentista = new DataGridViewTextBoxColumn();
            fechaCita = new DataGridViewTextBoxColumn();
            horaCita = new DataGridViewTextBoxColumn();
            motivoCita = new DataGridViewTextBoxColumn();
            estado_cadena = new DataGridViewTextBoxColumn();
            lblCodigoPaciente = new TextBox();
            txtDni = new TextBox();
            label3 = new Label();
            txtApellidosNombre = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { fecha, descripcion, observaciones, nombreTratamiento, nombreDentista, fechaCita, horaCita, motivoCita, estado_cadena });
            dtgDatos.Location = new Point(32, 85);
            dtgDatos.Margin = new Padding(4);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.Size = new Size(1236, 451);
            dtgDatos.TabIndex = 105;
            // 
            // fecha
            // 
            fecha.DataPropertyName = "fecha";
            fecha.HeaderText = "Fecha";
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            // 
            // descripcion
            // 
            descripcion.DataPropertyName = "descripcion";
            descripcion.HeaderText = "Descripcion";
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            // 
            // observaciones
            // 
            observaciones.DataPropertyName = "observaciones";
            observaciones.HeaderText = "Observacion";
            observaciones.Name = "observaciones";
            observaciones.ReadOnly = true;
            // 
            // nombreTratamiento
            // 
            nombreTratamiento.DataPropertyName = "nombreTratamiento";
            nombreTratamiento.HeaderText = "Tratamiento";
            nombreTratamiento.Name = "nombreTratamiento";
            nombreTratamiento.ReadOnly = true;
            // 
            // nombreDentista
            // 
            nombreDentista.DataPropertyName = "nombreDentista";
            nombreDentista.HeaderText = "Dentista";
            nombreDentista.Name = "nombreDentista";
            nombreDentista.ReadOnly = true;
            // 
            // fechaCita
            // 
            fechaCita.DataPropertyName = "fechaCita";
            fechaCita.HeaderText = "Fecha de Cita";
            fechaCita.Name = "fechaCita";
            fechaCita.ReadOnly = true;
            // 
            // horaCita
            // 
            horaCita.DataPropertyName = "horaCita";
            horaCita.HeaderText = "Hora de Cita";
            horaCita.Name = "horaCita";
            horaCita.ReadOnly = true;
            // 
            // motivoCita
            // 
            motivoCita.DataPropertyName = "motivoCita";
            motivoCita.HeaderText = "Motivo";
            motivoCita.Name = "motivoCita";
            motivoCita.ReadOnly = true;
            // 
            // estado_cadena
            // 
            estado_cadena.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            estado_cadena.DataPropertyName = "estado_cadena";
            estado_cadena.HeaderText = "Estado";
            estado_cadena.Name = "estado_cadena";
            estado_cadena.ReadOnly = true;
            estado_cadena.Width = 89;
            // 
            // lblCodigoPaciente
            // 
            lblCodigoPaciente.Location = new Point(1143, 34);
            lblCodigoPaciente.Margin = new Padding(4);
            lblCodigoPaciente.MaxLength = 20;
            lblCodigoPaciente.Name = "lblCodigoPaciente";
            lblCodigoPaciente.ReadOnly = true;
            lblCodigoPaciente.Size = new Size(125, 27);
            lblCodigoPaciente.TabIndex = 110;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(109, 31);
            txtDni.Margin = new Padding(4);
            txtDni.MaxLength = 20;
            txtDni.Name = "txtDni";
            txtDni.ReadOnly = true;
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 109;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 34);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 108;
            label3.Text = "DNI:";
            // 
            // txtApellidosNombre
            // 
            txtApellidosNombre.Location = new Point(527, 31);
            txtApellidosNombre.Margin = new Padding(4);
            txtApellidosNombre.MaxLength = 20;
            txtApellidosNombre.Name = "txtApellidosNombre";
            txtApellidosNombre.ReadOnly = true;
            txtApellidosNombre.Size = new Size(317, 27);
            txtApellidosNombre.TabIndex = 107;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 21);
            label1.TabIndex = 106;
            label1.Text = "APELLIDOS Y NOMBRES:";
            // 
            // VerHistorialMedico
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 569);
            Controls.Add(lblCodigoPaciente);
            Controls.Add(txtDni);
            Controls.Add(label3);
            Controls.Add(txtApellidosNombre);
            Controls.Add(label1);
            Controls.Add(dtgDatos);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VerHistorialMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HISTORIAL MEDICO";
            Load += VerHistorialMedico_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDatos;
        private TextBox lblCodigoPaciente;
        private TextBox txtDni;
        private Label label3;
        private TextBox txtApellidosNombre;
        private Label label1;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn observaciones;
        private DataGridViewTextBoxColumn nombreTratamiento;
        private DataGridViewTextBoxColumn nombreDentista;
        private DataGridViewTextBoxColumn fechaCita;
        private DataGridViewTextBoxColumn horaCita;
        private DataGridViewTextBoxColumn motivoCita;
        private DataGridViewTextBoxColumn estado_cadena;
    }
}