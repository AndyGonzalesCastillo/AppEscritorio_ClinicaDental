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
    public partial class DentistaMan02 : Form
    {
        ProxyEspecialidad.ServicioEspecialidadClient objServicioEspecialidad = new ProxyEspecialidad.ServicioEspecialidadClient();

        ProxyDentista.ServicioDentistaClient objServicioDentista = new ProxyDentista.ServicioDentistaClient();
        ProxyDentista.DentistaDC objDentista = new ProxyDentista.DentistaDC();

        public DentistaMan02()
        {
            InitializeComponent();
        }

        private void DentistaMan02_Load(object sender, EventArgs e)
        {
            try
            {
                cboSexo.SelectedIndex = 0;
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
                if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtDni.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtContraseña.Text.Trim() == "")
                {
                    MessageBox.Show("Todos los campos son obligatorios");
                }
                else
                {
                    objDentista.dni = txtDni.Text.Trim();
                    objDentista.correo = txtCorreo.Text.Trim();
                    objDentista.contraseña = txtContraseña.Text.Trim();
                    objDentista.nombres = txtNombre.Text.Trim();
                    objDentista.apellidos = txtApellido.Text.Trim();
                    objDentista.telefono = mskTel.Text.Trim();
                    objDentista.fechaNacimiento = dtpNacimiento.Value;
                    objDentista.direccion = txtDireccion.Text.Trim();
                    objDentista.sexo = Convert.ToInt16(cboSexo.SelectedIndex - 1);
                    objDentista.idEspecialidad = Convert.ToInt16(cboEspecialidad.SelectedValue);
                    objDentista.estado = Convert.ToInt16(chkestado.Checked);


                    if (objServicioDentista.AgregarDentista(objDentista) == true)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el dentista");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
