using CapaControlador.ControladorModulo;
using CapaModelo.Clases_Modulo;
using System;
using System.Windows.Forms;

namespace CapaVistaMuduloSCM.Mantenimientos.Ruta
{
    public partial class frmRuta : Form
    {

        private clsRuta aplicativo;
        clsControlRuta departamento = new clsControlRuta();
        private int iIDAux, sEstado;
        private string sDescAux, sOrigen, sDestino;


        public frmRuta()
        {
            InitializeComponent();
            cargarDatos();

        }


        private void cargarDatos()
        {
            dgvVistaDatos.DataSource = departamento.obtenerTodo();
        }

        private clsRuta llenarCampos()
        {
            clsRuta auxAplicativo = new clsRuta();
            auxAplicativo.SOrigen = txtOrigen.Text;
            auxAplicativo.SDestino = txtOrigen.Text;
            auxAplicativo.SDescripcion = txtDescripcion.Text;
            auxAplicativo.IEstado = 1;
            return auxAplicativo;
        }


        private void LimpiarComponentes()
        {

            txtDescripcion.Text = "";
            txtOrigen.Text = "";
            txtDestino.Text = "";
            txtDescripcion.Text = "";

        }
        private bool guardarDatos()
        {
            this.aplicativo = llenarCampos();
            try
            {
                departamento.insertarRuta(this.aplicativo);
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

        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {

            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();

        }

        private void bntAgregar_Click_1(object sender, EventArgs e)
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



        private void dgvVistaDatos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                iIDAux = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["pk_id_ruta"].Value.ToString());
                sOrigen = dgvVistaDatos.Rows[e.RowIndex].Cells["origen_ruta"].Value.ToString();
                sDestino = dgvVistaDatos.Rows[e.RowIndex].Cells["destino_ruta"].Value.ToString();
                sDescAux = dgvVistaDatos.Rows[e.RowIndex].Cells["descripcion_ruta"].Value.ToString();
                sEstado = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["estado_ruta"].Value.ToString());
                this.cmsEM.Show(this.dgvVistaDatos, e.Location);
                cmsEM.Show(Cursor.Position);
            }
        }


        private void frmRuta_Load(object sender, EventArgs e)
        {

        }
    }
}
