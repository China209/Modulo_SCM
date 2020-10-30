using CapaControladorModuloSCM.ControlProcesos;
using CapaModeloModuloSCM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaModuloSCM.Procesos
{
    public partial class frmMovimientoInventarios : Form
    {
        private clsConexion conexion = new clsConexion();
        private clsControladorMovimientosInventarios movimientosInventarios = new clsControladorMovimientosInventarios();
        public frmMovimientoInventarios()
        {
            InitializeComponent();
            cargarRutas();
            cargarTipoMovimientos();
            cargarVehiculos();
        }
        private void cargarRutas()
        {
            cmbRuta.ValueMember = "pk_id_ruta";
            cmbRuta.DisplayMember = "descripcion_ruta";
            cmbRuta.DataSource = movimientosInventarios.obtenerCamposCombobox("pk_id_ruta", "descripcion_ruta", "ruta", "estado_ruta");
            cmbRuta.Refresh();
            cmbRuta.SelectedIndex = -1;
        }
        private void cargarTipoMovimientos()
        {
            cmbTipo.ValueMember = "pk_id_tipo_movimiento";
            cmbTipo.DisplayMember = "nombre_tipo_movimiento";
            cmbTipo.DataSource = movimientosInventarios.obtenerCamposCombobox("pk_id_tipo_movimiento", "nombre_tipo_movimiento", "tipo_movimiento", "");
            cmbTipo.Refresh();
            cmbTipo.SelectedIndex = -1;
        }
        private void cargarVehiculos()
        {
            cmbVehiculo.ValueMember = "pk_id_vehiculo";
            cmbVehiculo.DisplayMember = "placa_vehiculo";
            cmbVehiculo.DataSource = movimientosInventarios.obtenerCamposCombobox("pk_id_vehiculo", "placa_vehiculo", "vehiculo", "estado_vehiculo");
            cmbVehiculo.Refresh();
            cmbVehiculo.SelectedIndex = -1;
        }
        //Carga datos al combobox producto, dentro del grid
        private void cargarProductos()
        {
            cmbProducto.ValueMember = "pk_id_producto";
            cmbProducto.DisplayMember = "nombre_producto";
            cmbProducto.DataSource = movimientosInventarios.obtenerCamposCombobox("pk_id_producto", "nombre_producto", "productoscm", "estado_producto");
        }

        private void cmbRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] ruta_campos = new string[2];
            if (cmbRuta.SelectedIndex > 0)
            {
                int indice = int.Parse(cmbRuta.SelectedValue.ToString());
                ruta_campos[0]= movimientosInventarios.obtenerCamposRuta(indice)[0];
                ruta_campos[1] = movimientosInventarios.obtenerCamposRuta(indice)[1];
                txtOrigen.Text = ruta_campos[0];
                txtDestino.Text = ruta_campos[1];
            }
            else
            {
                txtDestino.Text = "";
                txtOrigen.Text = "";
            }
        }

        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFechaAct.Text = DateTime.Now.ToLongDateString();
        }
    }
}
