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

namespace Windows_ClinicaDental.Dentistas
{
    public partial class VerHorario : Form
    {

        ProxyDentista.ServicioDentistaClient objServicioDentista = new ProxyDentista.ServicioDentistaClient();
        ProxyDentista.DentistaDC objDentista = new ProxyDentista.DentistaDC();
        ProxyCita.ServicioCitaClient objServicioCita = new ProxyCita.ServicioCitaClient();
        ProxyCita.CitaDC objCita = new ProxyCita.CitaDC();
        public VerHorario()
        {
            InitializeComponent();
        }

        public String strCodigo { get; set; }
        private DateTime fechaActual;

        private void VerHorario_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridViewCalendario();
            ConfigurarLeyendaColores(); 

            objDentista = objServicioDentista.ConsultarDentista(strCodigo);

            lblCodigoDentista.Text = objDentista.idDentista.ToString();
            txtDni.Text = objDentista.dni;
            txtApellidosNombre.Text = objDentista.ApellidoYNombre;


            fechaActual = DateTime.Now;

            ActualizarRangoFechaSemana();
            txtMotivo.Clear();
            CargarCalendarioDisponible(objDentista.idDentista, fechaActual);


        }

        private void ConfigurarLeyendaColores()
        {
            var elementos = new[]
            {
                new { Estado = "Disponible", Color = Color.LightGreen },
                new { Estado = "Reservado", Color = Color.LightBlue },
                new { Estado = "Completado", Color = Color.Gold },  
                new { Estado = "Eliminado", Color = Color.IndianRed },
                new { Estado = "Expirado", Color = Color.Gray },
                new { Estado = "Sin Horario", Color = Color.LightGray }
            };

            int yPos = 25;
            foreach (var elemento in elementos)
            {
                Panel pnlColor = new Panel();
                pnlColor.BackColor = elemento.Color;
                pnlColor.Size = new Size(20, 20);
                pnlColor.Location = new Point(10, yPos);
                pnlColor.BorderStyle = BorderStyle.FixedSingle;

                Label lblEstado = new Label();
                lblEstado.Text = elemento.Estado;
                lblEstado.AutoSize = true;
                lblEstado.Location = new Point(40, yPos + 3);

                gbColores.Controls.Add(pnlColor);
                gbColores.Controls.Add(lblEstado);

                yPos += 25;
            }
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
                List<ProxyCita.CalendarioDisponibleDC> calendario = objServicioCita.ObtenerHorarioDetallado(idDentista, fecha);

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
                        continue;
                    }

                    string estado = string.Empty;
                    if (valor.Contains(" - "))
                    {
                        estado = valor.Split(new[] { " - " }, StringSplitOptions.None)[1];
                        if (estado.Contains(" - "))
                        {
                            estado = estado.Split(new[] { " - " }, StringSplitOptions.None)[0];
                        }
                    }

                    switch (estado.ToUpper())
                    {
                        case "DISPONIBLE":
                            cell.Style.BackColor = Color.LightGreen;
                            cell.Style.ForeColor = Color.Black;
                            break;

                        case "RESERVADO":
                            cell.Style.BackColor = Color.LightBlue;
                            cell.Style.ForeColor = Color.Black;
                            break;

                        case "COMPLETADO": 
                            cell.Style.BackColor = Color.Gold;
                            cell.Style.ForeColor = Color.Black;
                            break;

                        case "ELIMINADO":
                            cell.Style.BackColor = Color.IndianRed;
                            cell.Style.ForeColor = Color.White;
                            break;

                        case "EXPIRADO":
                        case "HORA VENCIDA":
                            cell.Style.BackColor = Color.Gray;
                            cell.Style.ForeColor = Color.White;
                            break;

                        default:
                            cell.Style.BackColor = Color.White;
                            cell.Style.ForeColor = Color.Black;
                            break;
                    }

