/*
 El siguiente formulario permite la insercion y mostrar datos de Fabrica
 */
using CapaModelo;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaVista.Mantenimientos
{
    public partial class frmFabrica : Form
    {
        OdbcDataAdapter datos;
        DataTable dt;
        private DataTable tabla;
        clsConexion conexion = new clsConexion();
        public frmFabrica()
        {
            InitializeComponent();
            CargarDatos();//Mostrar el Grid con datos desde el inicio
            CargarCombobox();//Cargar los datos al combo
        }
        //Limpia componentes de ingreso
        void LimpiarComponentes()
        {
            txtDescripcion.Text = "";
            txtDimensiones.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            cmbMunicipio.SelectedIndex = -1;
        }
        //Fecha y hora en tiempo real
        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        //Metodo de cargar datos al grid
        void CargarDatos()
        {
            try
            {
                string cadena = "SELECT pk_id_fabrica, fk_id_municipio, dimensiones_fabrica, direccion_fabrica, telefono_fabrica, descripcion_fabrica FROM fabrica WHERE estado_fabrica=1";

                datos = new OdbcDataAdapter(cadena, conexion.conexion());
                dt = new DataTable();
                datos.Fill(dt);
                dgvFabricaDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al cargar datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Metodo de insertar dartos
        private bool insertarCargos()
        {
            try
            {
                if (ValidarCampos()==true)
                {
                    string cadena = "INSERT INTO fabrica (fk_id_municipio, dimensiones_fabrica, direccion_fabrica, telefono_fabrica, descripcion_fabrica, estado_fabrica) VALUES ('" + cmbMunicipio.SelectedValue + "','" + txtDimensiones.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "','" + txtDescripcion.Text + "', 1);";
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
        //Valida la salida del formulario
        private void frmFabrica_FormClosing(object sender, FormClosingEventArgs e)
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
            if (cmbMunicipio.SelectedIndex==-1)
            {
                MessageBox.Show("Ingrese el campo Municipio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbMunicipio.Focus();
                return false;
            }
            return true;
        }
        //Obtener los datos al combo
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
        //Cargar los datos al combo metodo
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
