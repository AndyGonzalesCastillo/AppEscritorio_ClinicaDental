using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Windows_ClinicaDental.Paciente
{
    public partial class VerDisponibilidadDentista : Form
    {
        ProxyDentista.ServicioDentistaClient objServicioDentista = new ProxyDentista.ServicioDentistaClient();
        ProxyDentista.DentistaDC objDentista = new ProxyDentista.DentistaDC();
        ProxyCita.ServicioCitaClient objServicioCita = new ProxyCita.ServicioCitaClient();
        ProxyCita.CitaDC objCita = new ProxyCita.CitaDC();

        public String strCodigoDentista { get; set; }
        public String strCodigoPaciente { get; set; }

        private DateTime fechaActual;

        public VerDisponibilidadDentista()
        {
            InitializeComponent();
        }

        private void VerDisponibilidadDentista_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridViewCalendario();
            objDentista = objServicioDentista.ConsultarDentista(strCodigoDentista);

            lblCodigoDentista.Text = objDentista.idDentista.ToString();
            txtDni.Text = objDentista.dni;
            txtApellidosNombre.Text = objDentista.ApellidoYNombre;
            lblCodigoPaciente.Text = strCodigoPaciente;

            fechaActual = DateTime.Now;

            ActualizarRangoFechaSemana();

            CargarCalendarioDisponible(objDentista.idDentista, fechaActual);
        }

        private void ConfigurarDataGridViewCalendario()
        {
            dtgDatos.AutoGenerateColumns = false;
            dtgDatos.Columns.Clear();

            dtgDatos.Columns.Add("Hora", "Hora");
            dtgDatos.Columns.Add("Lunes", "Lunes");
            dtgDatos.Columns.Add("Martes", "Martes");
            dtgDatos.Columns.Add("Miércoles", "Miércoles");
            dtgDatos.Columns.Add("Jueves", "Jueves");
            dtgDatos.Columns.Add("Viernes", "Viernes");
            dtgDatos.Columns.Add("Sábado", "Sábado");
            dtgDatos.Columns.Add("Domingo", "Domingo");

            dtgDatos.RowHeadersVisible = false;
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarCalendarioDisponible(int idDentista, DateTime fecha)
        {
            try
            {
                dtgDatos.Rows.Clear();
                List<ProxyCita.CalendarioDisponibleDC> calendario = objServicioCita.ObtenerCalendarioDisponible(idDentista, fecha);

                foreach (var fila in calendario)
                {
                    int rowIndex = dtgDatos.Rows.Add();
                    dtgDatos.Rows[rowIndex].Cells["Hora"].Value = fila.Hora.ToString(@"hh\:mm");
                    dtgDatos.Rows[rowIndex].Cells["Lunes"].Value = fila.Lunes;
                    dtgDatos.Rows[rowIndex].Cells["Martes"].Value = fila.Martes;
                    dtgDatos.Rows[rowIndex].Cells["Miércoles"].Value = fila.Miércoles;
                    dtgDatos.Rows[rowIndex].Cells["Jueves"].Value = fila.Jueves;
                    dtgDatos.Rows[rowIndex].Cells["Viernes"].Value = fila.Viernes;
                    dtgDatos.Rows[rowIndex].Cells["Sábado"].Value = fila.Sábado;
                    dtgDatos.Rows[rowIndex].Cells["Domingo"].Value = fila.Domingo;
                }

                ColorearCeldasCalendario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el calendario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ColorearCeldasCalendario()
        {
            foreach (DataGridViewRow row in dtgDatos.Rows)
            {
                for (int i = 1; i < dtgDatos.Columns.Count; i++)
                {
                    var cell = row.Cells[i];
                    string valor = cell.Value?.ToString();

                    if (string.IsNullOrEmpty(valor))
                    {
                        cell.Style.BackColor = Color.LightGray;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.LightGreen;
                    }
                }
            }
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatos.CurrentCell != null && !string.IsNullOrEmpty(dtgDatos.CurrentCell.Value?.ToString()))
                {
                    int columnaSeleccionada = dtgDatos.CurrentCell.ColumnIndex;
                    int filaSeleccionada = dtgDatos.CurrentCell.RowIndex;

                    if (columnaSeleccionada == 0)
                    {
                        MessageBox.Show("Debe seleccionar un día de la semana.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string diaSemana = dtgDatos.Columns[columnaSeleccionada].HeaderText;
                    TimeSpan hora = TimeSpan.Parse(dtgDatos.Rows[filaSeleccionada].Cells["Hora"].Value.ToString());

                    DateTime inicioSemana = fechaActual.AddDays(-(int)fechaActual.DayOfWeek + (int)DayOfWeek.Monday);

                    int diasHastaFecha = CalcularDiasHastaFechaSinSemana(diaSemana);
                    DateTime fechaCita = inicioSemana.AddDays(diasHastaFecha);

                    // Crear la cita
                    objCita.fechaCita = fechaCita;
                    objCita.horaCita = hora;
                    objCita.idPaciente = Convert.ToInt16(strCodigoPaciente);
                    objCita.idDentista = Convert.ToInt16(lblCodigoDentista.Text);
                    objCita.motivoCita = txtMotivoCita.Text;

                    if (string.IsNullOrEmpty(objCita.motivoCita))
                    {
                        MessageBox.Show("Debe ingresar el motivo de la cita.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    bool resultado = objServicioCita.AgregarCita(objCita);
                    if (resultado)
                    {
                        MessageBox.Show("Cita registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar la cita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un horario disponible.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CalcularDiasHastaFechaSinSemana(string diaObjetivo)
        {
            Dictionary<string, int> diasSemana = new Dictionary<string, int>
            {
                {"Lunes", 0},
                {"Martes", 1},
                {"Miércoles", 2},
                {"Jueves", 3},
                {"Viernes", 4},
                {"Sábado", 5},
                {"Domingo", 6}
            };

            return diasSemana[diaObjetivo];
        }

        private void btnSemanaAnterior_Click(object sender, EventArgs e)
        {
            DateTime semanaActual = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek + (int)DayOfWeek.Monday);

            if (fechaActual > semanaActual)
            {
                fechaActual = fechaActual.AddDays(-7);
                ActualizarRangoFechaSemana();
                CargarCalendarioDisponible(objDentista.idDentista, fechaActual);
            }
            else
            {
                MessageBox.Show("No se puede retroceder más allá de la semana actual.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSemanaPosterior_Click(object sender, EventArgs e)
        {
            fechaActual = fechaActual.AddDays(7);
            ActualizarRangoFechaSemana();
            CargarCalendarioDisponible(objDentista.idDentista, fechaActual);
        }

        private void ActualizarRangoFechaSemana()
        {
            fechaActual = fechaActual.AddDays(-(int)fechaActual.DayOfWeek + (int)DayOfWeek.Monday);

            DateTime semanaActual = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek + (int)DayOfWeek.Monday);
            DateTime finSemana = fechaActual.AddDays(6);

            lblRangoFechaSemana.Text = $"Semana del {fechaActual:dd/MM/yyyy} al {finSemana:dd/MM/yyyy}";

            btnSemanaAnterior.Enabled = (fechaActual > semanaActual);
        }

    }
}