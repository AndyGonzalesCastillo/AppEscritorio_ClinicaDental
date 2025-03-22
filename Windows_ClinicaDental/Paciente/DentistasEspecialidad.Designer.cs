namespace Windows_ClinicaDental.Paciente
{
    partial class DentistasEspecialidad
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
            lblCodigoPaciente = new TextBox();
            btnConsultarDisponibilidad = new Button();
            dtgDatos = new DataGridView();
            cboEspecialidad = new ComboBox();
            label8 = new Label();
            txtDni = new TextBox();
            label3 = new Label();
            txtApellidosNombre = new TextBox();
            label1 = new Label();
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
            estadoDentista_cadena = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // lblCodigoPaciente
            // 
            lblCodigoPaciente.Location = new Point(1035, 30);
            lblCodigoPaciente.Margin = new Padding(4);
            lblCodigoPaciente.MaxLength = 20;
            lblCodigoPaciente.Name = "lblCodigoPaciente";
            lblCodigoPaciente.ReadOnly = true;
            lblCodigoPaciente.Size = new Size(125, 27);
            lblCodigoPaciente.TabIndex = 97;
            // 
            // btnConsultarDisponibilidad
            // 
            btnConsultarDisponibilidad.Location = new Point(31, 584);
            btnConsultarDisponibilidad.Margin = new Padding(4);
            btnConsultarDisponibilidad.Name = "btnConsultarDisponibilidad";
            btnConsultarDisponibilidad.Size = new Size(186, 46);
            btnConsultarDisponibilidad.TabIndex = 2;
            btnConsultarDisponibilidad.Text = "Ver disponibilidad";
            btnConsultarDisponibilidad.UseVisualStyleBackColor = true;
            btnConsultarDisponibilidad.Click += btnConsultarDisponibilidad_Click;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { idDentista, dni, apellidos, nombres, telefono, correo, direccion, fechaNacimiento, edad, sexo_cadena, estadoDentista_cadena });
            dtgDatos.Location = new Point(31, 155);
            dtgDatos.Margin = new Padding(4);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1129, 400);
            dtgDatos.TabIndex = 1;
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Items.AddRange(new object[] { "--Seleccione--", "Mujer", "Hombre" });
            cboEspecialidad.Location = new Point(193, 87);
            cboEspecialidad.Margin = new Padding(4);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(503, 29);
            cboEspecialidad.TabIndex = 0;
            cboEspecialidad.SelectedIndexChanged += cboEspecialidad_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(78, 91);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(113, 21);
            label8.TabIndex = 93;
            label8.Text = "Especialidad:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(131, 31);
            txtDni.Margin = new Padding(4);
            txtDni.MaxLength = 20;
            txtDni.Name = "txtDni";
            txtDni.ReadOnly = true;
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 92;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 36);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 91;
            label3.Text = "DNI:";
            // 
            // txtApellidosNombre
            // 
            txtApellidosNombre.Location = new Point(527, 30);
            txtApellidosNombre.Margin = new Padding(4);
            txtApellidosNombre.MaxLength = 20;
            txtApellidosNombre.Name = "txtApellidosNombre";
            txtApellidosNombre.ReadOnly = true;
            txtApellidosNombre.Size = new Size(317, 27);
            txtApellidosNombre.TabIndex = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 89;
            label1.Text = "Apellidos y Nombres:";
            // 
            // idDentista
            // 
            idDentista.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            idDentista.DataPropertyName = "idDentista";
            idDentista.HeaderText = "ID";
            idDentista.Name = "idDentista";
            idDentista.ReadOnly = true;
            idDentista.Width = 52;
            // 
            // dni
            // 
            dni.DataPropertyName = "dni";
            dni.FillWeight = 79.28932F;
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // apellidos
            // 
            apellidos.DataPropertyName = "apellidos";
            apellidos.FillWeight = 79.28932F;
            apellidos.HeaderText = "Apellidos";
            apellidos.Name = "apellidos";
            apellidos.ReadOnly = true;
            // 
            // nombres
            // 
            nombres.DataPropertyName = "nombres";
            nombres.FillWeight = 79.28932F;
            nombres.HeaderText = "Nombres";
            nombres.Name = "nombres";
            nombres.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.DataPropertyName = "telefono";
            telefono.FillWeight = 79.28932F;
            telefono.HeaderText = "Telefono";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // correo
            // 
            correo.DataPropertyName = "correo";
            correo.FillWeight = 79.28932F;
            correo.HeaderText = "Correo";
            correo.Name = "correo";
            correo.ReadOnly = true;
            // 
            // direccion
            // 
            direccion.DataPropertyName = "direccion";
            direccion.FillWeight = 79.28932F;
            direccion.HeaderText = "Direccion";
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.DataPropertyName = "fechaNacimiento";
            fechaNacimiento.FillWeight = 79.28932F;
            fechaNacimiento.HeaderText = "Fecha deNacimiento";
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.ReadOnly = true;
            // 
            // edad
            // 
            edad.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            edad.DataPropertyName = "edad";
            edad.FillWeight = 79.28932F;
            edad.HeaderText = "Edad";
            edad.Name = "edad";
            edad.ReadOnly = true;
            edad.Width = 77;
            // 
            // sexo_cadena
            // 
            sexo_cadena.DataPropertyName = "sexo_cadena";
            sexo_cadena.FillWeight = 79.28932F;
            sexo_cadena.HeaderText = "Sexo";
            sexo_cadena.Name = "sexo_cadena";
            sexo_cadena.ReadOnly = true;
            // 
            // estadoDentista_cadena
            // 
            estadoDentista_cadena.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            estadoDentista_cadena.DataPropertyName = "estadoDentista_cadena";
            estadoDentista_cadena.FillWeight = 79.28932F;
            estadoDentista_cadena.HeaderText = "Estado";
            estadoDentista_cadena.Name = "estadoDentista_cadena";
            estadoDentista_cadena.ReadOnly = true;
            estadoDentista_cadena.Width = 89;
            // 
            // DentistasEspecialidad
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 660);
            Controls.Add(lblCodigoPaciente);
            Controls.Add(btnConsultarDisponibilidad);
            Controls.Add(dtgDatos);
            Controls.Add(cboEspecialidad);
            Controls.Add(label8);
            Controls.Add(txtDni);
            Controls.Add(label3);
            Controls.Add(txtApellidosNombre);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DentistasEspecialidad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DENTISTAS ESPECIALIDAD";
            Load += DentistasEspecialidad_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lblCodigoPaciente;
        private Button btnConsultarDisponibilidad;
        private DataGridView dtgDatos;
        private ComboBox cboEspecialidad;
        private Label label8;
        private TextBox txtDni;
        private Label label3;
        private TextBox txtApellidosNombre;
        private Label label1;
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
        private DataGridViewTextBoxColumn estadoDentista_cadena;
    }
}