                    DataGridView grid = row.DataGridView;
                    if (grid != null)
                    {
                        if (grid.Columns[i] is DataGridViewColumn column)
                        {
                            column.ToolTipText = valor;
                        }
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

        private void btnEliminarHora_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatos.CurrentCell != null && !string.IsNullOrEmpty(dtgDatos.CurrentCell.Value?.ToString()))
                {
                    string valorCelda = dtgDatos.CurrentCell.Value.ToString();
                    string estado = string.Empty;

                    if (valorCelda.Contains(" - "))
                    {
                        estado = valorCelda.Split(new[] { " - " }, StringSplitOptions.None)[1];
                        if (estado.Contains(" - "))
                        {
                            estado = estado.Split(new[] { " - " }, StringSplitOptions.None)[0];
                        }
                    }

                    if (estado.ToUpper() == "RESERVADO" || estado.ToUpper() == "EXPIRADO" || estado.ToUpper() == "COMPLETADO")
                    {
                        MessageBox.Show(
                            "No se puede eliminar un horario que está " + estado + ".",
                            "Eliminación no permitida",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (estado.ToUpper() == "ELIMINADO")
                    {
                        MessageBox.Show(
                            "Este horario ya ha sido eliminado.",
                            "Eliminación no permitida",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                    }

                    DateTime fechaEliminar;
                    if (valorCelda.Contains("-"))
                    {
                        string fechaStr = valorCelda.Split('-')[0].Trim();
                        if (!DateTime.TryParseExact(fechaStr, "dd/MM/yyyy", null,
                            System.Globalization.DateTimeStyles.None, out fechaEliminar))
                        {
                            MessageBox.Show("No se pudo obtener una fecha válida de la celda seleccionada.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El formato de la celda seleccionada no es válido.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int filaSeleccionada = dtgDatos.CurrentCell.RowIndex;
                    TimeSpan hora = TimeSpan.Parse(dtgDatos.Rows[filaSeleccionada].Cells["Hora"].Value.ToString());

                    DialogResult respuesta = MessageBox.Show(
                        $"¿Está seguro de eliminar la disponibilidad para el día {fechaEliminar.ToShortDateString()} a las {hora}?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        CitaDC objCita = new ProxyCita.CitaDC
                        {
                            idDentista = Convert.ToInt16(lblCodigoDentista.Text),
                            fechaCita = fechaEliminar,
                            horaCita = hora,
                            motivo = txtMotivo.Text
                        };

                        bool resultado = objServicioCita.EliminarDisponibilidadDentista(objCita);

                        if (resultado)
                        {
                            MessageBox.Show("Disponibilidad eliminada exitosamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CargarCalendarioDisponible(objDentista.idDentista, fechaActual);
                            txtMotivo.Text = string.Empty; 
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la disponibilidad.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una celda válida.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarDia_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDatos.CurrentCell != null && !string.IsNullOrEmpty(dtgDatos.CurrentCell.Value?.ToString()))
                {
                    string valorCelda = dtgDatos.CurrentCell.Value.ToString();
                    string estado = string.Empty;

                    if (valorCelda.Contains(" - "))
                    {
                        estado = valorCelda.Split(new[] { " - " }, StringSplitOptions.None)[1];
                        if (estado.Contains(" - "))
                        {
                            estado = estado.Split(new[] { " - " }, StringSplitOptions.None)[0];
                        }
                    }

                    if (estado.ToUpper() == "RESERVADO" || estado.ToUpper() == "EXPIRADO" || estado.ToUpper() == "COMPLETADO")
                    {
                        MessageBox.Show(
                            "No se puede eliminar un horario que está " + estado + ".",
                            "Eliminación no permitida",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    if (estado.ToUpper() == "ELIMINADO")
                    {
                        MessageBox.Show(
                            "Este horario ya ha sido eliminado.",
                            "Eliminación no permitida",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                    }

                    DateTime fechaEliminar;
                    if (valorCelda.Contains("-"))
                    {
                        string fechaStr = valorCelda.Split('-')[0].Trim();
                        if (!DateTime.TryParseExact(fechaStr, "dd/MM/yyyy", null,
                            System.Globalization.DateTimeStyles.None, out fechaEliminar))
                        {
                            MessageBox.Show("No se pudo obtener una fecha válida de la celda seleccionada.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El formato de la celda seleccionada no es válido.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DialogResult respuesta = MessageBox.Show(
                        $"¿Está seguro de eliminar toda la disponibilidad del día {fechaEliminar.ToShortDateString()}?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        CitaDC objCita = new ProxyCita.CitaDC
                        {
                            idDentista = Convert.ToInt16(lblCodigoDentista.Text),
                            fechaCita = fechaEliminar,
                            motivo = txtMotivo.Text,
                        };

                        bool resultado = objServicioCita.EliminarDisponibilidadDia(objCita);

                        if (resultado)
                        {
                            MessageBox.Show("Disponibilidad del día eliminada exitosamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarCalendarioDisponible(objDentista.idDentista, fechaActual);
                            txtMotivo.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la disponibilidad del día.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una celda válida.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
