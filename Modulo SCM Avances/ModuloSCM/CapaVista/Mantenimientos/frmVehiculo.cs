using CapaControlador.ControladorModulo;
using CapaModelo.Clases_Modulo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Mantenimientos.Vehiculo
{
    public partial class frmVehiculo : Form
    {
        clsControladorVehiculo controlVehiculo = new clsControladorVehiculo();
        private clsVehiculo Vehiculo;
        // metodos para manejear los datos 
        public frmVehiculo()
        {
            InitializeComponent();
            CargarCombobox();
            cargarDatos();
            txtCodigo.Enabled = true;
        }

        // metodo para cargar Datos a combobox
        private void CargarCombobox()
        {
            cmbMarca.DisplayMember = "pk_id_marca";
            cmbMarca.ValueMember = "pk_id_marca";
            cmbMarca.DataSource = controlVehiculo.obtenerCamposCombobox("pk_id_marca", "descripcion_marca", " MARCA", " estado_marca");
            cmbMarca.SelectedIndex = -1;
        }

        // cargar todos los datos a utilzar 
        private void cargarDatos()
        {
            dgvVehiculo.DataSource = controlVehiculo.obtenerTodo();
        }

        // Metodo para retornar todos los datos 
        private clsVehiculo llenarCampos()
        {
            clsVehiculo auxVehiculo = new clsVehiculo();
            auxVehiculo.IdMarca = int.Parse(cmbMarca.Text.ToString());
            auxVehiculo.SPlaca_vehiculo = txtPlaca.Text;
            auxVehiculo.SModelo_vehiculo = txtModelo.Text;
            auxVehiculo.SColor_vehiculo = txtColor.Text;
            auxVehiculo.SAnio_vehiculo = txtAnio.Text;
            auxVehiculo.STpo_Combustible_vehiculo = txtCombustible.Text;
            auxVehiculo.IEstado_vehiculo = 1;
            return auxVehiculo;
        }

        // Metodo para verificar la inserción de los datos 
        private bool guardarDatos()
        {
            this.Vehiculo = llenarCampos();
            try
            {
                if (ValidarTextbox() == true)
                {
                    controlVehiculo.insertarVehiculo(this.Vehiculo);
                    cargarDatos();
                    MessageBox.Show("Datos Correctamente Guardados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar los Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // valida el ingreso de datos permitiendo solo ingresar  letras 
        private void txtCombustible_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsLetter(cCaracter) && cCaracter != 8 && cCaracter != 32)
            {
                e.Handled = true;
            }
        }


        //metodo para validar los atributos que estan vacios 
        private bool ValidarTextbox()
        {

            if (txtPlaca.Text == "")
            {
                MessageBox.Show("Ingrese Placa", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlaca.Text = "";
                txtPlaca.Focus();
                return false;
            }
            else if (txtAnio.Text == "")
            {
                MessageBox.Show("Ingrese Año", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnio.Text = "";
                txtAnio.Focus();
                return false;
            }
            else if (txtModelo.Text == "")
            {
                MessageBox.Show("Ingrese Modelo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModelo.Text = "";
                txtModelo.Focus();
                return false;
            }
            else if (txtColor.Text == "")
            {
                MessageBox.Show("Ingrese Color", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtColor.Text = "";
                txtColor.Focus();
                return false;
            }
            else if (txtCombustible.Text == "")
            {
                MessageBox.Show("Ingrese Combustible", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCombustible.Text = "";
                txtCombustible.Focus();
                return false;
            }

            else if (!Regex.Match(txtPlaca.Text, @"^[A-Za-z]+([\ A-Za-z]+)*$").Success)
            {
                MessageBox.Show("Datos del campo nombre invalido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlaca.Text = "";
                txtPlaca.Focus();
                return false;
            }
            if (txtPlaca.Text == "" && txtAnio.Text == "" )
            {
                MessageBox.Show("Llene los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarComponentes();
                return false;
            }
            return true;

        }

        // metodo para limpiar todos los atributos del formulario  
        private void LimpiarComponentes()
        {
            cmbMarca.SelectedIndex = -1;
            txtPlaca.Text = "";
            txtModelo.Text = "";
            txtColor.Text = "";
            txtAnio.Text = "";
            txtCombustible.Text = "";
        }

        // metodo para limpiar los componentes cuando la insercion de los datos fue correcta 
        private void btnGuardar_Click(object sender, EventArgs e)
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

        // metodo para validar la salida 
        private void frmAplicativo_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
