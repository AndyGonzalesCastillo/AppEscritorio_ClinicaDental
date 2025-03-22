namespace Windows_ClinicaDental
{
    partial class EditarHistoriaClinicaDentista
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
            lblCodigoCita = new Label();
            lblCodigoDentista = new Label();
            btnCancelar = new Button();
            btnActualizarHistoriaClinica = new Button();
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
            lblCodigoHistoria = new Label();
            btnEditarHistoriaClinica = new Button();
            SuspendLayout();
            // 
            // lblCodigoCita
            // 
            lblCodigoCita.BorderStyle = BorderStyle.Fixed3D;
            lblCodigoCita.Location = new Point(1002, 144);
            lblCodigoCita.Margin = new Padding(4, 0, 4, 0);
            lblCodigoCita.Name = "lblCodigoCita";
            lblCodigoCita.Size = new Size(132, 24);
            lblCodigoCita.TabIndex = 154;
            // 
            // lblCodigoDentista
            // 
            lblCodigoDentista.BorderStyle = BorderStyle.Fixed3D;
            lblCodigoDentista.Location = new Point(1002, 93);
            lblCodigoDentista.Margin = new Padding(4, 0, 4, 0);
            lblCodigoDentista.Name = "lblCodigoDentista";
            lblCodigoDentista.Size = new Size(132, 24);
            lblCodigoDentista.TabIndex = 153;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(320, 545);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(215, 60);
            btnCancelar.TabIndex = 152;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnActualizarHistoriaClinica
            // 
            btnActualizarHistoriaClinica.Location = new Point(65, 545);
            btnActualizarHistoriaClinica.Margin = new Padding(4);
            btnActualizarHistoriaClinica.Name = "btnActualizarHistoriaClinica";
            btnActualizarHistoriaClinica.Size = new Size(215, 60);
            btnActualizarHistoriaClinica.TabIndex = 151;
            btnActualizarHistoriaClinica.Text = "ActualizarHistoriaClinica";
            btnActualizarHistoriaClinica.UseVisualStyleBackColor = true;
            btnActualizarHistoriaClinica.Click += btnActualizarHistoriaClinica_Click;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(49, 383);
            txtObservaciones.Margin = new Padding(4);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(1121, 136);
            txtObservaciones.TabIndex = 150;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 341);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 149;
            label4.Text = "OBSERVACIONES:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 149);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 148;
            label2.Text = "DESCRIPCIÓN:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(49, 185);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(896, 130);
            txtDescripcion.TabIndex = 147;
            // 
            // cboTratamiento
            // 
            cboTratamiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTratamiento.FormattingEnabled = true;
            cboTratamiento.Items.AddRange(new object[] { "--Seleccione--", "Mujer", "Hombre" });
            cboTratamiento.Location = new Point(320, 93);
            cboTratamiento.Margin = new Padding(4);
            cboTratamiento.Name = "cboTratamiento";
            cboTratamiento.Size = new Size(503, 29);
            cboTratamiento.TabIndex = 146;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(167, 96);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(129, 21);
            label8.TabIndex = 145;
            label8.Text = "TRATAMIENTO:";
            // 
            // lblCodigoPaciente
            // 
            lblCodigoPaciente.Location = new Point(995, 39);
            lblCodigoPaciente.Margin = new Padding(4);
            lblCodigoPaciente.MaxLength = 20;
            lblCodigoPaciente.Name = "lblCodigoPaciente";
            lblCodigoPaciente.ReadOnly = true;
            lblCodigoPaciente.Size = new Size(147, 27);
            lblCodigoPaciente.TabIndex = 144;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(215, 39);
            txtDni.Margin = new Padding(4);
            txtDni.MaxLength = 20;
            txtDni.Name = "txtDni";
            txtDni.ReadOnly = true;
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 143;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 42);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 142;
            label3.Text = "DNI:";
            // 
            // txtApellidosNombre
            // 
            txtApellidosNombre.Location = new Point(571, 39);
            txtApellidosNombre.Margin = new Padding(4);
            txtApellidosNombre.MaxLength = 20;
            txtApellidosNombre.Name = "txtApellidosNombre";
            txtApellidosNombre.ReadOnly = true;
            txtApellidosNombre.Size = new Size(317, 27);
            txtApellidosNombre.TabIndex = 141;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(372, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 21);
            label1.TabIndex = 140;
            label1.Text = "APELLIDOS Y NOMBRES:";
            // 
            // lblCodigoHistoria
            // 
            lblCodigoHistoria.BorderStyle = BorderStyle.Fixed3D;
            lblCodigoHistoria.Location = new Point(1002, 195);
            lblCodigoHistoria.Margin = new Padding(4, 0, 4, 0);
            lblCodigoHistoria.Name = "lblCodigoHistoria";
            lblCodigoHistoria.Size = new Size(132, 24);
            lblCodigoHistoria.TabIndex = 155;
            // 
            // btnEditarHistoriaClinica
            // 
            btnEditarHistoriaClinica.Location = new Point(969, 270);
            btnEditarHistoriaClinica.Margin = new Padding(4);
            btnEditarHistoriaClinica.Name = "btnEditarHistoriaClinica";
            btnEditarHistoriaClinica.Size = new Size(201, 60);
            btnEditarHistoriaClinica.TabIndex = 156;
            btnEditarHistoriaClinica.Text = "Editar";
            btnEditarHistoriaClinica.UseVisualStyleBackColor = true;
            btnEditarHistoriaClinica.Click += btnEditarHistoriaClinica_Click;
            // 
            // EditarHistoriaClinicaDentista
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 645);
            Controls.Add(btnEditarHistoriaClinica);
            Controls.Add(lblCodigoHistoria);
            Controls.Add(lblCodigoCita);
            Controls.Add(lblCodigoDentista);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizarHistoriaClinica);
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
            Name = "EditarHistoriaClinicaDentista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDITAR HISTORIAL DE CLINICA";
            Load += EditarHistoriaClinicaDentista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigoCita;
        private Label lblCodigoDentista;
        private Button btnCancelar;
        private Button btnActualizarHistoriaClinica;
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
        private Label lblCodigoHistoria;
        private Button btnEditarHistoriaClinica;
    }
}