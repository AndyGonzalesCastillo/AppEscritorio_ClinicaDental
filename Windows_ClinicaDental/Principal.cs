using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_ClinicaDental.Dentistas;
using Windows_ClinicaDental.Paciente;

namespace Windows_ClinicaDental
{
    public partial class Principal : Form
    {
        Computer MiComputadora = new Computer();
        TimeSpan horaEntrada = new TimeSpan();
        String miRed = String.Empty;

        public Principal(string rol, string nombreUsuario, String dni)
        {
            InitializeComponent();
            toolStripStatusLabelRol.Text = $"Rol: {rol}";
            toolStripStatusLabelUsuario.Text = $"Usuario: {nombreUsuario}";
            ToolStripStatusLabelDni.Text = $"DNI: {dni}";

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            horaEntrada = DateTime.Now.TimeOfDay;
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Sistemas Clinica Dental - " + DateTime.Now.ToString();


            lblSesion.Text = "Sesion: " +
                DateTime.Now.TimeOfDay.Subtract(horaEntrada).ToString().Substring(0, 8);
        }


        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacienteMan01 pacienteMan01 = new PacienteMan01();
            this.IsMdiContainer = true;
            pacienteMan01.MdiParent = this;
            pacienteMan01.Show();
        }

        private void dentistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DentistaMan01 dentistaMan01 = new DentistaMan01();
            this.IsMdiContainer = true;
            dentistaMan01.MdiParent = this;
            dentistaMan01.Show();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
