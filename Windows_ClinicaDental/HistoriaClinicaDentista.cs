using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_ClinicaDental
{
    public partial class HistoriaClinicaDentista : Form
    {
        ProxyPaciente.ServicioPacienteClient objServicioPaciente = new ProxyPaciente.ServicioPacienteClient();
        ProxyEspecialidad.ServicioEspecialidadClient objServicioEspecialidad = new ProxyEspecialidad.ServicioEspecialidadClient();
        ProxyDentista.ServicioDentistaClient objServicioDentista = new ProxyDentista.ServicioDentistaClient();
        ProxyTratamiento.ServicioTratamientoClient objServicioTratamiento = new ProxyTratamiento.ServicioTratamientoClient();

        ProxyPaciente.PacienteDC objPaciente = new ProxyPaciente.PacienteDC();
        public HistoriaClinicaDentista()
        {
            InitializeComponent();
        }
        public String strCodigoPaciente { get; set; }
        public String strCodigoDentista { get; set; }
        public String strCodigoCita { get; set; }

        private void HistoriaClinicaDentista_Load(object sender, EventArgs e)
        {
            var tratamientos = objServicioTratamiento.ListarTratamientos();
            var dtTratamiento = new DataTable();
            dtTratamiento.Columns.Add("idTratamiento");
            dtTratamiento.Columns.Add("nombre");

            foreach (var tratamiento in tratamientos)
            {
                var row = dtTratamiento.NewRow();
                row["idTratamiento"] = tratamiento.idTratamiento;
                row["nombre"] = tratamiento.nombre;
                dtTratamiento.Rows.Add(row);
            }

            DataRow drTratamiento = dtTratamiento.NewRow();
            drTratamiento["idTratamiento"] = 0;
            drTratamiento["nombre"] = "--Seleccione--";
            dtTratamiento.Rows.InsertAt(drTratamiento, 0);

            cboTratamiento.DataSource = dtTratamiento;
            cboTratamiento.DisplayMember = "nombre";
            cboTratamiento.ValueMember = "idTratamiento";


            objPaciente = objServicioPaciente.ConsultarPaciente(strCodigoPaciente);


            lblCodigoPaciente.Text = objPaciente.idPaciente.ToString();
            txtDni.Text = objPaciente.dni;
            txtApellidosNombre.Text = objPaciente.ApellidoYNombre;

            lblCodigoDentista.Text = strCodigoDentista;
            lblCodigoCita.Text = strCodigoCita;

        }

        private void btnAgregarHistoriaClinica_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTratamiento.SelectedIndex == 0)
                {
                    MessageBox.Show("Seleccione un tratamiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ProxyCita.CitaDC objHistoriaClinica = new ProxyCita.CitaDC
                {
                    idPaciente = Convert.ToInt16(lblCodigoPaciente.Text),
                    idDentista = Convert.ToInt16(lblCodigoDentista.Text),
                    idTratamiento = Convert.ToInt16(cboTratamiento.SelectedValue),
                    idCita = Convert.ToInt16(lblCodigoCita.Text),
                    descripcion = txtDescripcion.Text,
                    observaciones = txtObservaciones.Text
                };

                ProxyCita.ServicioCitaClient objServicioCita = new ProxyCita.ServicioCitaClient();
                bool resultado = objServicioCita.AgregarHistoriaClinica(objHistoriaClinica);

                if (resultado)
                {
                    bool estadoActualizado = objServicioCita.ActualizarEstadoCita(objHistoriaClinica.idCita, 2);

                    if (estadoActualizado)
                    {
                        MessageBox.Show("Historia clínica agregada y estado de la cita actualizado a Completado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Historia clínica agregada, pero no se pudo actualizar el estado de la cita.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al agregar la historia clínica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
