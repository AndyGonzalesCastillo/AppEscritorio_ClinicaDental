namespace Windows_ClinicaDental.Paciente
{
    partial class VerCitasPacientes
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
            dtgDatos = new DataGridView();
            idCita = new DataGridViewTextBoxColumn();
            fechaCita = new DataGridViewTextBoxColumn();
            horaCita = new DataGridViewTextBoxColumn();
            nombreDentista = new DataGridViewTextBoxColumn();
            nombreEspecialidad = new DataGridViewTextBoxColumn();
            motivoCita = new DataGridViewTextBoxColumn();
            estado_cadena = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(350, 556);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(414, 56);
            btnCancelar.TabIndex = 90;
            btnCancelar.Text = "Cancelar Cita";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { idCita, fechaCita, horaCita, nombreDentista, nombreEspecialidad, motivoCita, estado_cadena });
            dtgDatos.Location = new Point(27, 27);
            dtgDatos.Margin = new Padding(4);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1088, 493);
            dtgDatos.TabIndex = 89;
            // 
            // idCita
            // 
            idCita.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            idCita.DataPropertyName = "idCita";
            idCita.FillWeight = 1F;
            idCita.HeaderText = "Codigo";
            idCita.Name = "idCita";
            idCita.ReadOnly = true;
            idCita.Width = 93;
            // 
            // fechaCita
            // 
            fechaCita.DataPropertyName = "fechaCita";
            fechaCita.FillWeight = 42.37288F;
            fechaCita.HeaderText = "Fecha";
            fechaCita.Name = "fechaCita";
            fechaCita.ReadOnly = true;
            // 
            // horaCita
            // 
            horaCita.DataPropertyName = "horaCita";
            horaCita.FillWeight = 42.37288F;
            horaCita.HeaderText = "Hora";
            horaCita.Name = "horaCita";
            horaCita.ReadOnly = true;
            // 
            // nombreDentista
            // 
            nombreDentista.DataPropertyName = "nombreDentista";
            nombreDentista.FillWeight = 42.37288F;
            nombreDentista.HeaderText = "Dentista";
            nombreDentista.Name = "nombreDentista";
            nombreDentista.ReadOnly = true;
            // 
            // nombreEspecialidad
            // 
            nombreEspecialidad.DataPropertyName = "nombreEspecialidad";
            nombreEspecialidad.FillWeight = 42.37288F;
            nombreEspecialidad.HeaderText = "Especialidad";
            nombreEspecialidad.Name = "nombreEspecialidad";
            nombreEspecialidad.ReadOnly = true;
            // 
            // motivoCita
            // 
            motivoCita.DataPropertyName = "motivoCita";
            motivoCita.FillWeight = 42.37288F;
            motivoCita.HeaderText = "Motivo";
            motivoCita.Name = "motivoCita";
            motivoCita.ReadOnly = true;
            // 
            // estado_cadena
            // 
            estado_cadena.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            estado_cadena.DataPropertyName = "estado_cadena";
            estado_cadena.FillWeight = 1000F;
            estado_cadena.HeaderText = "Estado";
            estado_cadena.Name = "estado_cadena";
            estado_cadena.ReadOnly = true;
            estado_cadena.Width = 89;
            // 
            // VerCitasPacientes
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 647);
            Controls.Add(btnCancelar);
            Controls.Add(dtgDatos);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VerCitasPacientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CITAS DEL PACIENTE";
            Load += VerCitasPacientes_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancelar;
        private DataGridView dtgDatos;
        private DataGridViewTextBoxColumn idCita;
        private DataGridViewTextBoxColumn fechaCita;
        private DataGridViewTextBoxColumn horaCita;
        private DataGridViewTextBoxColumn nombreDentista;
        private DataGridViewTextBoxColumn nombreEspecialidad;
        private DataGridViewTextBoxColumn motivoCita;
        private DataGridViewTextBoxColumn estado_cadena;
    }
}