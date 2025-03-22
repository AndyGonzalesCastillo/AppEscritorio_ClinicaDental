namespace Windows_ClinicaDental.Dentistas
{
    partial class AgregarHorario
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
            label11 = new Label();
            lblCodigo = new Label();
            label1 = new Label();
            cboDiaSemana = new ComboBox();
            dtgDatos = new DataGridView();
            Hora = new DataGridViewTextBoxColumn();
            Lunes = new DataGridViewTextBoxColumn();
            Martes = new DataGridViewTextBoxColumn();
            Miércoles = new DataGridViewTextBoxColumn();
            Jueves = new DataGridViewTextBoxColumn();
            Viernes = new DataGridViewTextBoxColumn();
            Sábado = new DataGridViewTextBoxColumn();
            Domingo = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            btnAgregar = new Button();
            lblRangoFechaSemana = new TextBox();
            btnSemanaPosterior = new Button();
            btnSemanaAnterior = new Button();
            comboHorarios = new ComboBox();
            comboHorarios2 = new ComboBox();
            cboMes = new ComboBox();
            cboAño = new ComboBox();
            label4 = new Label();
            label5a = new Label();
            btnEliminarDia = new Button();
            btnEliminarHora = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(163, 33);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(72, 21);
            label11.TabIndex = 146;
            label11.Text = "Codigo:";
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.Fixed3D;
            lblCodigo.Location = new Point(260, 33);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(110, 24);
            lblCodigo.TabIndex = 147;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(435, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 144;
            label1.Text = "Dia de la Semana:";
            // 
            // cboDiaSemana
            // 
            cboDiaSemana.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDiaSemana.FormattingEnabled = true;
            cboDiaSemana.Items.AddRange(new object[] { "--Seleccione--", "Mujer", "Hombre" });
            cboDiaSemana.Location = new Point(615, 26);
            cboDiaSemana.Margin = new Padding(4);
            cboDiaSemana.Name = "cboDiaSemana";
            cboDiaSemana.Size = new Size(227, 29);
            cboDiaSemana.TabIndex = 148;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { Hora, Lunes, Martes, Miércoles, Jueves, Viernes, Sábado, Domingo });
            dtgDatos.Location = new Point(20, 259);
            dtgDatos.Margin = new Padding(4);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1154, 336);
            dtgDatos.TabIndex = 149;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 150;
            label2.Text = "Hora Inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(511, 74);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 152;
            label3.Text = "Hora Fin:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(886, 107);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(203, 32);
            btnAgregar.TabIndex = 154;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblRangoFechaSemana
            // 
            lblRangoFechaSemana.Location = new Point(327, 188);
            lblRangoFechaSemana.Margin = new Padding(4);
            lblRangoFechaSemana.MaxLength = 20;
            lblRangoFechaSemana.Name = "lblRangoFechaSemana";
            lblRangoFechaSemana.ReadOnly = true;
            lblRangoFechaSemana.Size = new Size(540, 27);
            lblRangoFechaSemana.TabIndex = 158;
            // 
            // btnSemanaPosterior
            // 
            btnSemanaPosterior.Location = new Point(886, 185);
            btnSemanaPosterior.Margin = new Padding(4);
            btnSemanaPosterior.Name = "btnSemanaPosterior";
            btnSemanaPosterior.Size = new Size(199, 32);
            btnSemanaPosterior.TabIndex = 157;
            btnSemanaPosterior.Text = "Siguiente Semana";
            btnSemanaPosterior.UseVisualStyleBackColor = true;
            btnSemanaPosterior.Click += btnSemanaPosterior_Click;
            // 
            // btnSemanaAnterior
            // 
            btnSemanaAnterior.Location = new Point(141, 185);
            btnSemanaAnterior.Margin = new Padding(4);
            btnSemanaAnterior.Name = "btnSemanaAnterior";
            btnSemanaAnterior.Size = new Size(171, 32);
            btnSemanaAnterior.TabIndex = 156;
            btnSemanaAnterior.Text = "Semana Anterior";
            btnSemanaAnterior.UseVisualStyleBackColor = true;
            btnSemanaAnterior.Click += btnSemanaAnterior_Click;
            // 
            // comboHorarios
            // 
            comboHorarios.DropDownStyle = ComboBoxStyle.DropDownList;
            comboHorarios.FormattingEnabled = true;
            comboHorarios.Location = new Point(260, 74);
            comboHorarios.Margin = new Padding(4);
            comboHorarios.Name = "comboHorarios";
            comboHorarios.Size = new Size(194, 29);
            comboHorarios.TabIndex = 159;
            comboHorarios.SelectedIndexChanged += comboHorarios_SelectedIndexChanged;
            // 
            // comboHorarios2
            // 
            comboHorarios2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboHorarios2.FormattingEnabled = true;
            comboHorarios2.Location = new Point(615, 70);
            comboHorarios2.Margin = new Padding(4);
            comboHorarios2.Name = "comboHorarios2";
            comboHorarios2.Size = new Size(227, 29);
            comboHorarios2.TabIndex = 160;
            // 
            // cboMes
            // 
            cboMes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMes.FormattingEnabled = true;
            cboMes.Location = new Point(260, 127);
            cboMes.Margin = new Padding(4);
            cboMes.Name = "cboMes";
            cboMes.Size = new Size(227, 29);
            cboMes.TabIndex = 161;
            // 
            // cboAño
            // 
            cboAño.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAño.FormattingEnabled = true;
            cboAño.Location = new Point(615, 124);
            cboAño.Margin = new Padding(4);
            cboAño.Name = "cboAño";
            cboAño.Size = new Size(227, 29);
            cboAño.TabIndex = 162;
            cboAño.SelectedIndexChanged += cboAño_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 131);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 163;
            label4.Text = "Mes:";
            // 
            // label5a
            // 
            label5a.AutoSize = true;
            label5a.Location = new Point(540, 128);
            label5a.Margin = new Padding(4, 0, 4, 0);
            label5a.Name = "label5a";
            label5a.Size = new Size(47, 21);
            label5a.TabIndex = 164;
            label5a.Text = "Año:";
            // 
            // btnEliminarDia
            // 
            btnEliminarDia.Location = new Point(886, 27);
            btnEliminarDia.Margin = new Padding(4);
            btnEliminarDia.Name = "btnEliminarDia";
            btnEliminarDia.Size = new Size(203, 32);
            btnEliminarDia.TabIndex = 166;
            btnEliminarDia.Text = "Eliminar Dia";
            btnEliminarDia.UseVisualStyleBackColor = true;
            btnEliminarDia.Click += btnEliminarDia_Click;
            // 
            // btnEliminarHora
            // 
            btnEliminarHora.Location = new Point(886, 67);
            btnEliminarHora.Margin = new Padding(4);
            btnEliminarHora.Name = "btnEliminarHora";
            btnEliminarHora.Size = new Size(203, 32);
            btnEliminarHora.TabIndex = 165;
            btnEliminarHora.Text = "Eliminar Hora";
            btnEliminarHora.UseVisualStyleBackColor = true;
            btnEliminarHora.Click += btnEliminarHora_Click;
            // 
            // AgregarHorario
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 623);
            Controls.Add(btnEliminarDia);
            Controls.Add(btnEliminarHora);
            Controls.Add(label5a);
            Controls.Add(label4);
            Controls.Add(cboAño);
            Controls.Add(cboMes);
            Controls.Add(comboHorarios2);
            Controls.Add(comboHorarios);
            Controls.Add(lblRangoFechaSemana);
            Controls.Add(btnSemanaPosterior);
            Controls.Add(btnSemanaAnterior);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtgDatos);
            Controls.Add(cboDiaSemana);
            Controls.Add(label11);
            Controls.Add(lblCodigo);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AgregarHorario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AGREGAR HORARIO";
            Load += AgregarHorario_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Label lblCodigo;
        private Label label1;
        private ComboBox cboDiaSemana;
        private DataGridView dtgDatos;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Lunes;
        private DataGridViewTextBoxColumn Martes;
        private DataGridViewTextBoxColumn Miércoles;
        private DataGridViewTextBoxColumn Jueves;
        private DataGridViewTextBoxColumn Viernes;
        private DataGridViewTextBoxColumn Sábado;
        private DataGridViewTextBoxColumn Domingo;
        private Label label2;
        private Label label3;
        private Button btnAgregar;
        private TextBox lblRangoFechaSemana;
        private Button btnSemanaPosterior;
        private Button btnSemanaAnterior;
        private ComboBox comboHorarios;
        private ComboBox comboHorarios2;
        private ComboBox cboMes;
        private ComboBox cboAño;
        private Label label4;
        private Label label5a;
        private Button btnEliminarDia;
        private Button btnEliminarHora;
    }
}