using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_ClinicaDental.Paciente
{
    public partial class VerHistorialMedico : Form
    {
        ProxyPaciente.ServicioPacienteClient objServicioPaciente = new ProxyPaciente.ServicioPacienteClient();
        ProxyEspecialidad.ServicioEspecialidadClient objServicioEspecialidad = new ProxyEspecialidad.ServicioEspecialidadClient();
        ProxyDentista.ServicioDentistaClient objServicioDentista = new ProxyDentista.ServicioDentistaClient();
        ProxyCita.ServicioCitaClient objServicioCita = new ProxyCita.ServicioCitaClient();

        ProxyPaciente.PacienteDC objPaciente = new ProxyPaciente.PacienteDC();

        ProxyCita.CitaDC objCita = new ProxyCita.CitaDC();

        public VerHistorialMedico()
        {
            InitializeComponent();
        }

        public String strCodigoPaciente { get; set; }

        private void VerHistorialMedico_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;

            objPaciente = objServicioPaciente.ConsultarPaciente(strCodigoPaciente);

            lblCodigoPaciente.Text = objPaciente.idPaciente.ToString();
            txtDni.Text = objPaciente.dni;
            txtApellidosNombre.Text = objPaciente.ApellidoYNombre;

            CargarHistoriaClinica(objPaciente.idPaciente);
        }

        private void CargarHistoriaClinica(int idPaciente)
        {
            List<ProxyCita.CitaDC> listaHistoriaClinica = objServicioCita.ListarHistoriaClinica(idPaciente.ToString());

            dtgDatos.DataSource = listaHistoriaClinica;
        }
    }
}