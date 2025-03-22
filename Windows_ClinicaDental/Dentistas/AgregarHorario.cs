using ProxyCita;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Windows_ClinicaDental.Dentistas
{
    public partial class AgregarHorario : Form
    {
        ProxyDentista.ServicioDentistaClient objServicioDentista = new ProxyDentista.ServicioDentistaClient();
        ProxyDentista.DentistaDC objDentista = new ProxyDentista.DentistaDC();
        ProxyCita.ServicioCitaClient objServicioCita = new ProxyCita.ServicioCitaClient();
        ProxyCita.CitaDC objCita = new ProxyCita.CitaDC();



        public String strCodigo { get; set; }
        private DateTime fechaActual;

        public AgregarHorario()
        {
            InitializeComponent();
        }

        private void AgregarHorario_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridViewCalendario();
            LlenarComboBoxHoras();
            LlenarComboBoxDias();
            LlenarComboBoxMeses();
            LlenarComboBoxAnios();

            comboHorarios2.Items.Clear();
            comboHorarios2.Items.Add("--Seleccione--");
            comboHorarios2.SelectedIndex = 0;
            comboHorarios2.Enabled = false;
            objDentista = objServicioDentista.ConsultarDentista(strCodigo);
            lblCodigo.Text = objDentista.idDentista.ToString();

            fechaActual = DateTime.Now;

            ActualizarRangoFechaSemana();

            CargarCalendarioDisponible(objDentista.idDentista, fechaActual);

        }

        private void LlenarComboBoxHoras()
        {
            comboHorarios.Items.Clear();

            comboHorarios.Items.Add("--Seleccione--");

            DateTime horaActual = DateTime.Today.AddHours(8);
            DateTime horaFinal = DateTime.Today.AddHours(20);

            while (horaActual <= horaFinal)
            {
                comboHorarios.Items.Add(horaActual.ToString("HH:mm"));
                horaActual = horaActual.AddMinutes(30);
            }

            comboHorarios.SelectedIndex = 0;
        }

        private void LlenarComboBoxDias()
        {
            cboDiaSemana.Items.Clear();

            cboDiaSemana.Items.Add("--Seleccione--");

            string[] diasSemana = new string[]
            {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"
            };

            cboDiaSemana.Items.AddRange(diasSemana);

            cboDiaSemana.SelectedIndex = 0;
        }

        private void LlenarComboBoxHoras2(DateTime horaInicio)
        {
            comboHorarios2.Items.Clear();

            comboHorarios2.Items.Add("--Seleccione--");

            DateTime horaFinal = DateTime.Today.AddHours(20);

            DateTime horaActual = horaInicio.AddMinutes(30);

            while (horaActual <= horaFinal)
            {
                comboHorarios2.Items.Add(horaActual.ToString("HH:mm"));
                horaActual = horaActual.AddMinutes(30);
            }

            comboHorarios2.SelectedIndex = 0;
        }

        private void comboHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboHorarios.SelectedIndex > 0)
            {
                string horaSeleccionada = comboHorarios.SelectedItem.ToString();
                DateTime horaInicio = DateTime.ParseExact(horaSeleccionada, "HH:mm",
                                                        System.Globalization.CultureInfo.InvariantCulture);
                horaInicio = DateTime.Today.Add(horaInicio.TimeOfDay);
                comboHorarios2.Enabled = true;
                LlenarComboBoxHoras2(horaInicio);
            }
            else
            {
                comboHorarios2.Enabled = false;
                comboHorarios2.Items.Clear();
                comboHorarios2.Items.Add("--Seleccione--");
                comboHorarios2.SelectedIndex = 0;
            }
        }

        private void LlenarComboBoxMeses()
        {
            cboMes.Items.Clear();

            int mesActual = DateTime.Now.Month;
            int anioSeleccionado = cboAño.SelectedItem != null ? (int)cboAño.SelectedItem : DateTime.Now.Year;

            if (anioSeleccionado == DateTime.Now.Year)
            {
                for (int i = mesActual - 1; i < meses.Count; i++)
                {
                    cboMes.Items.Add(meses[i]);
                }
            }
            else if (anioSeleccionado > DateTime.Now.Year)
            {
                foreach (var mes in meses)
                {
                    cboMes.Items.Add(mes);
                }
            }

            if (cboMes.Items.Count > 0)
            {
                cboMes.SelectedIndex = 0;
            }
        }

        private void LlenarComboBoxAnios()
        {
            cboAño.Items.Clear();
            int anioActual = DateTime.Now.Year;

            for (int i = 0; i <= 10; i++)
            {
                cboAño.Items.Add(anioActual + i);
            }

            cboAño.SelectedIndex = 0;
        }

        private void cboAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarComboBoxMeses();
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
                List<ProxyCita.CalendarioDisponibleDC> calendario = objServicioCita.ObtenerHorarioDentista(idDentista, fecha);

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

        private int CalcularDiasHastaFecha(string diaObjetivo, DayOfWeek diaActual)
        {
            Dictionary<string, DayOfWeek> diasSemana = new Dictionary<string, DayOfWeek>
            {
                {"Lunes", DayOfWeek.Monday},
                {"Martes", DayOfWeek.Tuesday},
                {"Miércoles", DayOfWeek.Wednesday},
                {"Jueves", DayOfWeek.Thursday},
                {"Viernes", DayOfWeek.Friday},
                {"Sábado", DayOfWeek.Saturday},
                {"Domingo", DayOfWeek.Sunday}
            };

            DayOfWeek diaObjetivoEnum = diasSemana[diaObjetivo];
            int diferencia = diaObjetivoEnum - diaActual;

            if (diferencia < 0)
            {
                diferencia += 7;
            }

            return diferencia;
        }

        private void btnSemanaAnterior_Click(object sender, EventArgs e)
        {
            fechaActual = fechaActual.AddDays(-7);
            ActualizarRangoFechaSemana();
            CargarCalendarioDisponible(objDentista.idDentista, fechaActual);
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

            DateTime finSemana = fechaActual.AddDays(6);

            lblRangoFechaSemana.Text = $"Semana del {fechaActual:dd/MM/yyyy} al {finSemana:dd/MM/yyyy}";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboDiaSemana.SelectedIndex == 0 || comboHorarios.SelectedIndex == 0 || comboHorarios2.SelectedIndex == 0)
                {
                    MessageBox.Show("Todos los campos son obligatorios");
                }
                else
                {
                    objCita.idDentista = Convert.ToInt16(lblCodigo.Text);
                    objCita.diaSemana = cboDiaSemana.SelectedItem.ToString();
                    objCita.horarioInicio = TimeSpan.Parse(comboHorarios.SelectedItem.ToString());
                    objCita.horarioFin = TimeSpan.Parse(comboHorarios2.SelectedItem.ToString());

                    var mesSeleccionado = cboMes.SelectedItem as Mes;
                    objCita.mes = mesSeleccionado != null ? mesSeleccionado.Id : fechaActual.Month;

                    objCita.año = Convert.ToInt16(cboAño.SelectedItem);

                    if (objServicioCita.AgregarHorarioDentista(objCita) == true)
                    {
                        CargarCalendarioDisponible(objDentista.idDentista, fechaActual);

                        cboDiaSemana.SelectedIndex = 0;
                        comboHorarios.SelectedIndex = 0;
                        comboHorarios2.SelectedIndex = 0;
                        comboHorarios2.Enabled = false;

                        MessageBox.Show("Horario agregado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el horario");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }


        private class Mes
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            public Mes(int id, string nombre)
            {
                Id = id;
                Nombre = nombre;
            }

            public override string ToString()
            {
                return Nombre;
            }
        }

        private List<Mes> meses = new List<Mes>
        {
            new Mes(1, "Enero"),
            new Mes(2, "Febrero"),
            new Mes(3, "Marzo"),
            new Mes(4, "Abril"),
            new Mes(5, "Mayo"),
            new Mes(6, "Junio"),
            new Mes(7, "Julio"),
            new Mes(8, "Agosto"),
            new Mes(9, "Septiembre"),
            new Mes(10, "Octubre"),
            new Mes(11, "Noviembre"),
            new Mes(12, "Diciembre")
        };

        private void btnEliminarHora_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatos.CurrentCell != null && !string.IsNullOrEmpty(dtgDatos.CurrentCell.Value?.ToString()))
                {
                    int columnaSeleccionada = dtgDatos.CurrentCell.ColumnIndex;
                    int filaSeleccionada = dtgDatos.CurrentCell.RowIndex;

                    if (columnaSeleccionada == 0)
                    {
                        MessageBox.Show("Debe seleccionar un horario específico de un día.",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string diaSemana = dtgDatos.Columns[columnaSeleccionada].HeaderText;
                    TimeSpan hora = TimeSpan.Parse(dtgDatos.Rows[filaSeleccionada].Cells["Hora"].Value.ToString());

                    int diasHastaFecha = CalcularDiasHastaFecha(diaSemana, fechaActual.DayOfWeek);
                    DateTime fechaEliminar = fechaActual.AddDays(diasHastaFecha);

                    DialogResult respuesta = MessageBox.Show(
                        $"¿Está seguro de eliminar el horario del día {fechaEliminar.ToShortDateString()} a las {hora}?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        CitaDC objCita = new CitaDC
                        {
                            idDentista = Convert.ToInt16(lblCodigo.Text),
                            fechaCita = fechaEliminar,
                            horaCita = hora
                        };

                        bool resultado = objServicioCita.EliminarHorarioDentistaHora(objCita);

                        if (resultado)
                        {
                            MessageBox.Show("Horario eliminado exitosamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarCalendarioDisponible(objDentista.idDentista, fechaActual);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el horario.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un horario para eliminar.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar el horario seleccionado. Es posible que esté asociado a una cita ya reservada. Por favor, verifique antes de intentarlo nuevamente.",
                    "Eliminación no permitida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void btnEliminarDia_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatos.CurrentCell != null)
                {
                    int columnaSeleccionada = dtgDatos.CurrentCell.ColumnIndex;

                    if (columnaSeleccionada == 0)
                    {
                        MessageBox.Show("Debe seleccionar un día de la semana.",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string diaSemana = dtgDatos.Columns[columnaSeleccionada].HeaderText;

                    int diasHastaFecha = CalcularDiasHastaFecha(diaSemana, fechaActual.DayOfWeek);
                    DateTime fechaEliminar = fechaActual.AddDays(diasHastaFecha);

                    DialogResult respuesta = MessageBox.Show(
                        $"¿Está seguro de eliminar todos los horarios del día {fechaEliminar.ToShortDateString()}?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        CitaDC objCita = new CitaDC
                        {
                            idDentista = Convert.ToInt16(lblCodigo.Text),
                            fechaCita = fechaEliminar
                        };

                        bool resultado = objServicioCita.EliminarHorarioDentistaDia(objCita);

                        if (resultado)
                        {
                            MessageBox.Show("Horarios del día eliminados exitosamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarCalendarioDisponible(objDentista.idDentista, fechaActual);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar los horarios del día.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un día para eliminar.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron eliminar los horarios del día seleccionado. Es posible que estén asociados a citas ya reservadas. Por favor, verifique antes de intentarlo nuevamente.",
                    "Eliminación no permitida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        //private void btnGuardar_Click(object sender, EventArgs e)
        //{

        //}
    }
}