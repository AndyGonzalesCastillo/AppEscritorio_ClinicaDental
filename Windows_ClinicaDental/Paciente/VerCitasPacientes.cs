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
    public partial class VerCitasPacientes : Form
    {
        ProxyCita.ServicioCitaClient objServicioCita = new ProxyCita.ServicioCitaClient();
        ProxyCita.CitaDC objCita = new ProxyCita.CitaDC();
        public VerCitasPacientes()
        {
            InitializeComponent();
        }
        public String strCodigoPaciente { get; set; }

        private void VerCitasPacientes_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;

            List<ProxyCita.CitaDC> listaCitas = objServicioCita.ListarCitasPaciente(strCodigoPaciente);

            if (listaCitas != null && listaCitas.Count > 0)
            {
                dtgDatos.DataSource = listaCitas;
            }
            else
            {
                MessageBox.Show("No se encontraron citas para el paciente.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                String strId = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                if (objServicioCita.CancelarCita(strId) == true)
                {
                    MessageBox.Show("La cita fue cancelada exitosamente.");

                    RefrescarDataGridView();
                }
                else
                {
                    throw new Exception("No se eliminó el registro. Verifique su vínculo en otra tabla.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RefrescarDataGridView()
        {
            List<ProxyCita.CitaDC> listaCitas = objServicioCita.ListarCitasPaciente(strCodigoPaciente);

            if (listaCitas != null && listaCitas.Count > 0)
            {
                dtgDatos.DataSource = listaCitas;
            }
            else
            {
                dtgDatos.DataSource = null;
                MessageBox.Show("No se encontraron citas para el paciente.");
            }
        }
    }
}
