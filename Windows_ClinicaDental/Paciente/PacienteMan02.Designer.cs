namespace Windows_ClinicaDental.Paciente
{
    partial class PacienteMan02
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
            btnCancelar = new Button();
            btnAgregar = new Button();
            cboSexo = new ComboBox();
            label8 = new Label();
            mskTel = new MaskedTextBox();
            label4 = new Label();
            txtDni = new MaskedTextBox();
            txtContraseña = new TextBox();
            label6 = new Label();
            chkestado = new CheckBox();
            dtpNacimiento = new DateTimePicker();
            label7 = new Label();
            label = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(649, 334);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(221, 46);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(649, 265);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(221, 46);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cboSexo
            // 
            cboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSexo.FormattingEnabled = true;
            cboSexo.Items.AddRange(new object[] { "--Seleccione--", "Mujer", "Hombre" });
            cboSexo.Location = new Point(644, 138);
            cboSexo.Margin = new Padding(4);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(171, 29);
            cboSexo.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(578, 142);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(54, 21);
            label8.TabIndex = 113;
            label8.Text = "SEXO:";
            // 
            // mskTel
            // 
            mskTel.Location = new Point(152, 88);
            mskTel.Margin = new Padding(6, 4, 6, 4);
            mskTel.Mask = "999999999";
            mskTel.Name = "mskTel";
            mskTel.Size = new Size(164, 27);
            mskTel.TabIndex = 1;
            // 
            // label4
            // 
            label4.Location = new Point(29, 89);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 111;
            label4.Text = "Telefono:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(644, 34);
            txtDni.Margin = new Padding(4);
            txtDni.Mask = "99999999";
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(141, 27);
            txtDni.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(644, 84);
            txtContraseña.Margin = new Padding(4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(284, 27);
            txtContraseña.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(514, 89);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(126, 21);
            label6.TabIndex = 108;
            label6.Text = "CONTRASEÑA:";
            // 
            // chkestado
            // 
            chkestado.AutoSize = true;
            chkestado.Location = new Point(649, 206);
            chkestado.Margin = new Padding(4);
            chkestado.Name = "chkestado";
            chkestado.Size = new Size(104, 25);
            chkestado.TabIndex = 7;
            chkestado.Text = "Activado";
            chkestado.UseVisualStyleBackColor = true;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.Location = new Point(212, 37);
            dtpNacimiento.Margin = new Padding(4);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(135, 27);
            dtpNacimiento.TabIndex = 0;
            dtpNacimiento.Value = new DateTime(2022, 11, 2, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 149);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 21);
            label7.TabIndex = 104;
            label7.Text = "Dirección:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(30, 161);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(84, 21);
            label.TabIndex = 102;
            label.Text = "CORREO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 42);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(181, 21);
            label5.TabIndex = 106;
            label5.Text = "Fecha de nacimiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 96);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 100;
            label2.Text = "APELLIDOS:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(574, 38);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 98;
            label3.Text = "DNI:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(152, 146);
            txtDireccion.Margin = new Padding(4);
            txtDireccion.MaxLength = 99;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(341, 27);
            txtDireccion.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(133, 150);
            txtCorreo.Margin = new Padding(4);
            txtCorreo.MaxLength = 320;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(317, 27);
            txtCorreo.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(133, 91);
            txtApellido.Margin = new Padding(4);
            txtApellido.MaxLength = 20;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(317, 27);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(133, 34);
            txtNombre.Margin = new Padding(4);
            txtNombre.MaxLength = 20;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(317, 27);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 96;
            label1.Text = "NOMBRES:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNacimiento);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(mskTel);
            groupBox1.Location = new Point(30, 206);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(526, 192);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS PERSONALES";
            // 
            // PacienteMan02
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 442);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(cboSexo);
            Controls.Add(label8);
            Controls.Add(txtDni);
            Controls.Add(txtContraseña);
            Controls.Add(label6);
            Controls.Add(chkestado);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtCorreo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PacienteMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NUEVO PACIENTE";
            Load += PacienteMan02_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAgregar;
        private ComboBox cboSexo;
        private Label label8;
        private MaskedTextBox mskTel;
        internal Label label4;
        private MaskedTextBox txtDni;
        private TextBox txtContraseña;
        private Label label6;
        private CheckBox chkestado;
        private DateTimePicker dtpNacimiento;
        private Label label7;
        private Label label;
        private Label label5;
        private Label label2;
        private Label label3;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label1;
        private GroupBox groupBox1;
    }
}