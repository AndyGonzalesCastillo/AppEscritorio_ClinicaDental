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
    public partial class EditarHistoriaClinicaDentista : Form
    {
        ProxyPaciente.ServicioPacienteClient objServicioPaciente = new ProxyPaciente.ServicioPacienteClient();
        ProxyEspecialidad.ServicioEspecialidadClient objServicioEspecialidad = new ProxyEspecialidad.ServicioEspecialidadClient();
        ProxyDentista.ServicioDentistaClient objServicioDentista = new ProxyDentista.ServicioDentistaClient();
        ProxyTratamiento.ServicioTratamientoClient objServicioTratamiento = new ProxyTratamiento.ServicioTratamientoClient();
        ProxyCita.ServicioCitaClient objServicioCita = new ProxyCita.ServicioCitaClient();

        ProxyPaciente.PacienteDC objPaciente = new ProxyPaciente.PacienteDC();
        ProxyCita.CitaDC objCita = new ProxyCita.CitaDC();
        public String strCodigoCita { get; set; }
        public String strCodigoPaciente { get; set; }
        public String strCodigoDentista { get; set; }

        public EditarHistoriaClinicaDentista()
        {
            InitializeComponent();
        }

        private void EditarHistoriaClinicaDentista_Load(object sender, EventArgs e)
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

            objCita = objServicioCita.ConsultarHistoriaClinica(strCodigoCita);
            objPaciente = objServicioPaciente.ConsultarPaciente(strCodigoPaciente);
            txtDni.Text = objPaciente.dni;
            txtApellidosNombre.Text = objPaciente.ApellidoYNombre;

            lblCodigoHistoria.Text = objCita.idHistoriaClinica.ToString();
            lblCodigoPaciente.Text = objCita.idPaciente.ToString();
            lblCodigoDentista.Text = objCita.idDentista.ToString();
            lblCodigoCita.Text = objCita.idCita.ToString();
            cboTratamiento.SelectedValue = objCita.idTratamiento;
            txtDescripcion.Text = objCita.descripcion;
            txtObservaciones.Text = objCita.observaciones;

            SetControlsEnabled(false);
        }

        private void btnEditarHistoriaClinica_Click(object sender, EventArgs e)
        {
            try
            {
                SetControlsEnabled(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizarHistoriaClinica_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtObservaciones.Text == "" || cboTratamiento.Text == "" || txtDescripcion.Text == "")
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                }
                else
                {
                    objCita.idTratamiento = Convert.ToInt32(cboTratamiento.SelectedValue);
                    objCita.descripcion = txtDescripcion.Text;
                    objCita.observaciones = txtObservaciones.Text;


                    if (objServicioCita.ActualizarHistoriaClinica(objCita) == true)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar la historia clínica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SetControlsEnabled(bool enabled)
        {
            txtDni.Enabled = enabled;
            txtApellidosNombre.Enabled = enabled;
            cboTratamiento.Enabled = enabled;
            txtDescripcion.Enabled = enabled;
            txtObservaciones.Enabled = enabled;
        }
    }
}
