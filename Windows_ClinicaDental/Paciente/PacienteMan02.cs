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
    public partial class PacienteMan02 : Form
    {
        ProxyPaciente.ServicioPacienteClient objServicioPaciente = new ProxyPaciente.ServicioPacienteClient();

        ProxyPaciente.PacienteDC objPaciente = new ProxyPaciente.PacienteDC();
        public PacienteMan02()
        {
            InitializeComponent();
        }

        private void PacienteMan02_Load(object sender, EventArgs e)
        {
            cboSexo.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtDni.Text.Trim() == "" || txtCorreo.Text.Trim() == "" || txtContraseña.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor llene todos los campos");
                }
                else
                {
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

                    if (objServicioPaciente.agregarPaciente(objPaciente) == true)
                    {
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("no se agrego el registro verifique su vinculo en otra tabla");
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
