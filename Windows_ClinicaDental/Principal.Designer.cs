namespace Windows_ClinicaDental
{
    partial class Principal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            statusStrip2 = new StatusStrip();
            ToolStripStatusLabelDni = new ToolStripStatusLabel();
            toolStripStatusLabelUsuario = new ToolStripStatusLabel();
            toolStripStatusLabelRol = new ToolStripStatusLabel();
            lblSesion = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            mantenimientosToolStripMenuItem = new ToolStripMenuItem();
            pacienteToolStripMenuItem = new ToolStripMenuItem();
            dentistaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip2
            // 
            statusStrip2.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabelDni, toolStripStatusLabelUsuario, toolStripStatusLabelRol, lblSesion });
            statusStrip2.Location = new Point(0, 607);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Padding = new Padding(1, 0, 16, 0);
            statusStrip2.Size = new Size(1225, 22);
            statusStrip2.TabIndex = 10;
            statusStrip2.Text = "statusStrip2";
            // 
            // ToolStripStatusLabelDni
            // 
            ToolStripStatusLabelDni.BackColor = Color.DarkGray;
            ToolStripStatusLabelDni.Font = new Font("Century Gothic", 9F);
            ToolStripStatusLabelDni.Name = "ToolStripStatusLabelDni";
            ToolStripStatusLabelDni.Size = new Size(30, 17);
            ToolStripStatusLabelDni.Text = "Dni:";
            // 
            // toolStripStatusLabelUsuario
            // 
            toolStripStatusLabelUsuario.BackColor = Color.DarkGray;
            toolStripStatusLabelUsuario.Font = new Font("Century Gothic", 9F);
            toolStripStatusLabelUsuario.Name = "toolStripStatusLabelUsuario";
            toolStripStatusLabelUsuario.Size = new Size(54, 17);
            toolStripStatusLabelUsuario.Text = "Usuario:";
            // 
            // toolStripStatusLabelRol
            // 
            toolStripStatusLabelRol.BackColor = Color.DarkGray;
            toolStripStatusLabelRol.Font = new Font("Century Gothic", 9F);
            toolStripStatusLabelRol.Name = "toolStripStatusLabelRol";
            toolStripStatusLabelRol.Size = new Size(29, 17);
            toolStripStatusLabelRol.Text = "Rol:";
            // 
            // lblSesion
            // 
            lblSesion.BackColor = Color.DarkGray;
            lblSesion.Font = new Font("Century Gothic", 9F);
            lblSesion.Name = "lblSesion";
            lblSesion.Size = new Size(60, 17);
            lblSesion.Text = "Seccion:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1225, 29);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            mantenimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pacienteToolStripMenuItem, dentistaToolStripMenuItem });
            mantenimientosToolStripMenuItem.Font = new Font("Century Gothic", 12F);
            mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            mantenimientosToolStripMenuItem.Size = new Size(149, 25);
            mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // pacienteToolStripMenuItem
            // 
            pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            pacienteToolStripMenuItem.Size = new Size(150, 26);
            pacienteToolStripMenuItem.Text = "Paciente";
            pacienteToolStripMenuItem.Click += pacienteToolStripMenuItem_Click;
            // 
            // dentistaToolStripMenuItem
            // 
            dentistaToolStripMenuItem.Name = "dentistaToolStripMenuItem";
            dentistaToolStripMenuItem.Size = new Size(150, 26);
            dentistaToolStripMenuItem.Text = "Dentista";
            dentistaToolStripMenuItem.Click += dentistaToolStripMenuItem_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1225, 629);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip2);
            Font = new Font("Century Gothic", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BIENVENIDOS A LA CLINICA DENTAL";
            WindowState = FormWindowState.Maximized;
            FormClosed += Principal_FormClosed;
            Load += Principal_Load;
            Resize += Principal_Resize;
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel toolStripStatusLabelRol;
        private ToolStripStatusLabel toolStripStatusLabelUsuario;
        private ToolStripStatusLabel lblSesion;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientosToolStripMenuItem;
        private ToolStripMenuItem pacienteToolStripMenuItem;
        private ToolStripMenuItem dentistaToolStripMenuItem;
        private ToolStripStatusLabel ToolStripStatusLabelDni;
    }
}