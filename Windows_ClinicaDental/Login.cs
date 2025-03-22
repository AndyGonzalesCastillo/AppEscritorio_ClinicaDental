using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//comentario de prueba para el commit
namespace Windows_ClinicaDental
{
    public partial class Login : Form
    {
        ProxyUsuario.ServicioUsuarioClient objServicioUsuario = new ProxyUsuario.ServicioUsuarioClient();
        ProxyUsuario.UsuarioDC objPaciente = new ProxyUsuario.UsuarioDC();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var dni = txtDni.Text;
            var contraseña = txtPassword.Text;

            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var usuario = objServicioUsuario.Login(dni, contraseña);

                if (usuario != null)
                {
                    string rolUsuario = usuario.rol;
                    string nombreUsuario = usuario.nombres + " " + usuario.apellidos;

                    if (rolUsuario == "Admin" || rolUsuario == "Recepcionista")
                    {
                        Principal frmPrincipal = new Principal(rolUsuario, nombreUsuario, dni);
                        frmPrincipal.Show();
                    }
                    else if (rolUsuario == "Dentista")
                    {
                        PrincipalDentista frmPrincipalDentista = new PrincipalDentista(rolUsuario, nombreUsuario, usuario.idDentista, usuario.especialidad, usuario.dni);
                        frmPrincipalDentista.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Acceso denegado: Usuario no autorizado o credenciales incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
