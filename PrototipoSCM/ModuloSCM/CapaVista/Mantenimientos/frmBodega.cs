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
    public partial class frmBodega : Form
    {
        OdbcDataAdapter datos;
        DataTable dt;
        private DataTable tabla;
        clsConexion conexion = new clsConexion();
        public frmBodega()
        {
            InitializeComponent();
            CargarDatos();//Cargar Datos al Grid
            CargarCombobox();//Cargar Datos a Combo
        }
        //Fecha y Hora en tiempo real
        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        //Metodo de Cargar Datos al Grid
        void CargarDatos()
        {
            try
            {
                string cadena = "SELECT pk_id_bodega, fk_id_municipio, dimensiones_bodega, direccion_bodega, telefono_bodega, descripcion_bodega FROM bodega WHERE estado_bodega=1";

                datos = new OdbcDataAdapter(cadena, conexion.conexion());
                dt = new DataTable();
                datos.Fill(dt);
                dgvBodegaDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al cargar datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Validar Ingreso de Datos
        private bool ValidarCampos()
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Ingrese el campo Descripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Text = "";
                txtDescripcion.Focus();
                return false;
            }
            if (txtDimensiones.Text == "")
            {
                MessageBox.Show("Ingrese el campo Dimensiones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDimensiones.Text = "";
                txtDimensiones.Focus();
                return false;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Ingrese el campo Direccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDireccion.Text = "";
                txtDireccion.Focus();
                return false;
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Ingrese el campo Telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Text = "";
                txtTelefono.Focus();
                return false;
            }
            if (cmbMunicipio.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese el campo Municipio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbMunicipio.Focus();
                return false;
            }
            return true;
        }
        //Limpiar Componentes de Insercion
        void LimpiarComponentes()
        {
            txtDescripcion.Text = "";
            txtDimensiones.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            cmbMunicipio.SelectedIndex = -1;
        }
        //Valida la Salida del formulario
        private void frmBodega_FormClosing(object sender, FormClosingEventArgs e)
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
        //Metodo de Insertar Datos
        private bool insertarCargos()
        {
            try
            {
                if (ValidarCampos() == true)
                {
                    string cadena = "INSERT INTO bodega (fk_id_municipio, dimensiones_bodega, direccion_bodega, telefono_bodega, descripcion_bodega, estado_bodega) VALUES ('" + cmbMunicipio.SelectedValue + "','" + txtDimensiones.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "','" + txtDescripcion.Text + "', 1);";
                    OdbcCommand consulta = new OdbcCommand(cadena, conexion.conexion());
                    consulta.ExecuteNonQuery();
                    consulta.Connection.Close();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al guardar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarComponentes();
                return false;
            }

        }
        //Metodo para obtener datos de combo
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
        //Metodo de cargar los datos al combo
        private void CargarCombobox()
        {
            cmbMunicipio.DisplayMember = "nombre_municipio";
            cmbMunicipio.ValueMember = "pk_id_municipio";
            cmbMunicipio.DataSource = obtenerCamposCombobox("pk_id_municipio", "nombre_municipio", "MUNICIPIO", "estado_municipio");
            cmbMunicipio.SelectedIndex = -1;
        }
        //Boton de insertar
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
