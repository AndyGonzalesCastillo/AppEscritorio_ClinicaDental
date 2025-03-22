namespace Windows_ClinicaDental
{
    partial class PrincipalDentista
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
            components = new System.ComponentModel.Container();
            statusStrip2 = new StatusStrip();
            ToolStripStatusLabelDni = new ToolStripStatusLabel();
            toolStripStatusLabelUsuario = new ToolStripStatusLabel();
            toolStripStatusLabelRol = new ToolStripStatusLabel();
            toolStripStatusLabelEspecialidad = new ToolStripStatusLabel();
            lblSesion = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            lblCodigoDentista = new TextBox();
            dtgDatos = new DataGridView();
            idPaciente = new DataGridViewTextBoxColumn();
            idCita = new DataGridViewTextBoxColumn();
            fechaCita = new DataGridViewTextBoxColumn();
            horaCita = new DataGridViewTextBoxColumn();
            estado_cadena = new DataGridViewTextBoxColumn();
            nombrePaciente = new DataGridViewTextBoxColumn();
            apellidoPaciente = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            correoPaciente = new DataGridViewTextBoxColumn();
            telefonoPaciente = new DataGridViewTextBoxColumn();
            fechaNacimientoPaciente = new DataGridViewTextBoxColumn();
            edadPaciente = new DataGridViewTextBoxColumn();
            direccionPaciente = new DataGridViewTextBoxColumn();
            sexo_cadena = new DataGridViewTextBoxColumn();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            btnBuscar = new Button();
            btnAgregarHistoriaClinica = new Button();
            btnVerHistoriaClinica = new Button();
            btnVerHorario = new Button();
            statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // statusStrip2
            // 
            statusStrip2.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabelDni, toolStripStatusLabelUsuario, toolStripStatusLabelRol, toolStripStatusLabelEspecialidad, lblSesion });
            statusStrip2.Location = new Point(0, 639);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Padding = new Padding(1, 0, 20, 0);
            statusStrip2.Size = new Size(1311, 22);
            statusStrip2.TabIndex = 11;
            statusStrip2.Text = "statusStrip2";
            // 
            // ToolStripStatusLabelDni
            // 
            ToolStripStatusLabelDni.Name = "ToolStripStatusLabelDni";
            ToolStripStatusLabelDni.Size = new Size(28, 17);
            ToolStripStatusLabelDni.Text = "Dni:";
            // 
            // toolStripStatusLabelUsuario
            // 
            toolStripStatusLabelUsuario.Name = "toolStripStatusLabelUsuario";
            toolStripStatusLabelUsuario.Size = new Size(50, 17);
            toolStripStatusLabelUsuario.Text = "Usuario:";
            // 
            // toolStripStatusLabelRol
            // 
            toolStripStatusLabelRol.Name = "toolStripStatusLabelRol";
            toolStripStatusLabelRol.Size = new Size(27, 17);
            toolStripStatusLabelRol.Text = "Rol:";
            // 
            // toolStripStatusLabelEspecialidad
            // 
            toolStripStatusLabelEspecialidad.Name = "toolStripStatusLabelEspecialidad";
            toolStripStatusLabelEspecialidad.Size = new Size(75, 17);
            toolStripStatusLabelEspecialidad.Text = "Especialidad:";
            // 
            // lblSesion
            // 
            lblSesion.Name = "lblSesion";
            lblSesion.Size = new Size(51, 17);
            lblSesion.Text = "Seccion:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblCodigoDentista
            // 
            lblCodigoDentista.Anchor = AnchorStyles.Top;
            lblCodigoDentista.Location = new Point(56, 39);
            lblCodigoDentista.Margin = new Padding(4);
            lblCodigoDentista.MaxLength = 20;
            lblCodigoDentista.Name = "lblCodigoDentista";
            lblCodigoDentista.ReadOnly = true;
            lblCodigoDentista.Size = new Size(125, 27);
            lblCodigoDentista.TabIndex = 98;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { idPaciente, idCita, fechaCita, horaCita, estado_cadena, nombrePaciente, apellidoPaciente, dni, correoPaciente, telefonoPaciente, fechaNacimientoPaciente, edadPaciente, direccionPaciente, sexo_cadena });
            dtgDatos.Location = new Point(35, 100);
            dtgDatos.Margin = new Padding(4);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.Size = new Size(1247, 443);
            dtgDatos.TabIndex = 99;
            dtgDatos.SelectionChanged += dtgDatos_SelectionChanged;
            // 
            // idPaciente
            // 
            idPaciente.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            idPaciente.DataPropertyName = "idPaciente";
            idPaciente.HeaderText = "ID";
            idPaciente.Name = "idPaciente";
            idPaciente.ReadOnly = true;
            idPaciente.Width = 52;
            // 
            // idCita
            // 
            idCita.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            idCita.DataPropertyName = "idCita";
            idCita.HeaderText = "ID Cita";
            idCita.Name = "idCita";
            idCita.ReadOnly = true;
            idCita.Width = 83;
            // 
            // fechaCita
            // 
            fechaCita.DataPropertyName = "fechaCita";
            fechaCita.HeaderText = "Fecha Cita";
            fechaCita.Name = "fechaCita";
            fechaCita.ReadOnly = true;
            // 
            // horaCita
            // 
            horaCita.DataPropertyName = "horaCita";
            horaCita.HeaderText = "Hora Cita";
            horaCita.Name = "horaCita";
            horaCita.ReadOnly = true;
            // 
            // estado_cadena
            // 
            estado_cadena.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            estado_cadena.DataPropertyName = "estado_cadena";
            estado_cadena.HeaderText = "Estado Cita";
            estado_cadena.Name = "estado_cadena";
            estado_cadena.ReadOnly = true;
            estado_cadena.Width = 116;
            // 
            // nombrePaciente
            // 
            nombrePaciente.DataPropertyName = "nombrePaciente";
            nombrePaciente.HeaderText = "Nombre";
            nombrePaciente.Name = "nombrePaciente";
            nombrePaciente.ReadOnly = true;
            // 
            // apellidoPaciente
            // 
            apellidoPaciente.DataPropertyName = "apellidoPaciente";
            apellidoPaciente.HeaderText = "Apellido";
            apellidoPaciente.Name = "apellidoPaciente";
            apellidoPaciente.ReadOnly = true;
            // 
            // dni
            // 
            dni.DataPropertyName = "dni";
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // correoPaciente
            // 
            correoPaciente.DataPropertyName = "correoPaciente";
            correoPaciente.HeaderText = "Correo";
            correoPaciente.Name = "correoPaciente";
            correoPaciente.ReadOnly = true;
            // 
            // telefonoPaciente
            // 
            telefonoPaciente.DataPropertyName = "telefonoPaciente";
            telefonoPaciente.HeaderText = "Telefono";
            telefonoPaciente.Name = "telefonoPaciente";
            telefonoPaciente.ReadOnly = true;
            // 
            // fechaNacimientoPaciente
            // 
            fechaNacimientoPaciente.DataPropertyName = "fechaNacimientoPaciente";
            fechaNacimientoPaciente.HeaderText = "Fecha de Nacimiento";
            fechaNacimientoPaciente.Name = "fechaNacimientoPaciente";
            fechaNacimientoPaciente.ReadOnly = true;
            // 
            // edadPaciente
            // 
            edadPaciente.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            edadPaciente.DataPropertyName = "edadPaciente";
            edadPaciente.HeaderText = "Edad";
            edadPaciente.Name = "edadPaciente";
            edadPaciente.ReadOnly = true;
            edadPaciente.Width = 77;
            // 
            // direccionPaciente
            // 
            direccionPaciente.DataPropertyName = "direccionPaciente";
            direccionPaciente.HeaderText = "Dirección";
            direccionPaciente.Name = "direccionPaciente";
            direccionPaciente.ReadOnly = true;
            // 
            // sexo_cadena
            // 
            sexo_cadena.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            sexo_cadena.DataPropertyName = "sexo_cadena";
            sexo_cadena.HeaderText = "Sexo";
            sexo_cadena.Name = "sexo_cadena";
            sexo_cadena.ReadOnly = true;
            sexo_cadena.Width = 71;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Anchor = AnchorStyles.Top;
            dtpFechaInicio.Location = new Point(245, 39);
            dtpFechaInicio.Margin = new Padding(4);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(284, 27);
            dtpFechaInicio.TabIndex = 100;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Anchor = AnchorStyles.Top;
            dtpFechaFin.Location = new Point(588, 39);
            dtpFechaFin.Margin = new Padding(4);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(284, 27);
            dtpFechaFin.TabIndex = 101;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.Location = new Point(919, 36);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(107, 32);
            btnBuscar.TabIndex = 102;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregarHistoriaClinica
            // 
            btnAgregarHistoriaClinica.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregarHistoriaClinica.Location = new Point(56, 567);
            btnAgregarHistoriaClinica.Margin = new Padding(4);
            btnAgregarHistoriaClinica.Name = "btnAgregarHistoriaClinica";
            btnAgregarHistoriaClinica.Size = new Size(193, 50);
            btnAgregarHistoriaClinica.TabIndex = 103;
            btnAgregarHistoriaClinica.Text = "HistoriaClinica";
            btnAgregarHistoriaClinica.UseVisualStyleBackColor = true;
            btnAgregarHistoriaClinica.Click += btnAgregarHistoriaClinica_Click;
            // 
            // btnVerHistoriaClinica
            // 
            btnVerHistoriaClinica.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVerHistoriaClinica.Location = new Point(271, 567);
            btnVerHistoriaClinica.Margin = new Padding(4);
            btnVerHistoriaClinica.Name = "btnVerHistoriaClinica";
            btnVerHistoriaClinica.Size = new Size(193, 50);
            btnVerHistoriaClinica.TabIndex = 104;
            btnVerHistoriaClinica.Text = "VerHistoriaClinica";
            btnVerHistoriaClinica.UseVisualStyleBackColor = true;
            btnVerHistoriaClinica.Click += btnVerHistoriaClinica_Click;
            // 
            // btnVerHorario
            // 
            btnVerHorario.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVerHorario.FlatStyle = FlatStyle.Popup;
            btnVerHorario.Location = new Point(1047, 576);
            btnVerHorario.Margin = new Padding(4);
            btnVerHorario.Name = "btnVerHorario";
            btnVerHorario.Size = new Size(225, 33);
            btnVerHorario.TabIndex = 105;
            btnVerHorario.Text = "VerHorario";
            btnVerHorario.UseVisualStyleBackColor = true;
            btnVerHorario.Click += btnVerHorario_Click;
            // 
            // PrincipalDentista
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 661);
            Controls.Add(btnVerHorario);
            Controls.Add(btnVerHistoriaClinica);
            Controls.Add(btnAgregarHistoriaClinica);
            Controls.Add(btnBuscar);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(dtgDatos);
            Controls.Add(lblCodigoDentista);
            Controls.Add(statusStrip2);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PrincipalDentista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PRINCIPAL DENTISTA";
            WindowState = FormWindowState.Maximized;
            Load += PrincipalDentista_Load;
            Resize += PrincipalDentista_Resize;
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip2;
        private ToolStripStatusLabel toolStripStatusLabelRol;
        private ToolStripStatusLabel toolStripStatusLabelUsuario;
        private ToolStripStatusLabel lblSesion;
        private System.Windows.Forms.Timer timer1;
        private TextBox lblCodigoDentista;
        private ToolStripStatusLabel toolStripStatusLabelEspecialidad;
        private ToolStripStatusLabel ToolStripStatusLabelDni;
        private DataGridView dtgDatos;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private Button btnBuscar;
        private Button btnAgregarHistoriaClinica;
        private Button btnVerHistoriaClinica;
        private DataGridViewTextBoxColumn idPaciente;
        private DataGridViewTextBoxColumn idCita;
        private DataGridViewTextBoxColumn fechaCita;
        private DataGridViewTextBoxColumn horaCita;
        private DataGridViewTextBoxColumn estado_cadena;
        private DataGridViewTextBoxColumn nombrePaciente;
        private DataGridViewTextBoxColumn apellidoPaciente;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn correoPaciente;
        private DataGridViewTextBoxColumn telefonoPaciente;
        private DataGridViewTextBoxColumn fechaNacimientoPaciente;
        private DataGridViewTextBoxColumn edadPaciente;
        private DataGridViewTextBoxColumn direccionPaciente;
        private DataGridViewTextBoxColumn sexo_cadena;
        private Button btnVerHorario;
    }
}