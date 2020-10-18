/*
 El siguiente formulario permite la insercion y mostrar datos de Estado Producto
 */
using CapaModelo;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaVista.Mantenimientos
{
    public partial class frmEncargadoBodega : Form
    {
        OdbcDataAdapter datos;
        DataTable dt;
        private DataTable tabla;
        clsConexion conexion = new clsConexion();
        public frmEncargadoBodega()
        {
            InitializeComponent();
            CargarDatos();//Cargar Datos al Grid
            CargarCombobox();//Cargar Datos al Combo
        }
        //Limpiar de Datos de Componentes de Insercion
        void LimpiarComponentes()
        {
            cmbEmpleado.SelectedIndex = -1;
            cmbBodega.SelectedIndex = -1;
        }

        private bool ValdiarCampos()
        {
            if (cmbBodega.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese el campo Bodega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBodega.Focus();
                return false;
            }
            if (cmbEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese el campo Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbEmpleado.Focus();
                return false;
            }
            return true;
        }

        //Metodo de Cargar datos al Grid
        void CargarDatos()
        {
            try
            {
                string cadena = "SELECT pk_id_encargado_bodega, fk_id_empleado, fk_id_bodega FROM encargado_bodega WHERE estado_encargado_bodega=1";

                datos = new OdbcDataAdapter(cadena, conexion.conexion());
                dt = new DataTable();
                datos.Fill(dt);
                dgvEncargadoBodegaDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al cargar datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Fecha y Hora a tiempo real
        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        //Valida Salida del formulario
        private void frmEncargadoBodega_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drResultadoMensaje;
            drResultadoMensaje = MessageBox.Show("¿Realmente desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drResultadoMensaje == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
        //Metodo de obtener datos y cargar datos al combo
        public DataTable obtenerCamposCombobox(string sCampo1, string sCampo2, string sTabla, string sEstado)
        {
            try
            {
                string sComando = string.Format("SELECT " + sCampo1 + " ," + sCampo2 + " FROM " + sTabla + " WHERE " + sEstado + "=1");
                datos = new OdbcDataAdapter(sComando, conexion.conexion());
                tabla = new DataTable();
                datos.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        //Insertar datos
        private bool insertarCargos()
        {
            try
            {
                string cadena = "INSERT INTO encargado_bodega (fk_id_empleado, fk_id_bodega, estado_encargado_bodega) VALUES ('" + cmbEmpleado.SelectedValue + "','" + cmbBodega.SelectedValue + "', 1);";
                OdbcCommand consulta = new OdbcCommand(cadena, conexion.conexion());
                consulta.ExecuteNonQuery();
                consulta.Connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al guardar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarComponentes();
                return false;
            }

        }
        //Metodo de cargar datos al combo
        private void CargarCombobox()
        {
            cmbBodega.DisplayMember = "descripcion_bodega";
            cmbBodega.ValueMember = "pk_id_bodega";
            cmbBodega.DataSource = obtenerCamposCombobox("pk_id_bodega", "descripcion_bodega", "BODEGA", "estado_bodega");
            cmbEmpleado.DisplayMember = "nombre_empledo";
            cmbEmpleado.ValueMember = "pk_id_empledo";
            cmbEmpleado.DataSource = obtenerCamposCombobox("pk_id_empledo", "nombre_empledo", "EMPLEADO", "estado_empledo");
            cmbEmpleado.SelectedIndex = -1;
            cmbBodega.SelectedIndex = -1;
        }
        //Boton Insertar
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (insertarCargos() == true)
            {
                LimpiarComponentes();
                CargarDatos();
            }
            else
            {

            }
        }
    }
}
