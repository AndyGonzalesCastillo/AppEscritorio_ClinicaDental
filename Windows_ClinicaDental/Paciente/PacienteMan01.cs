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


    public partial class PacienteMan01 : Form
    {

        ProxyPaciente.ServicioPacienteClient objServicioPaciente = new ProxyPaciente.ServicioPacienteClient();

        public PacienteMan01()
        {
            InitializeComponent();
        }

        private void PacienteMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgDatos.AutoGenerateColumns = false;
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void CargarDatos(String strFiltro)
        {
            try
            {
                List<ProxyPaciente.PacienteDC> datos = objServicioPaciente.ListarPacientes();

                if (!string.IsNullOrEmpty(strFiltro))
                {
                    var datosFiltrados = datos.Where(m => m.apellidos.Contains(strFiltro, StringComparison.OrdinalIgnoreCase)).ToList();
                    dtgDatos.DataSource = datosFiltrados;
                }
                else
                {
                    dtgDatos.DataSource = datos;
                }

                lblRegistros.Text = dtgDatos.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                PacienteMan02 objPaciente02 = new PacienteMan02();
                objPaciente02.ShowDialog();

                CargarDatos("");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                PacienteMan03 objPaciente03 = new PacienteMan03();

                String strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objPaciente03.strCodigo = strCodigo;
                objPaciente03.ShowDialog();

                CargarDatos("");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String strId = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                if (objServicioPaciente.EliminarPaciente(strId) == true)
                {
                    CargarDatos(txtFiltro.Text.Trim());
                }
                else
                {
                    throw new Exception("no se elimino el registro verifique su vinculo en otra tabla");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCita_Click(object sender, EventArgs e)
        {
            DentistasEspecialidad objDentistasEspecialidad = new DentistasEspecialidad();

            String strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
            objDentistasEspecialidad.strCodigoPaciente = strCodigo;
            objDentistasEspecialidad.ShowDialog();


        }

        private void btnVerCitas_Click(object sender, EventArgs e)
        {
            VerCitasPacientes objVerCitasPacientes = new VerCitasPacientes();
            String strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
            objVerCitasPacientes.strCodigoPaciente = strCodigo;
            objVerCitasPacientes.ShowDialog();
        }

        private void btnVerHistorialMedico_Click(object sender, EventArgs e)
        {
            VerHistorialMedico verHistorialMedico = new VerHistorialMedico();
            String strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
            verHistorialMedico.strCodigoPaciente = strCodigo;
            verHistorialMedico.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
