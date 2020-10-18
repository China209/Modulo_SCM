using CapaControlador.ControladorModulo;
using CapaModelo;
using CapaModelo.Clases_Modulo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaMuduloSCM.Mantenimientos.Marca
{
    public partial class frmMarca : Form
    {
        private clsMarca aplicativo;
        clsControlMarca marca = new clsControlMarca();
        private int iIDAux, sEstado;
        private string sDescAux;
        public frmMarca()
        {
            InitializeComponent();
            cargarDatos();
        }


        private void cargarDatos()
        {
            dgvVistaDatos.DataSource = marca.obtenerTodo();
           
        }

        private clsMarca llenarCampos()
        {
            clsMarca auxAplicativo = new clsMarca();
            auxAplicativo.SDescripcion = txtDescripcion.Text;
            auxAplicativo.IEstado = 1;
            return auxAplicativo;
        }


        private void LimpiarComponentes()
        {

            txtDescripcion.Text = "";
          

        }
        private bool guardarDatos()
        {
            this.aplicativo = llenarCampos();
            try
            {
                marca.insertarMarca(this.aplicativo);
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



        private void dgvVistaDatos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                iIDAux = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["pk_id_marca"].Value.ToString());
                sDescAux = dgvVistaDatos.Rows[e.RowIndex].Cells["descripcion_marca"].Value.ToString();
                sEstado = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["estado_marca"].Value.ToString());
                this.cmsEM.Show(this.dgvVistaDatos, e.Location);
                cmsEM.Show(Cursor.Position);
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

        private void frmMarca_Load(object sender, EventArgs e)
        {

        }
    }
}

