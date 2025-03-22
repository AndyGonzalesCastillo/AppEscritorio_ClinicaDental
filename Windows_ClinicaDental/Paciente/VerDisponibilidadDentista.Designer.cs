namespace Windows_ClinicaDental.Paciente
{
    partial class VerDisponibilidadDentista
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
            txtMotivoCita = new TextBox();
            lblCodigoPaciente = new Label();
            btnCita = new Button();
            txtDni = new TextBox();
            label3 = new Label();
            txtApellidosNombre = new TextBox();
            label1 = new Label();
            lblCodigoDentista = new Label();
            label2 = new Label();
            label4 = new Label();
            dtgDatos = new DataGridView();
            Hora = new DataGridViewTextBoxColumn();
            Lunes = new DataGridViewTextBoxColumn();
            Martes = new DataGridViewTextBoxColumn();
            Miércoles = new DataGridViewTextBoxColumn();
            Jueves = new DataGridViewTextBoxColumn();
            Viernes = new DataGridViewTextBoxColumn();
            Sábado = new DataGridViewTextBoxColumn();
            Domingo = new DataGridViewTextBoxColumn();
            label5 = new Label();
            lblRangoFechaSemana = new TextBox();
            btnSemanaPosterior = new Button();
            btnSemanaAnterior = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // txtMotivoCita
            // 
            txtMotivoCita.Location = new Point(856, 166);
            txtMotivoCita.Margin = new Padding(4);
            txtMotivoCita.Multiline = true;
            txtMotivoCita.Name = "txtMotivoCita";
            txtMotivoCita.Size = new Size(332, 301);
            txtMotivoCita.TabIndex = 0;
            // 
            // lblCodigoPaciente
            // 
            lblCodigoPaciente.BorderStyle = BorderStyle.Fixed3D;
            lblCodigoPaciente.Location = new Point(202, 78);
            lblCodigoPaciente.Margin = new Padding(4, 0, 4, 0);
            lblCodigoPaciente.Name = "lblCodigoPaciente";
            lblCodigoPaciente.Size = new Size(110, 24);
            lblCodigoPaciente.TabIndex = 106;
            // 
            // btnCita
            // 
            btnCita.Location = new Point(856, 489);
            btnCita.Margin = new Padding(4);
            btnCita.Name = "btnCita";
            btnCita.Size = new Size(186, 46);
            btnCita.TabIndex = 1;
            btnCita.Text = "Cita";
            btnCita.UseVisualStyleBackColor = true;
            btnCita.Click += btnCita_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(395, 32);
            txtDni.Margin = new Padding(4);
            txtDni.MaxLength = 20;
            txtDni.Name = "txtDni";
            txtDni.ReadOnly = true;
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 103;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 35);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 21);
            label3.TabIndex = 102;
            label3.Text = "Dni:";
            // 
            // txtApellidosNombre
            // 
            txtApellidosNombre.Location = new Point(739, 32);
            txtApellidosNombre.Margin = new Padding(4);
            txtApellidosNombre.MaxLength = 20;
            txtApellidosNombre.Name = "txtApellidosNombre";
            txtApellidosNombre.ReadOnly = true;
            txtApellidosNombre.Size = new Size(317, 27);
            txtApellidosNombre.TabIndex = 101;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(559, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 100;
            label1.Text = "Apellidos y Nombres:";
            // 
            // lblCodigoDentista
            // 
            lblCodigoDentista.BorderStyle = BorderStyle.Fixed3D;
            lblCodigoDentista.Location = new Point(202, 33);
            lblCodigoDentista.Margin = new Padding(4, 0, 4, 0);
            lblCodigoDentista.Name = "lblCodigoDentista";
            lblCodigoDentista.Size = new Size(110, 24);
            lblCodigoDentista.TabIndex = 99;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 21);
            label2.TabIndex = 108;
            label2.Text = "Codigo del Paciente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 35);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(170, 21);
            label4.TabIndex = 109;
            label4.Text = "Codigo del Dentista:";
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { Hora, Lunes, Martes, Miércoles, Jueves, Viernes, Sábado, Domingo });
            dtgDatos.Location = new Point(23, 141);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.Size = new Size(803, 326);
            dtgDatos.TabIndex = 110;
            // 
            // Hora
            // 
            Hora.DataPropertyName = "Hora";
            Hora.HeaderText = "Hora";
            Hora.Name = "Hora";
            Hora.ReadOnly = true;
            // 
            // Lunes
            // 
            Lunes.DataPropertyName = "Lunes";
            Lunes.HeaderText = "Lunes";
            Lunes.Name = "Lunes";
            Lunes.ReadOnly = true;
            // 
            // Martes
            // 
            Martes.DataPropertyName = "Martes";
            Martes.HeaderText = "Martes";
            Martes.Name = "Martes";
            Martes.ReadOnly = true;
            // 
            // Miércoles
            // 
            Miércoles.DataPropertyName = "Miércoles";
            Miércoles.HeaderText = "Miércoles";
            Miércoles.Name = "Miércoles";
            Miércoles.ReadOnly = true;
            // 
            // Jueves
            // 
            Jueves.DataPropertyName = "Jueves";
            Jueves.HeaderText = "Jueves";
            Jueves.Name = "Jueves";
            Jueves.ReadOnly = true;
            // 
            // Viernes
            // 
            Viernes.DataPropertyName = "Viernes";
            Viernes.HeaderText = "Viernes";
            Viernes.Name = "Viernes";
            Viernes.ReadOnly = true;
            // 
            // Sábado
            // 
            Sábado.DataPropertyName = "Sábado";
            Sábado.HeaderText = "Sábado";
            Sábado.Name = "Sábado";
            Sábado.ReadOnly = true;
            // 
            // Domingo
            // 
            Domingo.DataPropertyName = "Domingo";
            Domingo.HeaderText = "Domingo";
            Domingo.Name = "Domingo";
            Domingo.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(856, 141);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 113;
            label5.Text = "Motivo Cita:";
            // 
            // lblRangoFechaSemana
            // 
            lblRangoFechaSemana.Location = new Point(489, 93);
            lblRangoFechaSemana.MaxLength = 20;
            lblRangoFechaSemana.Name = "lblRangoFechaSemana";
            lblRangoFechaSemana.ReadOnly = true;
            lblRangoFechaSemana.Size = new Size(300, 27);
            lblRangoFechaSemana.TabIndex = 116;
            // 
            // btnSemanaPosterior
            // 
            btnSemanaPosterior.Location = new Point(806, 92);
            btnSemanaPosterior.Name = "btnSemanaPosterior";
            btnSemanaPosterior.Size = new Size(139, 31);
            btnSemanaPosterior.TabIndex = 115;
            btnSemanaPosterior.Text = "Siguiente Semana";
            btnSemanaPosterior.UseVisualStyleBackColor = true;
            btnSemanaPosterior.Click += btnSemanaPosterior_Click;
            // 
            // btnSemanaAnterior
            // 
            btnSemanaAnterior.Location = new Point(319, 93);
            btnSemanaAnterior.Name = "btnSemanaAnterior";
            btnSemanaAnterior.Size = new Size(151, 31);
            btnSemanaAnterior.TabIndex = 114;
            btnSemanaAnterior.Text = "Semana Anterior";
            btnSemanaAnterior.UseVisualStyleBackColor = true;
            btnSemanaAnterior.Click += btnSemanaAnterior_Click;
            // 
            // VerDisponibilidadDentista
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 612);
            Controls.Add(lblRangoFechaSemana);
            Controls.Add(btnSemanaPosterior);
            Controls.Add(btnSemanaAnterior);
            Controls.Add(label5);
            Controls.Add(dtgDatos);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtMotivoCita);
            Controls.Add(lblCodigoPaciente);
            Controls.Add(btnCita);
            Controls.Add(txtDni);
            Controls.Add(label3);
            Controls.Add(txtApellidosNombre);
            Controls.Add(label1);
            Controls.Add(lblCodigoDentista);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VerDisponibilidadDentista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DENTISTA DISPONIBILIDAD";
            Load += VerDisponibilidadDentista_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMotivoCita;
        private Label lblCodigoPaciente;
        private Button btnCita;
        private TextBox txtDni;
        private Label label3;
        private TextBox txtApellidosNombre;
        private Label label1;
        private Label lblCodigoDentista;
        private Label label2;
        private Label label4;
        private DataGridView dtgDatos;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Lunes;
        private DataGridViewTextBoxColumn Martes;
        private DataGridViewTextBoxColumn Miércoles;
        private DataGridViewTextBoxColumn Jueves;
        private DataGridViewTextBoxColumn Viernes;
        private DataGridViewTextBoxColumn Sábado;
        private DataGridViewTextBoxColumn Domingo;
        private Label label5;
        private TextBox lblRangoFechaSemana;
        private Button btnSemanaPosterior;
        private Button btnSemanaAnterior;
    }
}