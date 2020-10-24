/*
 El siguiente formulario permite la insercion y mostrar datos de Linea Producto
 */
using CapaModelo;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaVista.Mantenimientos
{
    public partial class frmLineaProducto : Form
    {
        OdbcDataAdapter datos;
        DataTable dt;
        clsConexion conexion = new clsConexion();
        public frmLineaProducto()
        {
            InitializeComponent();
            CargarDatos();//Cargar Datos al Grid
        }

        //Metodo para mostrar los datos de la tabla al grid
        void CargarDatos()
        {
            try
            {
                string cadena = "SELECT pk_id_linea_producto, nombre_linea_producto, descripcion_linea_producto FROM linea_producto WHERE estado_linea_producto=1";

                datos = new OdbcDataAdapter(cadena, conexion.conexion());
                dt = new DataTable();
                datos.Fill(dt);
                dgvLineaProductoDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al cargar datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Limpia los componentes del formulario que permiten insercion de datos
        void LimpiarComponentes()
        {
            txtDescripcion.Text = "";
            txtNombre.Text = "";
        }
        //Muestra hora y fecha en tiempo real
        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        //Inserta  datos
        private bool insertarCargos()
        {
            try
            {
                if (ValidarCampos() == true)
                {

                    string cadena = "INSERT INTO linea_producto (nombre_linea_producto, descripcion_linea_producto, estado_linea_producto) VALUES ('" + txtNombre.Text + "','" + txtDescripcion.Text + "', 1);";
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
        //Valida salida de formulario
        private void frmLineaProducto_FormClosing(object sender, FormClosingEventArgs e)
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
