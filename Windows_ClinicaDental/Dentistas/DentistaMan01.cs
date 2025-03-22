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
    public partial class DentistaMan01 : Form
    {
        ProxyDentista.ServicioDentistaClient objServicioDentista = new ProxyDentista.ServicioDentistaClient();

        public DentistaMan01()
        {
            InitializeComponent();
        }

        private void DentistaMan01_Load(object sender, EventArgs e)
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
                List<ProxyDentista.DentistaDC> datos = objServicioDentista.ListarDentistas();

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

                DentistaMan02 objDentistaMan02 = new DentistaMan02();
                objDentistaMan02.ShowDialog();

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
                DentistaMan03 objDentistaMan03 = new DentistaMan03();
                String strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objDentistaMan03.strCodigo = strCodigo;
                objDentistaMan03.ShowDialog();
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
                if (objServicioDentista.EliminarDentista(strId) == true)
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

        private void btnAgregarHorario_Click(object sender, EventArgs e)
        {
            AgregarHorario objAgregarHorario = new AgregarHorario();
            string strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
            objAgregarHorario.strCodigo = strCodigo;
            objAgregarHorario.ShowDialog();
        }

        private void btnVerHorario_Click(object sender, EventArgs e)
        {
            VerHorario objVerHorario = new VerHorario();
            string strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
            objVerHorario.strCodigo = strCodigo;
            objVerHorario.ShowDialog();
        }
    }
}
