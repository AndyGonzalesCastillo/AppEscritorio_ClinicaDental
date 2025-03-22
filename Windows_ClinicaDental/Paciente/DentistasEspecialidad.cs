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
    public partial class DentistasEspecialidad : Form
    {
        ProxyPaciente.ServicioPacienteClient objServicioPaciente = new ProxyPaciente.ServicioPacienteClient();
        ProxyEspecialidad.ServicioEspecialidadClient objServicioEspecialidad = new ProxyEspecialidad.ServicioEspecialidadClient();
        ProxyDentista.ServicioDentistaClient objServicioDentista = new ProxyDentista.ServicioDentistaClient();

        ProxyPaciente.PacienteDC objPaciente = new ProxyPaciente.PacienteDC();
        public DentistasEspecialidad()
        {
            InitializeComponent();
        }
        public String strCodigoPaciente { get; set; }

        private void DentistasEspecialidad_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;


            var especialidades = objServicioEspecialidad.ListarEspecialidades();
            var dtEspecialidades = new DataTable();
            dtEspecialidades.Columns.Add("idEspecialidad");
            dtEspecialidades.Columns.Add("nombre");

            foreach (var especialidad in especialidades)
            {
                var row = dtEspecialidades.NewRow();
                row["idEspecialidad"] = especialidad.idEspecialidad;
                row["nombre"] = especialidad.nombre;
                dtEspecialidades.Rows.Add(row);
            }

            DataRow drEspecialidad = dtEspecialidades.NewRow();
            drEspecialidad["idEspecialidad"] = 0;
            drEspecialidad["nombre"] = "--Seleccione--";
            dtEspecialidades.Rows.InsertAt(drEspecialidad, 0);

            cboEspecialidad.DataSource = dtEspecialidades;
            cboEspecialidad.DisplayMember = "nombre";
            cboEspecialidad.ValueMember = "idEspecialidad";



            objPaciente = objServicioPaciente.ConsultarPaciente(strCodigoPaciente);

            lblCodigoPaciente.Text = objPaciente.idPaciente.ToString();
            txtDni.Text = objPaciente.dni;
            txtApellidosNombre.Text = objPaciente.ApellidoYNombre;

        }

        private void cboEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEspecialidad.SelectedValue != null && int.TryParse(cboEspecialidad.SelectedValue.ToString(), out int idEspecialidad))
            {
                if (idEspecialidad > 0)
                {
                    var dentistas = objServicioDentista.ListarDentistasPorEspecialidad(Convert.ToString(idEspecialidad));

                    if (dentistas != null && dentistas.Count > 0)
                    {
                        var dtDentistas = new DataTable();
                        dtDentistas.Columns.Add("idDentista");
                        dtDentistas.Columns.Add("dni");
                        dtDentistas.Columns.Add("nombres");
                        dtDentistas.Columns.Add("apellidos");
                        dtDentistas.Columns.Add("telefono");
                        dtDentistas.Columns.Add("correo");
                        dtDentistas.Columns.Add("direccion");
                        dtDentistas.Columns.Add("fechaNacimiento");
                        dtDentistas.Columns.Add("edad");
                        dtDentistas.Columns.Add("sexo_cadena");
                        dtDentistas.Columns.Add("estadoDentista_cadena");
                        dtDentistas.Columns.Add("especialidadNombre");

                        foreach (var dentista in dentistas)
                        {
                            var row = dtDentistas.NewRow();
                            row["idDentista"] = dentista.idDentista;
                            row["dni"] = dentista.dni;
                            row["nombres"] = dentista.nombres;
                            row["apellidos"] = dentista.apellidos;
                            row["telefono"] = dentista.telefono;
                            row["correo"] = dentista.correo;
                            row["direccion"] = dentista.direccion;
                            row["fechaNacimiento"] = dentista.fechaNacimiento.ToString("yyyy-MM-dd");
                            row["edad"] = dentista.edad;
                            row["sexo_cadena"] = dentista.sexo_cadena;
                            row["estadoDentista_cadena"] = dentista.estadoDentista_cadena;
                            row["especialidadNombre"] = dentista.idEspecialidad;
                            dtDentistas.Rows.Add(row);
                        }

                        dtgDatos.DataSource = dtDentistas;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron dentistas para la especialidad seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgDatos.DataSource = null;
                    }
                }
            }
        }

        private void btnConsultarDisponibilidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboEspecialidad.SelectedValue == null || Convert.ToInt32(cboEspecialidad.SelectedValue) == 0)
                {
                    MessageBox.Show("Por favor, seleccione una especialidad antes de consultar la disponibilidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtgDatos.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, seleccione un dentista de la lista antes de consultar la disponibilidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                VerDisponibilidadDentista objDisponibilidadDentista = new VerDisponibilidadDentista();

                String strCodigoDentista = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                String strCodigoPaciente = lblCodigoPaciente.Text;
                objDisponibilidadDentista.strCodigoDentista = strCodigoDentista;
                objDisponibilidadDentista.strCodigoPaciente = strCodigoPaciente;
                objDisponibilidadDentista.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

    }
}
