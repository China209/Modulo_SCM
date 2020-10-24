
using CapaControlador.ControladorModulo;
using System;
using System.Windows.Forms;
using CapaModelo;
using CapaModelo.Clases_Modulo;

namespace CapaVistaMuduloSCM.Mantenimientos.Departamento
{
    public partial class frmDepartamento : Form
    {

        private clsDepartamento aplicativo;
        clsControlDepartamento departamento = new clsControlDepartamento();
        private int iIDAux, sEstado;
        private string sNombreAux, sDescAux;
       

        public frmDepartamento()
        {
            InitializeComponent();
            cargarDatos();
        }

         private void cargarDatos()
        {
            dgvVistaDatos.DataSource = departamento.obtenerTodo();
        }

        private clsDepartamento llenarCampos()
        {
            clsDepartamento auxAplicativo = new clsDepartamento();
            auxAplicativo.SNombre = txtNombre.Text;
            auxAplicativo.SDescripcion = txtDescripcion.Text;
            auxAplicativo.IEstado = 1;
            return auxAplicativo;
        }


        private void LimpiarComponentes()
        {
        
            txtDescripcion.Text = "";
            txtNombre.Text = "";
        }
        private bool guardarDatos()
        {
            this.aplicativo = llenarCampos();
            try
            {
                departamento.insertarDepartamento(this.aplicativo);
                cargarDatos();
                MessageBox.Show("Datos Correctamente Guardados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar los Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private void bntAgregar_Click(object sender, EventArgs e)
        {
            if (guardarDatos() == true)
            {
                LimpiarComponentes();
            }
            else
            {
                LimpiarComponentes();
            }
        }
        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        private void dgvVistaDatos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                iIDAux = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["pk_id_departamento"].Value.ToString());
                sNombreAux = dgvVistaDatos.Rows[e.RowIndex].Cells["nombre_departamento"].Value.ToString();
                sDescAux = dgvVistaDatos.Rows[e.RowIndex].Cells["descripcion_departamento"].Value.ToString();
                sEstado=int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["estado_departamento"].Value.ToString());
                this.cmsEM.Show(this.dgvVistaDatos, e.Location);
                cmsEM.Show(Cursor.Position);
            }
        }
    }
}

