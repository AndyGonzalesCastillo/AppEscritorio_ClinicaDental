namespace Windows_ClinicaDental
{
    partial class HistoriaClinicaDentista
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
            btnAgregarHistoriaClinica = new Button();
            txtObservaciones = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            cboTratamiento = new ComboBox();
            label8 = new Label();
            lblCodigoPaciente = new TextBox();
            txtDni = new TextBox();
            label3 = new Label();
            txtApellidosNombre = new TextBox();
            label1 = new Label();
            lblCodigoDentista = new Label();
            lblCodigoCita = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(355, 548);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(215, 60);
            btnCancelar.TabIndex = 137;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarHistoriaClinica
            // 
            btnAgregarHistoriaClinica.Location = new Point(100, 548);
            btnAgregarHistoriaClinica.Margin = new Padding(4);
            btnAgregarHistoriaClinica.Name = "btnAgregarHistoriaClinica";
            btnAgregarHistoriaClinica.Size = new Size(215, 60);
            btnAgregarHistoriaClinica.TabIndex = 136;
            btnAgregarHistoriaClinica.Text = "AgregarHistoriaClinica";
            btnAgregarHistoriaClinica.UseVisualStyleBackColor = true;
            btnAgregarHistoriaClinica.Click += btnAgregarHistoriaClinica_Click;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(84, 386);
            txtObservaciones.Margin = new Padding(4);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(1121, 136);
            txtObservaciones.TabIndex = 135;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 344);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 134;
            label4.Text = "OBSERVACIONES:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 152);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 133;
            label2.Text = "DESCRIPCIÓN:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(84, 188);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(1121, 136);
            txtDescripcion.TabIndex = 132;
            // 
            // cboTratamiento
            // 
            cboTratamiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTratamiento.FormattingEnabled = true;
            cboTratamiento.Items.AddRange(new object[] { "--Seleccione--", "Mujer", "Hombre" });
            cboTratamiento.Location = new Point(355, 96);
            cboTratamiento.Margin = new Padding(4);
            cboTratamiento.Name = "cboTratamiento";
            cboTratamiento.Size = new Size(503, 29);
            cboTratamiento.TabIndex = 130;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(202, 99);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(129, 21);
            label8.TabIndex = 129;
            label8.Text = "TRATAMIENTO:";
            // 
            // lblCodigoPaciente
            // 
            lblCodigoPaciente.Location = new Point(973, 42);
            lblCodigoPaciente.Margin = new Padding(4);
            lblCodigoPaciente.MaxLength = 20;
            lblCodigoPaciente.Name = "lblCodigoPaciente";
            lblCodigoPaciente.ReadOnly = true;
            lblCodigoPaciente.Size = new Size(125, 27);
            lblCodigoPaciente.TabIndex = 128;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(250, 42);
            txtDni.Margin = new Padding(4);
            txtDni.MaxLength = 20;
            txtDni.Name = "txtDni";
            txtDni.ReadOnly = true;
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 127;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 45);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 126;
            label3.Text = "DNI:";
            // 
            // txtApellidosNombre
            // 
            txtApellidosNombre.Location = new Point(606, 42);
            txtApellidosNombre.Margin = new Padding(4);
            txtApellidosNombre.MaxLength = 20;
            txtApellidosNombre.Name = "txtApellidosNombre";
            txtApellidosNombre.ReadOnly = true;
            txtApellidosNombre.Size = new Size(317, 27);
            txtApellidosNombre.TabIndex = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(407, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 21);
            label1.TabIndex = 124;
            label1.Text = "APELLIDOS y NOMBRES:";
            // 
            // lblCodigoDentista
            // 
            lblCodigoDentista.BorderStyle = BorderStyle.Fixed3D;
            lblCodigoDentista.Location = new Point(988, 96);
            lblCodigoDentista.Margin = new Padding(4, 0, 4, 0);
            lblCodigoDentista.Name = "lblCodigoDentista";
            lblCodigoDentista.Size = new Size(110, 24);
            lblCodigoDentista.TabIndex = 138;
            // 
            // lblCodigoCita
            // 
            lblCodigoCita.BorderStyle = BorderStyle.Fixed3D;
            lblCodigoCita.Location = new Point(988, 147);
            lblCodigoCita.Margin = new Padding(4, 0, 4, 0);
            lblCodigoCita.Name = "lblCodigoCita";
            lblCodigoCita.Size = new Size(110, 24);
            lblCodigoCita.TabIndex = 139;
            // 
            // HistoriaClinicaDentista
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 651);
            Controls.Add(lblCodigoCita);
            Controls.Add(lblCodigoDentista);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregarHistoriaClinica);
            Controls.Add(txtObservaciones);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(cboTratamiento);
            Controls.Add(label8);
            Controls.Add(lblCodigoPaciente);
            Controls.Add(txtDni);
            Controls.Add(label3);
            Controls.Add(txtApellidosNombre);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HistoriaClinicaDentista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HISTORIAL DE CLINICA";
            Load += HistoriaClinicaDentista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAgregarHistoriaClinica;
        private TextBox txtObservaciones;
        private Label label4;
        private Label label2;
        private TextBox txtDescripcion;
        private ComboBox cboTratamiento;
        private Label label8;
        private TextBox lblCodigoPaciente;
        private TextBox txtDni;
        private Label label3;
        private TextBox txtApellidosNombre;
        private Label label1;
        private Label lblCodigoDentista;
        private Label lblCodigoCita;
    }
}