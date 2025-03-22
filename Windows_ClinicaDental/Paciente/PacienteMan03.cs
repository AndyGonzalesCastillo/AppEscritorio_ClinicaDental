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
    public partial class PacienteMan03 : Form
    {
        ProxyPaciente.ServicioPacienteClient objServicioPaciente = new ProxyPaciente.ServicioPacienteClient();

        ProxyPaciente.PacienteDC objPaciente = new ProxyPaciente.PacienteDC();

        public PacienteMan03()
        {
            InitializeComponent();
        }

        public String strCodigo { get; set; }

        private void PacienteMan03_Load(object sender, EventArgs e)
        {
            try
            {
                objPaciente = objServicioPaciente.ConsultarPaciente(strCodigo);

                lblCodigo.Text = objPaciente.idPaciente.ToString();
                txtDni.Text = objPaciente.dni;
                txtNombre.Text = objPaciente.nombres;
                txtApellido.Text = objPaciente.apellidos;
                mskTel.Text = objPaciente.telefono;
                txtCorreo.Text = objPaciente.correo;
                txtDireccion.Text = objPaciente.direccion;
                dtpNacimiento.Value = Convert.ToDateTime(objPaciente.fechaNacimiento);
                cboSexo.SelectedIndex = objPaciente.sexo + 1;
                chkestado.Checked = Convert.ToBoolean(objPaciente.estado);
                txtContraseña.Text = objPaciente.contraseña;


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
                if (txtDni.Text.Trim() == "" || txtNombre.Text.Trim() == "" ||
                    txtApellido.Text.Trim() == "" || txtCorreo.Text.Trim() == "" ||
                    txtContraseña.Text.Trim() == "")
                {
                    throw new Exception("Todos los datos son obligatorios");
                }

                objPaciente.idPaciente = Convert.ToInt16(lblCodigo.Text);
                objPaciente.dni = txtDni.Text.Trim();
                objPaciente.correo = txtCorreo.Text.Trim();
                objPaciente.contraseña = txtContraseña.Text.Trim();
                objPaciente.nombres = txtNombre.Text.Trim();
                objPaciente.apellidos = txtApellido.Text.Trim();
                objPaciente.telefono = mskTel.Text.Trim();
                objPaciente.fechaNacimiento = dtpNacimiento.Value;
                objPaciente.direccion = txtDireccion.Text.Trim();
                objPaciente.sexo = Convert.ToInt16(cboSexo.SelectedIndex - 1);
                objPaciente.estado = Convert.ToInt16(chkestado.Checked);

                if (objServicioPaciente.ActualizarPaciente(objPaciente) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto el registro, contacte con IT");
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
