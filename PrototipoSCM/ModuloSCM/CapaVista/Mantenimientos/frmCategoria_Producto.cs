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

namespace CapaVista.Mantenimientos.Producto
{
    public partial class frmCategoria_Producto : Form
    {

        clsControladorCategoriaProducto controlCategoria = new clsControladorCategoriaProducto();
        private clsCategoriaProducto Categoria;
        // metodos para manejear los datos 
        public frmCategoria_Producto()
        {
            InitializeComponent();
            cargarDatos();
            txtCodigo.Enabled = true;
        }

        // cargar todos los datos a utilzar 
        private void cargarDatos()
        {
            dgvCategoria.DataSource = controlCategoria.obtenerTodo();
        }

        // Metodo para retornar todos los datos 
        private clsCategoriaProducto llenarCampos()
        {
            clsCategoriaProducto auxCategoria = new clsCategoriaProducto();
            auxCategoria.SDescripcion_Categoria_producto = txtNombre.Text;
            auxCategoria.IEstado_Categoria_producto = 1;
            return auxCategoria;
        }

        // Metodo para verificar la inserción de los datos 
        private bool guardarDatos()
        {
            this.Categoria = llenarCampos();
            try
            {
                if (ValidarTextbox() == true)
                {
                    controlCategoria.insertarCategoria(this.Categoria);
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
            else if (!Regex.Match(txtNombre.Text, @"^[A-Za-z]+([\ A-Za-z]+)*$").Success)
            {
                MessageBox.Show("Datos del campo nombre invalido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Text = "";
                txtNombre.Focus();
                return false;
            }
            return true;

        }

        // metodo para limpiar todos los atributos del formulario 
        private void LimpiarComponentes()
        {
           
            txtNombre.Text = "";
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
