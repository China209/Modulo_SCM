using CapaControlador.ControladorModulo;
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

namespace CapaVistaMuduloSCM.Mantenimientos.Sucursal
{
    public partial class frmSucursal : Form
    {
        private clsSucursal sucursal;
        private int iIDAux, sEstado, IDepartamento,sTel;
        private string sNombreAux, sDescAux,sDirecc;
        clsControlSucursal controlSucursal = new clsControlSucursal();

        public frmSucursal()
        {
            InitializeComponent();
            CargarCombobox();
            cargarDatos();
            LimpiarComponentes();
        }


        private void CargarCombobox()
        {
            cmbMun.DisplayMember = "nombre_municipio";
            cmbMun.ValueMember = "pk_id_municipio";
            cmbMun.DataSource = controlSucursal.obtenerCamposCombobox();
            cmbMun.SelectedIndex = -1;
            cmbMun.Refresh();
        }


        private void cargarDatos()
        {
            dgvVistaDatos.DataSource = controlSucursal.obtenerTodo();

        }

        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {

            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();

        }

        private clsSucursal llenarCampos()
        {
            clsSucursal auxAplicativo = new clsSucursal();
            auxAplicativo.IMunicipio = int.Parse(cmbMun.SelectedValue.ToString());
            auxAplicativo.SNombre = txtNombre.Text;
            auxAplicativo.Sdireccion = txtDireccion.Text;
            auxAplicativo.ITelefono = int.Parse(txtTel.Text.ToString());
            auxAplicativo.SDescripcion = txtDescripcion.Text;
            auxAplicativo.IEstado = 1;
            return auxAplicativo;
        }


        private void LimpiarComponentes()
        {

            txtCodigo.Text = "";
            txtDireccion.Text = "";
            txtTel.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            cmbMun.SelectedIndex = -1;
        }

        private bool guardarDatos()
        {
            this.sucursal = llenarCampos();
            try
            {
                controlSucursal.insertarSucursal(this.sucursal);
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

        private void bntAgregar_Click_2(object sender, EventArgs e)
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
                iIDAux = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["pk_id_sucursal"].Value.ToString());
                sNombreAux = dgvVistaDatos.Rows[e.RowIndex].Cells["fk_id_sucursal"].Value.ToString();
                sDescAux = dgvVistaDatos.Rows[e.RowIndex].Cells["nombre_sucursal"].Value.ToString();
                sDirecc= dgvVistaDatos.Rows[e.RowIndex].Cells["direccion_sucursal"].Value.ToString();
                sTel = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["telefono_sucursal"].Value.ToString());
                IDepartamento = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["pk_id_municipio"].Value.ToString());
                sEstado = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["estado_departamento"].Value.ToString());
                this.cmsEM.Show(this.dgvVistaDatos, e.Location);
                cmsEM.Show(Cursor.Position);
            }
        }
    }
}

