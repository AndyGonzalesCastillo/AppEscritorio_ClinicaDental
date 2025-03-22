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
    public partial class DentistaMan03 : Form
    {
        ProxyEspecialidad.ServicioEspecialidadClient objServicioEspecialidad = new ProxyEspecialidad.ServicioEspecialidadClient();

        ProxyDentista.ServicioDentistaClient objServicioDentista = new ProxyDentista.ServicioDentistaClient();
        ProxyDentista.DentistaDC objDentista = new ProxyDentista.DentistaDC();
        public DentistaMan03()
        {
            InitializeComponent();
        }

        public String strCodigo { get; set; }

        private void DentistaMan03_Load(object sender, EventArgs e)
        {
            try
            {
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

                objDentista = objServicioDentista.ConsultarDentista(strCodigo);

                lblCodigo.Text = objDentista.idDentista.ToString();
                txtDni.Text = objDentista.dni;
                txtNombre.Text = objDentista.nombres;
                txtApellido.Text = objDentista.apellidos;
                mskTel.Text = objDentista.telefono;
                txtCorreo.Text = objDentista.correo;
                txtDireccion.Text = objDentista.direccion;
                dtpNacimiento.Value = Convert.ToDateTime(objDentista.fechaNacimiento);
                cboSexo.SelectedIndex = objDentista.sexo + 1;
                chkestado.Checked = Convert.ToBoolean(objDentista.estado);
                txtContraseña.Text = objDentista.contraseña;
                cboEspecialidad.SelectedValue = objDentista.idEspecialidad;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtDni.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtContraseña.Text.Trim() == "")
                {
                    MessageBox.Show("Todos los campos son obligatorios");
                }
                else
                {
                    objDentista.idDentista = Convert.ToInt16(lblCodigo.Text);
                    objDentista.dni = txtDni.Text.Trim();
                    objDentista.correo = txtCorreo.Text.Trim();
                    objDentista.contraseña = txtContraseña.Text.Trim();
                    objDentista.nombres = txtNombre.Text.Trim();
                    objDentista.apellidos = txtApellido.Text.Trim();
                    objDentista.telefono = mskTel.Text.Trim();
                    objDentista.fechaNacimiento = dtpNacimiento.Value;
                    objDentista.direccion = txtDireccion.Text.Trim();
                    objDentista.sexo = Convert.ToInt16(cboSexo.SelectedIndex - 1);
                    objDentista.estado = Convert.ToInt16(chkestado.Checked);
                    objDentista.idEspecialidad = Convert.ToInt16(cboEspecialidad.SelectedValue);

                    if (objServicioDentista.ActualizarDentista(objDentista) == true)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el dentista");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
