using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_ClinicaDental.Dentistas;
using Windows_ClinicaDental.Paciente;

namespace Windows_ClinicaDental
{
    public partial class PrincipalDentista : Form
    {
        private ProxyCita.ServicioCitaClient objServicioCita = new ProxyCita.ServicioCitaClient();


        Computer MiComputadora = new Computer();
        TimeSpan horaEntrada = new TimeSpan();
        String miRed = String.Empty;

        public string strCodigoDentista { get; set; }
        public string strEspecialidad { get; set; }

        public PrincipalDentista(string rol, string nombreUsuario, int? idDentista, string especialidad, string dni)
        {
            InitializeComponent();
            toolStripStatusLabelRol.Text = $"Rol: {rol}";
            toolStripStatusLabelUsuario.Text = $"Usuario: {nombreUsuario}";
            ToolStripStatusLabelDni.Text = $"DNI: {dni}";
            strCodigoDentista = idDentista.HasValue ? idDentista.Value.ToString() : "N/A";
            strEspecialidad = especialidad ?? "Sin especialidad";
            toolStripStatusLabelEspecialidad.Text = $"Especialidad: {strEspecialidad}";
            dtgDatos.AutoGenerateColumns = false;
            CargarCitasDelDia();
        }

        private void PrincipalDentista_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;
            horaEntrada = DateTime.Now.TimeOfDay;
            lblCodigoDentista.Text = strCodigoDentista;

            btnAgregarHistoriaClinica.Enabled = false;
            btnVerHistoriaClinica.Enabled = false;

            dtgDatos.CurrentCellChanged += DtGridDatos_CurrentCellChanged;
        }

        private void DtGridDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            bool filaSeleccionada = dtgDatos.CurrentRow != null && dtgDatos.CurrentRow.Index >= 0;

            btnAgregarHistoriaClinica.Enabled = filaSeleccionada;
            btnVerHistoriaClinica.Enabled = filaSeleccionada;
        }

        private void CargarCitasDelDia()
        {

            DateTime fechaHoy = DateTime.Today;
            CargarCitasPorFecha(fechaHoy, fechaHoy);
        }

        private void CargarCitasPorFecha(DateTime fechaInicio, DateTime? fechaFin = null)
        {
            try
            {
                int idDentista = int.Parse(strCodigoDentista);
                List<ProxyCita.CitaDC> listaCitas = objServicioCita.ListarCitasPorDentistaYFecha(Convert.ToString(idDentista), fechaInicio, fechaFin);

                dtgDatos.DataSource = listaCitas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar citas: {ex.Message}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date.AddDays(1).AddTicks(-1);

            if (fechaFin < fechaInicio)
            {
                MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de inicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarCitasPorFecha(fechaInicio, fechaFin);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Sistemas Clinica Dental - " + DateTime.Now.ToString();

            lblSesion.Text = "Sesion: " +
                DateTime.Now.TimeOfDay.Subtract(horaEntrada).ToString().Substring(0, 8);
        }

        private void PrincipalDentista_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnAgregarHistoriaClinica_Click(object sender, EventArgs e)
        {
            try
            {
                String strCodigoPaciente = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                String strCodigoDentista = lblCodigoDentista.Text;
                String strCodigoCita = dtgDatos.CurrentRow.Cells[1].Value.ToString();

                ProxyCita.ServicioCitaClient objServicioCita = new ProxyCita.ServicioCitaClient();

                bool existeHistoria = objServicioCita.ExisteHistoriaClinica(Convert.ToInt16(strCodigoCita));

                if (existeHistoria)
                {
                    MessageBox.Show("Ya existe una historia clínica registrada para esta cita.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                HistoriaClinicaDentista historiaClinicaDentista = new HistoriaClinicaDentista
                {
                    strCodigoDentista = strCodigoDentista,
                    strCodigoCita = strCodigoCita,
                    strCodigoPaciente = strCodigoPaciente
                };

                historiaClinicaDentista.FormClosed += (s, args) =>
                {
                    btnBuscar.PerformClick();
                };

                historiaClinicaDentista.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerHistoriaClinica_Click(object sender, EventArgs e)
        {
            try
            {
                String strCodigoCita = dtgDatos.CurrentRow.Cells[1].Value.ToString();
                ProxyCita.ServicioCitaClient objServicioCita = new ProxyCita.ServicioCitaClient();
                bool existeHistoria = objServicioCita.ExisteHistoriaClinica(Convert.ToInt16(strCodigoCita));

                if (!existeHistoria)
                {
                    MessageBox.Show("No existe una historia clínica para esta cita.", "Información",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                EditarHistoriaClinicaDentista objEditarHistoriaClinicaDentista = new EditarHistoriaClinicaDentista();
                String strCodigoPaciente = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objEditarHistoriaClinicaDentista.strCodigoPaciente = strCodigoPaciente;
                objEditarHistoriaClinicaDentista.strCodigoCita = strCodigoCita;
                objEditarHistoriaClinicaDentista.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerHorario_Click(object sender, EventArgs e)
        {
            VerHorario objVerHorario = new VerHorario();
            string strCodigo = lblCodigoDentista.Text;
            objVerHorario.strCodigo = strCodigo;
            objVerHorario.ShowDialog();
        }

        private void ActualizarEstadoBotones()
        {
            try
            {
                if (dtgDatos.CurrentRow != null)
                {
                    String strCodigoCita = dtgDatos.CurrentRow.Cells[1].Value.ToString();
                    ProxyCita.ServicioCitaClient objServicioCita = new ProxyCita.ServicioCitaClient();
                    bool existeHistoria = objServicioCita.ExisteHistoriaClinica(Convert.ToInt16(strCodigoCita));
                    btnVerHistoriaClinica.Enabled = existeHistoria;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar estado de botones: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgDatos_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotones();
        }
    }
}