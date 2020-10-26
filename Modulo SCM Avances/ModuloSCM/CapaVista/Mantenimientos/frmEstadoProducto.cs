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
    public partial class frmEstadoProducto : Form
    {
        OdbcDataAdapter datos;
        DataTable dt;
        clsConexion conexion = new clsConexion();
        public frmEstadoProducto()
        {
            InitializeComponent();
            CargarDatos();//Cargar los datos al Grid
        }
        //Metodo de Cargar Datos al Grid
        void CargarDatos()
        {
            try
            {
                string cadena = "SELECT pk_id_estado_producto, nombre_estado_producto, descripcion_estado_producto FROM estado_producto WHERE estado_estado_producto=1";

                datos = new OdbcDataAdapter(cadena, conexion.conexion());
                dt = new DataTable();
                datos.Fill(dt);
                dgvEstadoProductoDatos.DataSource = dt;
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
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el campo Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                txtNombre.Focus();
                return false;
            }
            return true;
        }
        //Metodo de Insertar Datos 
        private bool insertarCargos()
        {
            try
            {
                if (ValidarCampos() == true)
                {
                    string cadena = "INSERT INTO estado_producto (nombre_estado_producto, descripcion_estado_producto, estado_estado_producto) VALUES ('" + txtNombre.Text + "','" + txtDescripcion.Text + "', 1);";
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
        //Limpiar Datos de Componentes de Insercion
        void LimpiarComponentes()
        {
            txtDescripcion.Text = "";
            txtNombre.Text = "";
        }
        //Fecha y Hora a tiempo real
        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        //Valida salida de formulario
        private void frmEstadoProducto_FormClosing(object sender, FormClosingEventArgs e)
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
        //Boton de Insertar
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (insertarCargos() == true)
            {
                CargarDatos();
                LimpiarComponentes();
            }
            else
            {

            }
        }
    }
}
