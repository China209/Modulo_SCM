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

namespace CapaVista.Mantenimientos.Pais
{
    public partial class frmPais : Form
    {
        
        clsControladorPais controlPais = new clsControladorPais();
        private clsPais Pais;
        // metodos para manejear los datos 
        public frmPais()
        {
            InitializeComponent();
            cargarDatos();
            txtCodigo.Enabled = true;
        }

        // cargar todos los datos a utilzar 
        private void cargarDatos()
        {
            dgvPais.DataSource = controlPais.obtenerTodo();
        }

        // Metodo para retornar todos los datos 
        private clsPais llenarCampos()
        {
            clsPais auxPais = new clsPais();

            auxPais.SNombre_pais = txtNombre.Text;
            auxPais.SCapital_pais = txtCapital.Text;
            auxPais.IEstado_pais = 1;
            return auxPais;
        }

        // Metodo para verificar la inserción de los datos 
        private bool guardarDatos()
        {
            this.Pais = llenarCampos();
            try
            {
                if (ValidarTextbox() == true)
                {
                    controlPais.insertarPais(this.Pais);
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

        //metodo para validar los atributos que estan vacios 
        private bool ValidarTextbox()
        {

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese Nombre", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                txtNombre.Focus();
                return false;
            }
            else if (txtCapital.Text == "")
            {
                MessageBox.Show("Ingrese Capital", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCapital.Text = "";
                txtCapital.Focus();
                return false;
            }

            else if (!Regex.Match(txtNombre.Text, @"^[A-Za-z]+([\ A-Za-z]+)*$").Success)
            {
                MessageBox.Show("Datos del campo nombre invalido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                txtNombre.Focus();
                return false;
            }
            if (txtNombre.Text == "" && txtCapital.Text == "")
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
            txtNombre.Text = "";
            txtCapital.Text = "";
            txtNombre.Focus();

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
