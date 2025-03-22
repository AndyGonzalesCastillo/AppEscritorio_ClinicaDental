namespace Windows_ClinicaDental.Dentistas
{
    partial class VerHorario
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
            Hora = new DataGridViewTextBoxColumn();
            Lunes = new DataGridViewTextBoxColumn();
            Martes = new DataGridViewTextBoxColumn();
            Miércoles = new DataGridViewTextBoxColumn();
            Jueves = new DataGridViewTextBoxColumn();
            Viernes = new DataGridViewTextBoxColumn();
            Sábado = new DataGridViewTextBoxColumn();
            Domingo = new DataGridViewTextBoxColumn();
            lblRangoFechaSemana = new TextBox();
            btnSemanaPosterior = new Button();
            btnSemanaAnterior = new Button();
            txtDni = new TextBox();
            label3 = new Label();
            txtApellidosNombre = new TextBox();
            label1 = new Label();
            lblCodigoDentista = new Label();
            btnEliminarHora = new Button();
            btnEliminarDia = new Button();
            txtMotivo = new TextBox();
            gbColores = new GroupBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { Hora, Lunes, Martes, Miércoles, Jueves, Viernes, Sábado, Domingo });
            dtgDatos.Location = new Point(22, 146);
            dtgDatos.Margin = new Padding(4);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.Size = new Size(955, 456);
            dtgDatos.TabIndex = 150;
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
            // lblRangoFechaSemana
            // 
            lblRangoFechaSemana.Location = new Point(326, 91);
            lblRangoFechaSemana.Margin = new Padding(4);
            lblRangoFechaSemana.MaxLength = 20;
            lblRangoFechaSemana.Name = "lblRangoFechaSemana";
            lblRangoFechaSemana.ReadOnly = true;
            lblRangoFechaSemana.Size = new Size(427, 27);
            lblRangoFechaSemana.TabIndex = 153;
            // 
            // btnSemanaPosterior
            // 
            btnSemanaPosterior.Location = new Point(778, 89);
            btnSemanaPosterior.Margin = new Padding(4);
            btnSemanaPosterior.Name = "btnSemanaPosterior";
            btnSemanaPosterior.Size = new Size(199, 32);
            btnSemanaPosterior.TabIndex = 152;
            btnSemanaPosterior.Text = "Siguiente Semana";
            btnSemanaPosterior.UseVisualStyleBackColor = true;
            btnSemanaPosterior.Click += btnSemanaPosterior_Click;
            // 
            // btnSemanaAnterior
            // 
            btnSemanaAnterior.Location = new Point(127, 91);
            btnSemanaAnterior.Margin = new Padding(4);
            btnSemanaAnterior.Name = "btnSemanaAnterior";
            btnSemanaAnterior.Size = new Size(171, 32);
            btnSemanaAnterior.TabIndex = 151;
            btnSemanaAnterior.Text = "Semana Anterior";
            btnSemanaAnterior.UseVisualStyleBackColor = true;
            btnSemanaAnterior.Click += btnSemanaAnterior_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(264, 33);
            txtDni.Margin = new Padding(6);
            txtDni.MaxLength = 20;
            txtDni.Name = "txtDni";
            txtDni.ReadOnly = true;
            txtDni.Size = new Size(170, 27);
            txtDni.TabIndex = 157;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 36);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 21);
            label3.TabIndex = 156;
            label3.Text = "Dni:";
            // 
            // txtApellidosNombre
            // 
            txtApellidosNombre.Location = new Point(635, 33);
            txtApellidosNombre.Margin = new Padding(6);
            txtApellidosNombre.MaxLength = 20;
            txtApellidosNombre.Name = "txtApellidosNombre";
            txtApellidosNombre.ReadOnly = true;
            txtApellidosNombre.Size = new Size(342, 27);
            txtApellidosNombre.TabIndex = 155;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(454, 36);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 154;
            label1.Text = "Apellidos y Nombres:";
            // 
            // lblCodigoDentista
            // 
            lblCodigoDentista.BorderStyle = BorderStyle.Fixed3D;
            lblCodigoDentista.Location = new Point(30, 29);
            lblCodigoDentista.Margin = new Padding(6, 0, 6, 0);
            lblCodigoDentista.Name = "lblCodigoDentista";
            lblCodigoDentista.Size = new Size(157, 34);
            lblCodigoDentista.TabIndex = 158;
            // 
            // btnEliminarHora
            // 
            btnEliminarHora.Location = new Point(1013, 277);
            btnEliminarHora.Margin = new Padding(4);
            btnEliminarHora.Name = "btnEliminarHora";
            btnEliminarHora.Size = new Size(171, 53);
            btnEliminarHora.TabIndex = 159;
            btnEliminarHora.Text = "Eliminar Hora";
            btnEliminarHora.UseVisualStyleBackColor = true;
            btnEliminarHora.Click += btnEliminarHora_Click;
            // 
            // btnEliminarDia
            // 
            btnEliminarDia.Location = new Point(1013, 338);
            btnEliminarDia.Margin = new Padding(4);
            btnEliminarDia.Name = "btnEliminarDia";
            btnEliminarDia.Size = new Size(171, 53);
            btnEliminarDia.TabIndex = 160;
            btnEliminarDia.Text = "Eliminar Dia";
            btnEliminarDia.UseVisualStyleBackColor = true;
            btnEliminarDia.Click += btnEliminarDia_Click;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(1013, 451);
            txtMotivo.Margin = new Padding(6);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(257, 242);
            txtMotivo.TabIndex = 161;
            // 
            // gbColores
            // 
            gbColores.Location = new Point(1013, 13);
            gbColores.Margin = new Padding(4);
            gbColores.Name = "gbColores";
            gbColores.Padding = new Padding(4);
            gbColores.Size = new Size(177, 246);
            gbColores.TabIndex = 162;
            gbColores.TabStop = false;
            gbColores.Text = "Estados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1013, 407);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(186, 21);
            label2.TabIndex = 163;
            label2.Text = "Motivo De Eliminacion:";
            // 
            // VerHorario
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 715);
            Controls.Add(label2);
            Controls.Add(gbColores);
            Controls.Add(txtMotivo);
            Controls.Add(btnEliminarDia);
            Controls.Add(btnEliminarHora);
            Controls.Add(lblCodigoDentista);
            Controls.Add(txtDni);
            Controls.Add(label3);
            Controls.Add(txtApellidosNombre);
            Controls.Add(label1);
            Controls.Add(lblRangoFechaSemana);
            Controls.Add(btnSemanaPosterior);
            Controls.Add(btnSemanaAnterior);
            Controls.Add(dtgDatos);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VerHorario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VER HORARIO";
            Load += VerHorario_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDatos;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Lunes;
        private DataGridViewTextBoxColumn Martes;
        private DataGridViewTextBoxColumn Miércoles;
        private DataGridViewTextBoxColumn Jueves;
        private DataGridViewTextBoxColumn Viernes;
        private DataGridViewTextBoxColumn Sábado;
        private DataGridViewTextBoxColumn Domingo;
        private TextBox lblRangoFechaSemana;
        private Button btnSemanaPosterior;
        private Button btnSemanaAnterior;
        private TextBox txtDni;
        private Label label3;
        private TextBox txtApellidosNombre;
        private Label label1;
        private Label lblCodigoDentista;
        private Button btnEliminarHora;
        private Button btnEliminarDia;
        private TextBox txtMotivo;
        private GroupBox gbColores;
        private Label label2;
    }
}