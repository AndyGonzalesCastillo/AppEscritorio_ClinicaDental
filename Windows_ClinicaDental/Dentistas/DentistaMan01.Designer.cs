namespace Windows_ClinicaDental.Dentistas
{
    partial class DentistaMan01
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
            idDentista = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            apellidos = new DataGridViewTextBoxColumn();
            nombres = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            fechaNacimiento = new DataGridViewTextBoxColumn();
            edad = new DataGridViewTextBoxColumn();
            sexo_cadena = new DataGridViewTextBoxColumn();
            nombreEspecialidad = new DataGridViewTextBoxColumn();
            estadoDentista_cadena = new DataGridViewTextBoxColumn();
            btnCerrar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            lblRegistros = new Label();
            label2 = new Label();
            txtFiltro = new TextBox();
            label1 = new Label();
            btnAgregarHorario = new Button();
            btnVerHorario = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { idDentista, dni, apellidos, nombres, telefono, correo, direccion, fechaNacimiento, edad, sexo_cadena, nombreEspecialidad, estadoDentista_cadena });
            dtgDatos.Location = new Point(27, 90);
            dtgDatos.Margin = new Padding(4);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1119, 311);
            dtgDatos.TabIndex = 96;
            // 
            // idDentista
            // 
            idDentista.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDentista.DataPropertyName = "idDentista";
            idDentista.HeaderText = "ID";
            idDentista.Name = "idDentista";
            idDentista.ReadOnly = true;
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
            direccion.HeaderText = "Dirección";
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
            edad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            edad.DataPropertyName = "edad";
            edad.HeaderText = "Edad";
            edad.Name = "edad";
            edad.ReadOnly = true;
            // 
            // sexo_cadena
            // 
            sexo_cadena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sexo_cadena.DataPropertyName = "sexo_cadena";
            sexo_cadena.HeaderText = "Sexo";
            sexo_cadena.Name = "sexo_cadena";
            sexo_cadena.ReadOnly = true;
            // 
            // nombreEspecialidad
            // 
            nombreEspecialidad.DataPropertyName = "nombreEspecialidad";
            nombreEspecialidad.HeaderText = "Especialidad";
            nombreEspecialidad.Name = "nombreEspecialidad";
            nombreEspecialidad.ReadOnly = true;
            // 
            // estadoDentista_cadena
            // 
            estadoDentista_cadena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            estadoDentista_cadena.DataPropertyName = "estadoDentista_cadena";
            estadoDentista_cadena.HeaderText = "Estado";
            estadoDentista_cadena.Name = "estadoDentista_cadena";
            estadoDentista_cadena.ReadOnly = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1011, 473);
            btnCerrar.Margin = new Padding(4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(136, 46);
            btnCerrar.TabIndex = 95;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(792, 473);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 46);
            btnEliminar.TabIndex = 94;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(632, 473);
            btnActualizar.Margin = new Padding(4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(136, 46);
            btnActualizar.TabIndex = 93;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(472, 473);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(136, 46);
            btnAgregar.TabIndex = 92;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.BackColor = SystemColors.Control;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.ForeColor = SystemColors.ControlText;
            lblRegistros.Location = new Point(1027, 419);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(119, 34);
            lblRegistros.TabIndex = 91;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(940, 433);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 90;
            label2.Text = "Registros";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(289, 30);
            txtFiltro.Margin = new Padding(4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(433, 27);
            txtFiltro.TabIndex = 89;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 21);
            label1.TabIndex = 88;
            label1.Text = "INGRESE SU APELLIDO:";
            // 
            // btnAgregarHorario
            // 
            btnAgregarHorario.Location = new Point(47, 420);
            btnAgregarHorario.Margin = new Padding(4);
            btnAgregarHorario.Name = "btnAgregarHorario";
            btnAgregarHorario.Size = new Size(225, 33);
            btnAgregarHorario.TabIndex = 97;
            btnAgregarHorario.Text = "AgregarHorario";
            btnAgregarHorario.UseVisualStyleBackColor = true;
            btnAgregarHorario.Click += btnAgregarHorario_Click;
            // 
            // btnVerHorario
            // 
            btnVerHorario.Location = new Point(47, 461);
            btnVerHorario.Margin = new Padding(4);
            btnVerHorario.Name = "btnVerHorario";
            btnVerHorario.Size = new Size(225, 33);
            btnVerHorario.TabIndex = 98;
            btnVerHorario.Text = "VerHorario";
            btnVerHorario.UseVisualStyleBackColor = true;
            btnVerHorario.Click += btnVerHorario_Click;
            // 
            // DentistaMan01
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 535);
            Controls.Add(btnVerHorario);
            Controls.Add(btnAgregarHorario);
            Controls.Add(dtgDatos);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DentistaMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DENTISTA";
            Load += DentistaMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDatos;
        private Button btnCerrar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private Label lblRegistros;
        private Label label2;
        private TextBox txtFiltro;
        private Label label1;
        private Button btnAgregarHorario;
        private Button btnVerHorario;
        private DataGridViewTextBoxColumn idDentista;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn apellidos;
        private DataGridViewTextBoxColumn nombres;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn fechaNacimiento;
        private DataGridViewTextBoxColumn edad;
        private DataGridViewTextBoxColumn sexo_cadena;
        private DataGridViewTextBoxColumn nombreEspecialidad;
        private DataGridViewTextBoxColumn estadoDentista_cadena;
    }
}