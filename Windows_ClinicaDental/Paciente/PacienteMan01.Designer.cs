namespace Windows_ClinicaDental.Paciente
{
    partial class PacienteMan01
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
            btnVerHistorialMedico = new Button();
            btnVerCitas = new Button();
            btnAgregarCita = new Button();
            btnCerrar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            lblRegistros = new Label();
            label2 = new Label();
            dtgDatos = new DataGridView();
            idPaciente = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            apellidos = new DataGridViewTextBoxColumn();
            nombres = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            fechaNacimiento = new DataGridViewTextBoxColumn();
            edad = new DataGridViewTextBoxColumn();
            sexo_cadena = new DataGridViewTextBoxColumn();
            estado_cadena = new DataGridViewTextBoxColumn();
            txtFiltro = new TextBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // btnVerHistorialMedico
            // 
            btnVerHistorialMedico.Location = new Point(407, 480);
            btnVerHistorialMedico.Margin = new Padding(4);
            btnVerHistorialMedico.Name = "btnVerHistorialMedico";
            btnVerHistorialMedico.Size = new Size(173, 46);
            btnVerHistorialMedico.TabIndex = 51;
            btnVerHistorialMedico.Text = "Ver Historial Medico";
            btnVerHistorialMedico.UseVisualStyleBackColor = true;
            btnVerHistorialMedico.Click += btnVerHistorialMedico_Click;
            // 
            // btnVerCitas
            // 
            btnVerCitas.Location = new Point(228, 480);
            btnVerCitas.Margin = new Padding(4);
            btnVerCitas.Name = "btnVerCitas";
            btnVerCitas.Size = new Size(136, 46);
            btnVerCitas.TabIndex = 50;
            btnVerCitas.Text = "Ver Citas";
            btnVerCitas.UseVisualStyleBackColor = true;
            btnVerCitas.Click += btnVerCitas_Click;
            // 
            // btnAgregarCita
            // 
            btnAgregarCita.Location = new Point(57, 480);
            btnAgregarCita.Margin = new Padding(4);
            btnAgregarCita.Name = "btnAgregarCita";
            btnAgregarCita.Size = new Size(136, 46);
            btnAgregarCita.TabIndex = 49;
            btnAgregarCita.Text = "Cita";
            btnAgregarCita.UseVisualStyleBackColor = true;
            btnAgregarCita.Click += btnAgregarCita_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1417, 797);
            btnCerrar.Margin = new Padding(4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(136, 46);
            btnCerrar.TabIndex = 48;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1187, 797);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 46);
            btnEliminar.TabIndex = 47;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(860, 480);
            btnActualizar.Margin = new Padding(4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(136, 46);
            btnActualizar.TabIndex = 46;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(700, 480);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(136, 46);
            btnAgregar.TabIndex = 45;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.BackColor = SystemColors.Control;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.ForeColor = SystemColors.ControlText;
            lblRegistros.Location = new Point(1014, 417);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(119, 34);
            lblRegistros.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1346, 756);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 42;
            label2.Text = "Registros";
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { idPaciente, dni, apellidos, nombres, telefono, correo, direccion, fechaNacimiento, edad, sexo_cadena, estado_cadena });
            dtgDatos.Location = new Point(22, 100);
            dtgDatos.Margin = new Padding(4);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1119, 302);
            dtgDatos.TabIndex = 43;
            // 
            // idPaciente
            // 
            idPaciente.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            idPaciente.DataPropertyName = "idPaciente";
            idPaciente.HeaderText = "Codigo";
            idPaciente.Name = "idPaciente";
            idPaciente.ReadOnly = true;
            idPaciente.Resizable = DataGridViewTriState.False;
            idPaciente.Width = 93;
            // 
            // dni
            // 
            dni.DataPropertyName = "dni";
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // apellidos
            // 
            apellidos.DataPropertyName = "apellidos";
            apellidos.HeaderText = "Apellidos";
            apellidos.Name = "apellidos";
            apellidos.ReadOnly = true;
            // 
            // nombres
            // 
            nombres.DataPropertyName = "nombres";
            nombres.HeaderText = "Nombres";
            nombres.Name = "nombres";
            nombres.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.DataPropertyName = "telefono";
            telefono.HeaderText = "Telefono";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // correo
            // 
            correo.DataPropertyName = "correo";
            correo.HeaderText = "Correo";
            correo.Name = "correo";
            correo.ReadOnly = true;
            // 
            // direccion
            // 
            direccion.DataPropertyName = "direccion";
            direccion.HeaderText = "Direccion";
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.DataPropertyName = "fechaNacimiento";
            fechaNacimiento.HeaderText = "Fecha de Nacimiento";
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.ReadOnly = true;
            // 
            // edad
            // 
            edad.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            edad.DataPropertyName = "edad";
            edad.HeaderText = "Edad";
            edad.Name = "edad";
            edad.ReadOnly = true;
            edad.Width = 77;
            // 
            // sexo_cadena
            // 
            sexo_cadena.DataPropertyName = "sexo_cadena";
            sexo_cadena.HeaderText = "Sexo";
            sexo_cadena.Name = "sexo_cadena";
            sexo_cadena.ReadOnly = true;
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
            // txtFiltro
            // 
            txtFiltro.Location = new Point(273, 34);
            txtFiltro.Margin = new Padding(4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(433, 27);
            txtFiltro.TabIndex = 41;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 21);
            label1.TabIndex = 40;
            label1.Text = "INGRESE SU APELLIDO:";
            // 
            // button1
            // 
            button1.Location = new Point(1014, 480);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(136, 46);
            button1.TabIndex = 96;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PacienteMan01
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 557);
            Controls.Add(button1);
            Controls.Add(btnVerHistorialMedico);
            Controls.Add(btnVerCitas);
            Controls.Add(btnAgregarCita);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dtgDatos);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PacienteMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PACIENTE";
            Load += PacienteMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerHistorialMedico;
        private Button btnVerCitas;
        private Button btnAgregarCita;
        private Button btnCerrar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private Label lblRegistros;
        private Label label2;
        private DataGridView dtgDatos;
        private TextBox txtFiltro;
        private Label label1;
        private DataGridViewTextBoxColumn idPaciente;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn apellidos;
        private DataGridViewTextBoxColumn nombres;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn fechaNacimiento;
        private DataGridViewTextBoxColumn edad;
        private DataGridViewTextBoxColumn sexo_cadena;
        private DataGridViewTextBoxColumn estado_cadena;
        private Button button1;
    }
}