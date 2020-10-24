using CapaControlador.ControlProcesos;
using CapaModelo.ClasesProcesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Procesos
{
    public partial class frmMovimientoInventarios : Form
    {
        private clsControladorMovimientosInventarios controladorMovimientosInventarios = new clsControladorMovimientosInventarios();
        private clsMantenimientoInventario mantenimientoInventario;
        private int iAuxIDMov, iAuxIDTipo, iAuxIDDetalle, iAuxIDProducto, iAuxCantidad;
        private DateTime dtAuxFecha;
        private string sAuxDescripcion, sAuxOrigen, sAuxDestino;

        public frmMovimientoInventarios()
        {
            InitializeComponent();
            cargarDatos();
            cargarDatosCombobox();
            txtCodigo.Text=controladorMovimientosInventarios.generarID("movimiento_inventario", "pk_id_movimiento_inventario").ToString();
        }

        private void cargarDatos()
        {
            dgvMovimientos.DataSource = controladorMovimientosInventarios.obtenerTodosDatos();
        }
        
        private void cargarDatosCombobox()
        {
            cmbProducto.DisplayMember = "nombre_producto";
            cmbProducto.ValueMember = "pk_id_producto";
            cmbProducto.DataSource = controladorMovimientosInventarios.obtenerCamposCombobox("pk_id_producto", "nombre_producto", "productoscm","estado_producto");
            cmbTipoMovimiento.DisplayMember = "nombre_tipo_movimiento";
            cmbTipoMovimiento.ValueMember = "pk_id_tipo_movimiento";
            cmbTipoMovimiento.DataSource = controladorMovimientosInventarios.obtenerCamposCombobox("pk_id_tipo_movimiento", "nombre_tipo_movimiento", "tipo_movimiento", "");
            cmbRuta.DisplayMember = "descripcion_ruta";
            cmbRuta.ValueMember = "pk_id_ruta";
            cmbRuta.DataSource = controladorMovimientosInventarios.obtenerCamposCombobox("pk_id_ruta", "descripcion_ruta", "ruta", "estado_ruta");
            cmbTipoMovimiento.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
            cmbRuta.SelectedIndex = -1;
            cmbProducto.Refresh();
            cmbTipoMovimiento.Refresh();
            cmbRuta.Refresh();
        }

        private clsMantenimientoInventario llenarCampos()
        {

            DateTime dtFecha = dtpFechaMovimiento.Value;
            clsMantenimientoInventario auxMantenimiento = new clsMantenimientoInventario();
            auxMantenimiento.IdMovimiento = int.Parse(txtCodigo.Text);
            auxMantenimiento.IdProducto = int.Parse(cmbProducto.SelectedValue.ToString());
            auxMantenimiento.IdTipoMovimiento = int.Parse(cmbTipoMovimiento.SelectedValue.ToString());
            auxMantenimiento.ICantidad=int.Parse(numCantidad.Value.ToString());
            auxMantenimiento.SDestino = txtDestino.Text;
            auxMantenimiento.SOrigen = txtOrigen.Text;
            auxMantenimiento.IdMovimientoDetalle = controladorMovimientosInventarios.generarID("movimiento_inventario_detalle", "pk_id_movimiento_inventario_detalle");
            auxMantenimiento.DtFecha = dtFecha;
            return auxMantenimiento;
        }

        private void itemActualizar_Click(object sender, EventArgs e)
        {
            txtOrigen.Text = sAuxOrigen;
        }

        private bool guardarDatos()
        {
            this.mantenimientoInventario = llenarCampos();
            try
            {
             //   if (ValidarTextbox() == true)
              //  {
                    controladorMovimientosInventarios.insertarMovimientos(this.mantenimientoInventario);
                    cargarDatos();
                    MessageBox.Show("Datos Correctamente Guardados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
              //  }
               // else
               //     return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar los Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*if (guardarDatos() == true)
            {
                LimpiarComponentes();
                txtCodigo.Text = controladorMovimientosInventarios.generarID("movimiento_inventario", "pk_id_movimiento_inventario").ToString();
            }
            else
            {
                LimpiarComponentes();
                txtCodigo.Text = controladorMovimientosInventarios.generarID("movimiento_inventario", "pk_id_movimiento_inventario").ToString();
            }*/
        }

        private void LimpiarComponentes()
        {
           /* txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtDestino.Text = "";
            txtOrigen.Text = "";
            cmbProducto.SelectedIndex = -1;
            cmbRuta.SelectedIndex = -1;
            cmbTipoMovimiento.SelectedIndex = -1;
            numCantidad.Value = 0;*/
        }
        private void cmbRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (cmbRuta.SelectedIndex == -1)
            {
                txtDestino.Text = "";
                txtOrigen.Text = "";
            }
            else
            {
                int iIDRuta = int.Parse(cmbRuta.SelectedValue.ToString());
                string[] sDatos = new string[2];

                sDatos[0] = controladorMovimientosInventarios.obtenerCamposRuta(iIDRuta)[0];
                sDatos[1] = controladorMovimientosInventarios.obtenerCamposRuta(iIDRuta)[1];

                txtOrigen.Text = sDatos[0];
                txtDestino.Text = sDatos[1];

            }*/
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void dgvMovimientos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*if (e.Button == MouseButtons.Right)
            {
                sAuxOrigen= dgvMovimientos.Rows[e.RowIndex].Cells["origen"].Value.ToString();
           //     sNombreAux = dgvMovimientos.Rows[e.RowIndex].Cells["nombre_modulo"].Value.ToString();
           //     sDescAux = dgvMovimientos.Rows[e.RowIndex].Cells["descripcion_modulo"].Value.ToString();
                this.cmsOpciones.Show(this.dgvMovimientos, e.Location);
                cmsOpciones.Show(Cursor.Position);
            }*/
        }
    }
}
